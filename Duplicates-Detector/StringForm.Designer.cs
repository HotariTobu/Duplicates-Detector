namespace Duplicates_Detector
{
    partial class StringForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Cancel = new System.Windows.Forms.Button();
            this.Accept = new System.Windows.Forms.Button();
            this.LengthButton = new System.Windows.Forms.RadioButton();
            this.RangeButton = new System.Windows.Forms.RadioButton();
            this.AllButton = new System.Windows.Forms.RadioButton();
            this.LengthUpDown = new System.Windows.Forms.NumericUpDown();
            this.EndUpDown = new System.Windows.Forms.NumericUpDown();
            this.StartUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LengthUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // Cancel
            // 
            this.Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Location = new System.Drawing.Point(327, 96);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 8;
            this.Cancel.Text = "キャンセル";
            this.Cancel.UseVisualStyleBackColor = true;
            // 
            // Accept
            // 
            this.Accept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Accept.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Accept.Location = new System.Drawing.Point(246, 96);
            this.Accept.Name = "Accept";
            this.Accept.Size = new System.Drawing.Size(75, 23);
            this.Accept.TabIndex = 7;
            this.Accept.Text = "OK";
            this.Accept.UseVisualStyleBackColor = true;
            this.Accept.Click += new System.EventHandler(this.Accept_Click);
            // 
            // LengthButton
            // 
            this.LengthButton.AutoSize = true;
            this.LengthButton.Checked = true;
            this.LengthButton.Location = new System.Drawing.Point(12, 12);
            this.LengthButton.Name = "LengthButton";
            this.LengthButton.Size = new System.Drawing.Size(217, 16);
            this.LengthButton.TabIndex = 1;
            this.LengthButton.TabStop = true;
            this.LengthButton.Text = "指定した長さの文字列の重複を検索する";
            this.LengthButton.UseVisualStyleBackColor = true;
            this.LengthButton.CheckedChanged += new System.EventHandler(this.LengthButton_CheckedChanged);
            // 
            // RangeButton
            // 
            this.RangeButton.AutoSize = true;
            this.RangeButton.Location = new System.Drawing.Point(12, 37);
            this.RangeButton.Name = "RangeButton";
            this.RangeButton.Size = new System.Drawing.Size(251, 16);
            this.RangeButton.TabIndex = 3;
            this.RangeButton.Text = "指定した範囲の長さの文字列の重複を検索する";
            this.RangeButton.UseVisualStyleBackColor = true;
            this.RangeButton.CheckedChanged += new System.EventHandler(this.RangeButton_CheckedChanged);
            // 
            // AllButton
            // 
            this.AllButton.AutoSize = true;
            this.AllButton.Location = new System.Drawing.Point(12, 62);
            this.AllButton.Name = "AllButton";
            this.AllButton.Size = new System.Drawing.Size(206, 16);
            this.AllButton.TabIndex = 6;
            this.AllButton.Text = "全ての長さの文字列の重複を検索する";
            this.AllButton.UseVisualStyleBackColor = true;
            // 
            // LengthUpDown
            // 
            this.LengthUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LengthUpDown.Location = new System.Drawing.Point(362, 12);
            this.LengthUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.LengthUpDown.Name = "LengthUpDown";
            this.LengthUpDown.Size = new System.Drawing.Size(40, 19);
            this.LengthUpDown.TabIndex = 2;
            // 
            // EndUpDown
            // 
            this.EndUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EndUpDown.Enabled = false;
            this.EndUpDown.Location = new System.Drawing.Point(362, 37);
            this.EndUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.EndUpDown.Name = "EndUpDown";
            this.EndUpDown.Size = new System.Drawing.Size(40, 19);
            this.EndUpDown.TabIndex = 5;
            // 
            // StartUpDown
            // 
            this.StartUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StartUpDown.Enabled = false;
            this.StartUpDown.Location = new System.Drawing.Point(299, 37);
            this.StartUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.StartUpDown.Name = "StartUpDown";
            this.StartUpDown.Size = new System.Drawing.Size(40, 19);
            this.StartUpDown.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(345, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "-";
            // 
            // StringForm
            // 
            this.AcceptButton = this.Accept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel;
            this.ClientSize = new System.Drawing.Size(414, 131);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StartUpDown);
            this.Controls.Add(this.EndUpDown);
            this.Controls.Add(this.LengthUpDown);
            this.Controls.Add(this.AllButton);
            this.Controls.Add(this.RangeButton);
            this.Controls.Add(this.LengthButton);
            this.Controls.Add(this.Accept);
            this.Controls.Add(this.Cancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StringForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "文字列検索";
            ((System.ComponentModel.ISupportInitialize)(this.LengthUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Accept;
        private System.Windows.Forms.RadioButton LengthButton;
        private System.Windows.Forms.RadioButton RangeButton;
        private System.Windows.Forms.RadioButton AllButton;
        private System.Windows.Forms.NumericUpDown LengthUpDown;
        private System.Windows.Forms.NumericUpDown EndUpDown;
        private System.Windows.Forms.NumericUpDown StartUpDown;
        private System.Windows.Forms.Label label1;
    }
}