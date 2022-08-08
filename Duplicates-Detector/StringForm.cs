using System;
using System.Windows.Forms;

namespace Duplicates_Detector
{
    public partial class StringForm : Form
    {
        public StringForm()
        {
            InitializeComponent();
        }

        public enum Methods
        {
            Length,
            Range,
            All,
        };

        public Methods Method { get; private set; }
        public int[] Params { get; private set; }

        private void Accept_Click(object sender, EventArgs e)
        {
            if (LengthButton.Checked)
            {
                Method = Methods.Length;
                Params = new int[] { (int)LengthUpDown.Value };
            }
            else if (RangeButton.Checked)
            {
                Method = Methods.Range;
                Params = new int[] { (int)StartUpDown.Value, (int)EndUpDown.Value };
            }
            else if (AllButton.Checked)
            {
                Method = Methods.All;
            }
        }

        private void LengthButton_CheckedChanged(object sender, EventArgs e)
        {
            LengthUpDown.Enabled = LengthButton.Checked;
        }

        private void RangeButton_CheckedChanged(object sender, EventArgs e)
        {
            StartUpDown.Enabled = EndUpDown.Enabled = RangeButton.Checked;
        }
    }
}
