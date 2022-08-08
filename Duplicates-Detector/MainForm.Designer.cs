namespace Duplicates_Detector
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.TextBox = new System.Windows.Forms.RichTextBox();
            this.LineButton = new System.Windows.Forms.Button();
            this.ListBox = new System.Windows.Forms.ListBox();
            this.SpaceButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.AnyButton = new System.Windows.Forms.Button();
            this.TabButton = new System.Windows.Forms.Button();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.StringButton = new System.Windows.Forms.Button();
            this.SeparatorBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TextBox
            // 
            this.TextBox.AcceptsTab = true;
            this.TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox.EnableAutoDragDrop = true;
            this.TextBox.HideSelection = false;
            this.TextBox.Location = new System.Drawing.Point(12, 27);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(614, 430);
            this.TextBox.TabIndex = 0;
            this.TextBox.Text = "";
            this.TextBox.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.TextBox_LinkClicked);
            this.TextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // LineButton
            // 
            this.LineButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LineButton.Location = new System.Drawing.Point(632, 126);
            this.LineButton.Name = "LineButton";
            this.LineButton.Size = new System.Drawing.Size(200, 23);
            this.LineButton.TabIndex = 5;
            this.LineButton.Text = "行検索";
            this.LineButton.UseVisualStyleBackColor = true;
            this.LineButton.Click += new System.EventHandler(this.LineButton_Click);
            // 
            // ListBox
            // 
            this.ListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListBox.FormattingEnabled = true;
            this.ListBox.IntegralHeight = false;
            this.ListBox.ItemHeight = 12;
            this.ListBox.Location = new System.Drawing.Point(632, 155);
            this.ListBox.Name = "ListBox";
            this.ListBox.Size = new System.Drawing.Size(200, 302);
            this.ListBox.TabIndex = 6;
            this.ListBox.DoubleClick += new System.EventHandler(this.ListBox_DoubleClick);
            this.ListBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ListBox_KeyUp);
            // 
            // SpaceButton
            // 
            this.SpaceButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SpaceButton.Location = new System.Drawing.Point(632, 41);
            this.SpaceButton.Name = "SpaceButton";
            this.SpaceButton.Size = new System.Drawing.Size(200, 23);
            this.SpaceButton.TabIndex = 2;
            this.SpaceButton.Text = "単語検索（半角スペースで区切り）";
            this.SpaceButton.UseVisualStyleBackColor = true;
            this.SpaceButton.Click += new System.EventHandler(this.SpaceButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "テキストはここに↓";
            // 
            // AnyButton
            // 
            this.AnyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AnyButton.Location = new System.Drawing.Point(632, 97);
            this.AnyButton.Name = "AnyButton";
            this.AnyButton.Size = new System.Drawing.Size(154, 23);
            this.AnyButton.TabIndex = 3;
            this.AnyButton.Text = "単語検索（区切り文字→）";
            this.AnyButton.UseVisualStyleBackColor = true;
            this.AnyButton.Click += new System.EventHandler(this.AnyButton_Click);
            // 
            // TabButton
            // 
            this.TabButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TabButton.Location = new System.Drawing.Point(632, 70);
            this.TabButton.Name = "TabButton";
            this.TabButton.Size = new System.Drawing.Size(200, 23);
            this.TabButton.TabIndex = 2;
            this.TabButton.Text = "単語検索（タブ文字で区切り）";
            this.TabButton.UseVisualStyleBackColor = true;
            this.TabButton.Click += new System.EventHandler(this.TabButton_Click);
            // 
            // ProgressBar
            // 
            this.ProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProgressBar.Location = new System.Drawing.Point(106, 12);
            this.ProgressBar.Maximum = 1000;
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(520, 12);
            this.ProgressBar.TabIndex = 7;
            // 
            // StringButton
            // 
            this.StringButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StringButton.Location = new System.Drawing.Point(632, 12);
            this.StringButton.Name = "StringButton";
            this.StringButton.Size = new System.Drawing.Size(200, 23);
            this.StringButton.TabIndex = 1;
            this.StringButton.Text = "文字列検索...";
            this.StringButton.UseVisualStyleBackColor = true;
            this.StringButton.Click += new System.EventHandler(this.StringButton_Click);
            // 
            // SeparatorBox
            // 
            this.SeparatorBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SeparatorBox.Location = new System.Drawing.Point(792, 99);
            this.SeparatorBox.Name = "SeparatorBox";
            this.SeparatorBox.Size = new System.Drawing.Size(40, 19);
            this.SeparatorBox.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 469);
            this.Controls.Add(this.SeparatorBox);
            this.Controls.Add(this.StringButton);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ListBox);
            this.Controls.Add(this.LineButton);
            this.Controls.Add(this.AnyButton);
            this.Controls.Add(this.TabButton);
            this.Controls.Add(this.SpaceButton);
            this.Controls.Add(this.TextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(450, 300);
            this.Name = "MainForm";
            this.Text = "出でよ！重複";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button LineButton;
        private System.Windows.Forms.ListBox ListBox;
        private System.Windows.Forms.Button SpaceButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AnyButton;
        private System.Windows.Forms.Button TabButton;
        public System.Windows.Forms.RichTextBox TextBox;
        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.Windows.Forms.Button StringButton;
        private System.Windows.Forms.TextBox SeparatorBox;
    }
}

