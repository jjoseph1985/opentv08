namespace WindowsApplication1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TransferProgBar = new System.Windows.Forms.ProgressBar();
            this.TransferButton = new System.Windows.Forms.Button();
            this.AudioListBox = new System.Windows.Forms.ListBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SizeTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PathTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TypeTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FileTabs = new System.Windows.Forms.TabControl();
            this.AudioPage = new System.Windows.Forms.TabPage();
            this.VideoPage = new System.Windows.Forms.TabPage();
            this.VideoListBox = new System.Windows.Forms.ListBox();
            this.PicturePage = new System.Windows.Forms.TabPage();
            this.PictureListBox = new System.Windows.Forms.ListBox();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog3 = new System.Windows.Forms.OpenFileDialog();
            this.LogoBox = new System.Windows.Forms.PictureBox();
            this.openFileDialog4 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PreviewBox = new System.Windows.Forms.PictureBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.FullScreenButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.FileTabs.SuspendLayout();
            this.AudioPage.SuspendLayout();
            this.VideoPage.SuspendLayout();
            this.PicturePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PreviewBox)).BeginInit();
            this.SuspendLayout();
            // 
            // TransferProgBar
            // 
            this.TransferProgBar.Location = new System.Drawing.Point(230, 63);
            this.TransferProgBar.Name = "TransferProgBar";
            this.TransferProgBar.Size = new System.Drawing.Size(135, 23);
            this.TransferProgBar.TabIndex = 0;
            // 
            // TransferButton
            // 
            this.TransferButton.Location = new System.Drawing.Point(260, 34);
            this.TransferButton.Name = "TransferButton";
            this.TransferButton.Size = new System.Drawing.Size(75, 23);
            this.TransferButton.TabIndex = 1;
            this.TransferButton.Text = "Transfer";
            this.TransferButton.UseVisualStyleBackColor = true;
            // 
            // AudioListBox
            // 
            this.AudioListBox.AllowDrop = true;
            this.AudioListBox.FormattingEnabled = true;
            this.AudioListBox.HorizontalScrollbar = true;
            this.AudioListBox.Location = new System.Drawing.Point(-4, 0);
            this.AudioListBox.Name = "AudioListBox";
            this.AudioListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.AudioListBox.Size = new System.Drawing.Size(375, 498);
            this.AudioListBox.TabIndex = 2;
            this.AudioListBox.SelectedIndexChanged += new System.EventHandler(this.AudioListBox_SelectedIndexChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Audio Files(*.mp3;*.m4a;*.wav;*.wma)|*.mp3;*.m4a;*.wav;*.wma|All Files(*.*)|*.*";
            this.openFileDialog1.Multiselect = true;
            this.openFileDialog1.Title = "Select the file(s)";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SizeTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.PathTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TypeTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(389, 189);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(189, 167);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "File Info";
            // 
            // SizeTextBox
            // 
            this.SizeTextBox.Location = new System.Drawing.Point(11, 116);
            this.SizeTextBox.Name = "SizeTextBox";
            this.SizeTextBox.ReadOnly = true;
            this.SizeTextBox.Size = new System.Drawing.Size(165, 20);
            this.SizeTextBox.TabIndex = 8;
            this.SizeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Size";
            // 
            // PathTextBox
            // 
            this.PathTextBox.Location = new System.Drawing.Point(11, 43);
            this.PathTextBox.Name = "PathTextBox";
            this.PathTextBox.ReadOnly = true;
            this.PathTextBox.Size = new System.Drawing.Size(165, 20);
            this.PathTextBox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Type";
            // 
            // TypeTextBox
            // 
            this.TypeTextBox.Location = new System.Drawing.Point(11, 79);
            this.TypeTextBox.Name = "TypeTextBox";
            this.TypeTextBox.ReadOnly = true;
            this.TypeTextBox.Size = new System.Drawing.Size(165, 20);
            this.TypeTextBox.TabIndex = 7;
            this.TypeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Path";
            // 
            // FileTabs
            // 
            this.FileTabs.Controls.Add(this.AudioPage);
            this.FileTabs.Controls.Add(this.VideoPage);
            this.FileTabs.Controls.Add(this.PicturePage);
            this.FileTabs.Location = new System.Drawing.Point(12, 8);
            this.FileTabs.Name = "FileTabs";
            this.FileTabs.SelectedIndex = 0;
            this.FileTabs.Size = new System.Drawing.Size(198, 527);
            this.FileTabs.TabIndex = 13;
            // 
            // AudioPage
            // 
            this.AudioPage.Controls.Add(this.AudioListBox);
            this.AudioPage.Location = new System.Drawing.Point(4, 22);
            this.AudioPage.Name = "AudioPage";
            this.AudioPage.Padding = new System.Windows.Forms.Padding(3);
            this.AudioPage.Size = new System.Drawing.Size(190, 501);
            this.AudioPage.TabIndex = 0;
            this.AudioPage.Text = "Audio Files";
            this.AudioPage.UseVisualStyleBackColor = true;
            // 
            // VideoPage
            // 
            this.VideoPage.Controls.Add(this.VideoListBox);
            this.VideoPage.Location = new System.Drawing.Point(4, 22);
            this.VideoPage.Name = "VideoPage";
            this.VideoPage.Padding = new System.Windows.Forms.Padding(3);
            this.VideoPage.Size = new System.Drawing.Size(190, 501);
            this.VideoPage.TabIndex = 1;
            this.VideoPage.Text = "Video Files";
            this.VideoPage.UseVisualStyleBackColor = true;
            // 
            // VideoListBox
            // 
            this.VideoListBox.AllowDrop = true;
            this.VideoListBox.FormattingEnabled = true;
            this.VideoListBox.HorizontalScrollbar = true;
            this.VideoListBox.Location = new System.Drawing.Point(-4, 0);
            this.VideoListBox.Name = "VideoListBox";
            this.VideoListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.VideoListBox.Size = new System.Drawing.Size(375, 498);
            this.VideoListBox.TabIndex = 3;
            this.VideoListBox.SelectedIndexChanged += new System.EventHandler(this.VideoListBox_SelectedIndexChanged);
            // 
            // PicturePage
            // 
            this.PicturePage.Controls.Add(this.PictureListBox);
            this.PicturePage.Location = new System.Drawing.Point(4, 22);
            this.PicturePage.Name = "PicturePage";
            this.PicturePage.Size = new System.Drawing.Size(190, 501);
            this.PicturePage.TabIndex = 2;
            this.PicturePage.Text = "Picture Files";
            this.PicturePage.UseVisualStyleBackColor = true;
            // 
            // PictureListBox
            // 
            this.PictureListBox.AllowDrop = true;
            this.PictureListBox.FormattingEnabled = true;
            this.PictureListBox.HorizontalScrollbar = true;
            this.PictureListBox.Location = new System.Drawing.Point(-4, 0);
            this.PictureListBox.Name = "PictureListBox";
            this.PictureListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.PictureListBox.Size = new System.Drawing.Size(375, 498);
            this.PictureListBox.TabIndex = 3;
            this.PictureListBox.SelectedIndexChanged += new System.EventHandler(this.PictureListBox_SelectedIndexChanged);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.Filter = "Video Files(*.avi;*.mov;*.divx;*.mp4)|*.avi;*.mov;*.divx;*.mp4|All Files(*.*)|*.*" +
                "";
            this.openFileDialog2.Multiselect = true;
            this.openFileDialog2.Title = "Select the file(s)";
            // 
            // openFileDialog3
            // 
            this.openFileDialog3.Filter = "Picture Files(*.bmp;*.jpg;*.gif;*.png;*.tif)|*.bmp;*.jpg;*gif;*.png;*.tif|All Fil" +
                "es(*.*)|*.*";
            this.openFileDialog3.Multiselect = true;
            // 
            // LogoBox
            // 
            this.LogoBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LogoBox.Image = ((System.Drawing.Image)(resources.GetObject("LogoBox.Image")));
            this.LogoBox.Location = new System.Drawing.Point(400, 402);
            this.LogoBox.Name = "LogoBox";
            this.LogoBox.Size = new System.Drawing.Size(176, 133);
            this.LogoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.LogoBox.TabIndex = 14;
            this.LogoBox.TabStop = false;
            // 
            // openFileDialog4
            // 
            this.openFileDialog4.Filter = "All Media Files(*.mp3;*.m4a;*.wav;*.wma;*.avi;*.mov;*.divx;*.mp4;*.bmp;*.jpg;*.gi" +
                "f;*.png;*.tif)|*.mp3;*.m4a;*.wav;*.wma;*.avi;*.mov;*.divx;*.mp4;*.bmp;*.jpg;*gif" +
                ";*.png;*.tif|All Files(*.*)|*.*";
            this.openFileDialog4.Multiselect = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.PreviewBox);
            this.groupBox2.Location = new System.Drawing.Point(389, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(189, 146);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Preview";
            // 
            // PreviewBox
            // 
            this.PreviewBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("PreviewBox.InitialImage")));
            this.PreviewBox.Location = new System.Drawing.Point(6, 19);
            this.PreviewBox.Name = "PreviewBox";
            this.PreviewBox.Size = new System.Drawing.Size(177, 121);
            this.PreviewBox.TabIndex = 0;
            this.PreviewBox.TabStop = false;
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.ShowNewFolderButton = false;
            // 
            // FullScreenButton
            // 
            this.FullScreenButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FullScreenButton.BackgroundImage")));
            this.FullScreenButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FullScreenButton.Location = new System.Drawing.Point(536, 154);
            this.FullScreenButton.Name = "FullScreenButton";
            this.FullScreenButton.Size = new System.Drawing.Size(36, 28);
            this.FullScreenButton.TabIndex = 16;
            this.FullScreenButton.UseVisualStyleBackColor = true;
            this.FullScreenButton.Click += new System.EventHandler(this.FullScreenButton_Click);
            // 
            // Form1
            // 
            this.AccessibleName = "";
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(588, 547);
            this.Controls.Add(this.FullScreenButton);
            this.Controls.Add(this.LogoBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.FileTabs);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TransferButton);
            this.Controls.Add(this.TransferProgBar);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "OpenTV File Manager";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.FileTabs.ResumeLayout(false);
            this.AudioPage.ResumeLayout(false);
            this.VideoPage.ResumeLayout(false);
            this.PicturePage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PreviewBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar TransferProgBar;
        private System.Windows.Forms.Button TransferButton;
        private System.Windows.Forms.ListBox AudioListBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabPage AudioPage;
        private System.Windows.Forms.TabPage VideoPage;
        private System.Windows.Forms.TabPage PicturePage;
        private System.Windows.Forms.ListBox VideoListBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.OpenFileDialog openFileDialog3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PathTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TypeTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox LogoBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.PictureBox PreviewBox;
        public System.Windows.Forms.TextBox SizeTextBox;
        private System.Windows.Forms.Button FullScreenButton;
        public System.Windows.Forms.ListBox PictureListBox;
        public System.Windows.Forms.TabControl FileTabs;
    }
}

