using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Duplicates_Detector
{
    public partial class DeleteForm : Form
    {
        public DeleteForm()
        {
            InitializeComponent();
        }

        public MainForm MainForm { private get; set; }
        public string Key { private get; set; }
        private int IndexCount;

        public bool AllDelete { get => AllButton.Checked; }
        private int __DeleteIndex;
        public int DeleteIndex
        {
            get => __DeleteIndex;
            private set
            {
                if (value < 0)
                {
                    __DeleteIndex = IndexCount - 1;
                }
                else if (value >= IndexCount)
                {
                    __DeleteIndex = 0;
                }
                else
                {
                    __DeleteIndex = value;
                }

                MainForm.TextBox.Select(MainForm.Pairs[Key][__DeleteIndex], Key.Length);
            }
        }

        private void DeleteForm_Load(object sender, EventArgs e)
        {
            AllButton.Checked = true;
        }

        private void OneButton_CheckedChanged(object sender, EventArgs e)
        {
            if (PrevButton.Enabled = NextButton.Enabled = PrevPrevButton.Enabled = NextNextButton.Enabled = OneButton.Checked)
            {
                IndexCount = MainForm.Pairs[Key].Length;
                DeleteIndex = 0;
            }
        }

        private void PrevButton_Click(object sender, EventArgs e)
        {
            DeleteIndex--;
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            DeleteIndex++;
        }

        private void PrevPrevButton_Click(object sender, EventArgs e)
        {
            DeleteIndex -= 10;
        }

        private void NextNextButton_Click(object sender, EventArgs e)
        {
            DeleteIndex += 10;
        }
    }
}
