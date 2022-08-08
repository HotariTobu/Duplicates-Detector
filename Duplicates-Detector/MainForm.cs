using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Duplicates_Detector
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            DeleteForm = new DeleteForm
            {
                MainForm = this
            };
            StringForm = new StringForm();

            Buffer = null;
            TextBox.DragDrop += TextBox_DragDrop;
        }

        private readonly DeleteForm DeleteForm;
        private readonly StringForm StringForm;

        private string Buffer;

        private void TextBox_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                Buffer = ((string[])e.Data.GetData(DataFormats.FileDrop))[0].EndsWith(".txt")
                    ? MessageBox.Show(this, "ファイルの内容をテキストボックスに入れますか？", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.OK
                        ? File.ReadAllText(((string[])e.Data.GetData(DataFormats.FileDrop))[0])
                        : TextBox.Text
                    : TextBox.Text;
            }
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            if (Buffer != null)
            {
                TextBox.Text = Buffer;
                Buffer = null;
            }
        }

        private void TextBox_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            using (var process = new Process())
            {
                process.StartInfo = new ProcessStartInfo
                {
                    FileName = e.LinkText,
                    
                };
                _ = process.Start();
            }
        }

        private static readonly string[] TabooChars =
        {
            " ",
            "\t",
            "\n",
        };

        private Dictionary<string, int[]> __Pairs;
        public Dictionary<string, int[]> Pairs
        {
            get => __Pairs;
            private set
            {
                __Pairs = value;
                ListBox.Items.Clear();
                ListBox.Items.AddRange(__Pairs.Keys.ToArray());
            }
        }

        private void EmphasizeItem(int start, int length, Color color)
        {
            TextBox.Select(start, length);
            TextBox.SelectionBackColor = color;
        }

        private delegate void EmphasizeItemDelegate((int, string) value);
        private void EmphasizeItem((int, string) value)
        {
            if (TextBox.InvokeRequired)
            {
                TextBox.Invoke(new EmphasizeItemDelegate(EmphasizeItem), value);
            }
            else
            {
                EmphasizeItem(value.Item1, value.Item2.Length, Color.Yellow);
            }
        }

        private void EmphasizeItems(string key, Color color)
        {
            if (!string.IsNullOrWhiteSpace(key) && Pairs.ContainsKey(key))
            {
                int length = key.Length;
                foreach (int start in Pairs[key])
                {
                    EmphasizeItem(start, length, color);
                }
            }
        }

        private int CurrentSelectionStart;
        private int CurrentSelectionLength;

        private void BeginFormat()
        {
            CurrentSelectionStart = TextBox.SelectionStart;
            CurrentSelectionLength = TextBox.SelectionLength;

            TextBox.SelectAll();
            TextBox.SelectionAlignment = HorizontalAlignment.Left;
            TextBox.SelectionBackColor = TextBox.BackColor;
            TextBox.SelectionColor = TextBox.ForeColor;
            TextBox.SelectionFont = TextBox.Font;
        }

        private delegate void SetProgressBarValueDelegate(int value);
        private void SetProgressBarValue(int value)
        {
            ProgressBar.Value = value;
        }

        private void EndFormat()
        {
            TextBox.Select(CurrentSelectionStart, CurrentSelectionLength);

            EmphasisKey = null;

            if (ListBox.Items.Count == 0)
            {
                MessageBox.Show(this, "重複はありませんでした。", "検索は完了しました", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }

            SetProgressBarValue(0);
        }

        private void CompareElements(List<(int, string)> elements, Dictionary<string, int[]> pairs)
        {
            int length = elements.Count;

            ProgressBar.Invoke(new SetProgressBarValueDelegate(SetProgressBarValue), 0);
            int count = 0;

            for (int i = 0; i < length; i++)
            {
                bool hit = false;
                (int, string) key = elements[i];
                var indices = new List<int> { key.Item1 };

                if (pairs.ContainsKey(key.Item2))
                {
                    continue;
                }

                for (int j = i + 1; j < length; j++)
                {
                    (int, string) value = elements[j];
                    if (key.Item2.Equals(value.Item2))
                    {
                        hit = true;
                        EmphasizeItem(value);
                        indices.Add(value.Item1);

                        count++;
                    }
                }

                if (hit)
                {
                    EmphasizeItem(key);
                    pairs.Add(key.Item2, indices.ToArray());

                    count++;
                }

                ProgressBar.Invoke(new SetProgressBarValueDelegate(SetProgressBarValue), (int)((float)count / length * 1000));
            }
        }

        private async void Search()
        {
            string text = TextBox.Text;
            int textLength = text.Length;
            var pairs = new Dictionary<string, int[]>();

            int startIndex = 0;
            int endIndex = 0;
            switch (StringForm.Method)
            {
                case StringForm.Methods.Length:
                    startIndex = StringForm.Params[0];
                    endIndex = StringForm.Params[0] + 1;
                    break;
                case StringForm.Methods.Range:
                    startIndex = StringForm.Params[0];
                    endIndex = StringForm.Params[1] + 1;
                    break;
                case StringForm.Methods.All:
                    startIndex = 1;
                    endIndex = textLength;
                    break;
                default:
                    break;
            }

            if (startIndex < 1 || startIndex > textLength || endIndex < 1 || endIndex > textLength || startIndex > endIndex)
            {
                return;
            }

            for (int i = startIndex; i < endIndex; i++)
            {
                var elements = new List<(int, string)>();

                for (int j = 0; j < textLength - i; j++)
                {
                    string element = text.Substring(j, i);
                    if (element.StartsWith(TabooChars) || element.EndsWith(TabooChars))
                    {
                        continue;
                    }
                    elements.Add((j, element));
                }

                await Task.Run(() => CompareElements(elements, pairs));
            }

            Pairs = pairs;

            EndFormat();
        }

        private async void SearchBySeparator(string separator)
        {
            string text = TextBox.Text;
            var elements = new List<(int, string)>();

            for (int i = 0; i < text.Length;)
            {
                int index = text.IndexOf(separator, i);
                if (index == -1)
                {
                    elements.Add((i, text.Substring(i)));
                    break;
                }
                else if (index - i <= 1)
                {
                    i += separator.Length;
                }
                else
                {
                    elements.Add((i, text.Substring(i, index - i)));
                    i = index + separator.Length;
                }
            }

            var pairs = new Dictionary<string, int[]>();
            await Task.Run(() => CompareElements(elements, pairs));
            Pairs = pairs;

            EndFormat();
        }

        private void StringButton_Click(object sender, EventArgs e)
        {
            if (StringForm.ShowDialog(this) == DialogResult.OK)
            {
                BeginFormat();
                Search();
            }
        }

        private void SpaceButton_Click(object sender, EventArgs e)
        {
            BeginFormat();
            SearchBySeparator(" ");
        }

        private void TabButton_Click(object sender, EventArgs e)
        {
            BeginFormat();
            SearchBySeparator("\t");
        }

        private void AnyButton_Click(object sender, EventArgs e)
        {
            if (SeparatorBox.TextLength == 0)
            {
                MessageBox.Show(this, "区切り文字を指定してください。", "検索できません", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                return;
            }

            BeginFormat();
            SearchBySeparator(SeparatorBox.Text);
        }

        private void LineButton_Click(object sender, EventArgs e)
        {
            BeginFormat();
            SearchBySeparator("\n");
        }

        private string EmphasisKey;

        private void ChangeEmphasis()
        {
            if (ListBox.SelectedIndex != -1)
            {
                CurrentSelectionStart = TextBox.SelectionStart;
                CurrentSelectionLength = TextBox.SelectionLength;

                string key = ListBox.SelectedItem as string;
                EmphasizeItems(EmphasisKey, Color.Yellow);
                EmphasizeItems(key, Color.Red);
                EmphasisKey = key;

                TextBox.Select(CurrentSelectionStart, CurrentSelectionLength);
            }
        }

        private void ListBox_DoubleClick(object sender, EventArgs e)
        {
            ChangeEmphasis();
        }

        private void ListBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ChangeEmphasis();
            }
            else if (e.KeyCode == Keys.Delete)
            {
                if (ListBox.SelectedIndex != -1)
                {
                    string key = ListBox.SelectedItem as string;
                    if (!string.IsNullOrWhiteSpace(key) && Pairs.ContainsKey(key))
                    {
                        DeleteForm.Key = key;
                        if (DeleteForm.ShowDialog(this) == DialogResult.OK)
                        {
                            string text = string.Empty;
                            int offset = 0;
                            int keyLength = key.Length;
                            var transitions = new List<int>();
                            var pairs = new Dictionary<string, int[]>();

                            if (DeleteForm.AllDelete)
                            {
                                foreach (int index in Pairs[key])
                                {
                                    transitions.Add(index);
                                    text += TextBox.Text.Substring(offset, index - offset);
                                    offset = index + keyLength;
                                }

                                //Pairs.Remove(key);
                            }
                            else
                            {
                                int leftIndex = Pairs[key][DeleteForm.DeleteIndex];
                                foreach (int index in Pairs[key])
                                {
                                    if (index != leftIndex)
                                    {
                                        transitions.Add(index);
                                        text += TextBox.Text.Substring(offset, index - offset);
                                        offset = index + keyLength;
                                    }
                                }

                                //Pairs[key] = new int[] { leftIndex };
                            }

                            Pairs.Remove(key);

                            foreach (string value in Pairs.Keys)
                            {
                                int[] indices = Pairs[value];
                                int indicesLength = indices.Length;
                                int[] newIndices = new int[indicesLength];

                                for (int i = 0; i < indicesLength; i++)
                                {
                                    int index = indices[i];
                                    int count = 0;

                                    foreach (int transition in transitions)
                                    {
                                        if (index > transition)
                                        {
                                            count++;
                                        }
                                    }

                                    newIndices[i] = index - keyLength * count;

                                    if (newIndices[i] < 0)
                                    {
                                        throw new Exception("インデックスが負の数になりました。");
                                    }
                                }

                                pairs.Add(value, newIndices);
                            }

                            Pairs = pairs;

                            TextBox.Text = text + TextBox.Text.Substring(offset);

                            foreach (string value in Pairs.Keys)
                            {
                                EmphasizeItems(value, Color.Yellow);
                            }

                            TextBox.SelectionStart = TextBox.SelectionLength = 0;
                        }
                    }
                }
            }
        }
    }

    static class Extensions
    {
        public static bool StartsWith(this string str, string[] values)
        {
            foreach (string value in values)
            {
                if (str.StartsWith(value))
                {
                    return true;
                }
            }

            return false;
        }

        public static bool EndsWith(this string str, string[] values)
        {
            foreach (string value in values)
            {
                if (str.EndsWith(value))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
