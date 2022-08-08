namespace Duplicates_Detector
{
    partial class DeleteForm
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
            this.OKButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.AllButton = new System.Windows.Forms.RadioButton();
            this.OneButton = new System.Windows.Forms.RadioButton();
            this.PrevButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.NextNextButton = new System.Windows.Forms.Button();
            this.PrevPrevButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OKButton
            // 
            this.OKButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OKButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OKButton.Location = new System.Drawing.Point(59, 60);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 4;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.Location = new System.Drawing.Point(140, 60);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 5;
            this.CancelButton.Text = "キャンセル";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // AllButton
            // 
            this.AllButton.AutoSize = true;
            this.AllButton.Checked = true;
            this.AllButton.Location = new System.Drawing.Point(12, 12);
            this.AllButton.Name = "AllButton";
            this.AllButton.Size = new System.Drawing.Size(87, 16);
            this.AllButton.TabIndex = 0;
            this.AllButton.TabStop = true;
            this.AllButton.Text = "全て削除する";
            this.AllButton.UseVisualStyleBackColor = true;
            // 
            // OneButton
            // 
            this.OneButton.AutoSize = true;
            this.OneButton.Location = new System.Drawing.Point(12, 34);
            this.OneButton.Name = "OneButton";
            this.OneButton.Size = new System.Drawing.Size(79, 16);
            this.OneButton.TabIndex = 1;
            this.OneButton.Text = "1つだけ残す";
            this.OneButton.UseVisualStyleBackColor = true;
            this.OneButton.CheckedChanged += new System.EventHandler(this.OneButton_CheckedChanged);
            // 
            // PrevButton
            // 
            this.PrevButton.Enabled = false;
            this.PrevButton.Location = new System.Drawing.Point(133, 32);
            this.PrevButton.Name = "PrevButton";
            this.PrevButton.Size = new System.Drawing.Size(20, 20);
            this.PrevButton.TabIndex = 2;
            this.PrevButton.Text = "<";
            this.PrevButton.UseVisualStyleBackColor = true;
            this.PrevButton.Click += new System.EventHandler(this.PrevButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.Enabled = false;
            this.NextButton.Location = new System.Drawing.Point(159, 32);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(20, 20);
            this.NextButton.TabIndex = 3;
            this.NextButton.Text = ">";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // NextNextButton
            // 
            this.NextNextButton.Enabled = false;
            this.NextNextButton.Location = new System.Drawing.Point(185, 32);
            this.NextNextButton.Name = "NextNextButton";
            this.NextNextButton.Size = new System.Drawing.Size(30, 20);
            this.NextNextButton.TabIndex = 3;
            this.NextNextButton.Text = ">>";
            this.NextNextButton.UseVisualStyleBackColor = true;
            this.NextNextButton.Click += new System.EventHandler(this.NextNextButton_Click);
            // 
            // PrevPrevButton
            // 
            this.PrevPrevButton.Enabled = false;
            this.PrevPrevButton.Location = new System.Drawing.Point(97, 32);
            this.PrevPrevButton.Name = "PrevPrevButton";
            this.PrevPrevButton.Size = new System.Drawing.Size(30, 20);
            this.PrevPrevButton.TabIndex = 2;
            this.PrevPrevButton.Text = "<<";
            this.PrevPrevButton.UseVisualStyleBackColor = true;
            this.PrevPrevButton.Click += new System.EventHandler(this.PrevPrevButton_Click);
            // 
            // DeleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 95);
            this.Controls.Add(this.NextNextButton);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.PrevPrevButton);
            this.Controls.Add(this.PrevButton);
            this.Controls.Add(this.OneButton);
            this.Controls.Add(this.AllButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OKButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DeleteForm";
            this.Text = "重複を削除";
            this.Load += new System.EventHandler(this.DeleteForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OKButton;
        private new System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.RadioButton AllButton;
        private System.Windows.Forms.RadioButton OneButton;
        private System.Windows.Forms.Button PrevButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button NextNextButton;
        private System.Windows.Forms.Button PrevPrevButton;
    }
}