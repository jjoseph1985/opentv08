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
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            this.PicturePreviewBox = new System.Windows.Forms.PictureBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.PauseButton = new System.Windows.Forms.Button();
            this.PlayButton = new System.Windows.Forms.Button();
            this.RewindButton = new System.Windows.Forms.Button();
            this.FullScreenButton = new System.Windows.Forms.Button();
            this.FastForwardButton = new System.Windows.Forms.Button();
            this.progressLabel = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.FileTabs.SuspendLayout();
            this.AudioPage.SuspendLayout();
            this.VideoPage.SuspendLayout();
            this.PicturePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicturePreviewBox)).BeginInit();
            this.SuspendLayout();
            // 
            // TransferProgBar
            // 
            this.TransferProgBar.Location = new System.Drawing.Point(82, 439);
            this.TransferProgBar.Name = "TransferProgBar";
            this.TransferProgBar.Size = new System.Drawing.Size(139, 23);
            this.TransferProgBar.TabIndex = 0;
            // 
            // TransferButton
            // 
            this.TransferButton.Location = new System.Drawing.Point(12, 439);
            this.TransferButton.Name = "TransferButton";
            this.TransferButton.Size = new System.Drawing.Size(61, 23);
            this.TransferButton.TabIndex = 1;
            this.TransferButton.Text = "Transfer";
            this.TransferButton.UseVisualStyleBackColor = true;
            this.TransferButton.Click += new System.EventHandler(this.TransferButton_Click);
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
            this.groupBox1.Location = new System.Drawing.Point(232, 185);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(189, 151);
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
            this.FileTabs.Size = new System.Drawing.Size(209, 425);
            this.FileTabs.TabIndex = 13;
            // 
            // AudioPage
            // 
            this.AudioPage.Controls.Add(this.AudioListBox);
            this.AudioPage.Location = new System.Drawing.Point(4, 22);
            this.AudioPage.Name = "AudioPage";
            this.AudioPage.Padding = new System.Windows.Forms.Padding(3);
            this.AudioPage.Size = new System.Drawing.Size(201, 399);
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
            this.VideoPage.Size = new System.Drawing.Size(201, 399);
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
            this.PicturePage.Size = new System.Drawing.Size(201, 399);
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
            this.LogoBox.Location = new System.Drawing.Point(238, 342);
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
            this.groupBox2.Controls.Add(this.player);
            this.groupBox2.Controls.Add(this.PicturePreviewBox);
            this.groupBox2.Location = new System.Drawing.Point(232, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(189, 146);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Preview";
            // 
            // player
            // 
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(6, 19);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(177, 121);
            this.player.TabIndex = 1;
            this.player.Visible = false;
            this.player.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(player_PlayStateChange);
            // 
            // PicturePreviewBox
            // 
            this.PicturePreviewBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("PicturePreviewBox.InitialImage")));
            this.PicturePreviewBox.Location = new System.Drawing.Point(6, 19);
            this.PicturePreviewBox.Name = "PicturePreviewBox";
            this.PicturePreviewBox.Size = new System.Drawing.Size(177, 121);
            this.PicturePreviewBox.TabIndex = 0;
            this.PicturePreviewBox.TabStop = false;
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.ShowNewFolderButton = false;
            // 
            // PauseButton
            // 
            this.PauseButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PauseButton.BackgroundImage")));
            this.PauseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PauseButton.Location = new System.Drawing.Point(271, 151);
            this.PauseButton.Name = "PauseButton";
            this.PauseButton.Size = new System.Drawing.Size(37, 28);
            this.PauseButton.TabIndex = 17;
            this.PauseButton.UseVisualStyleBackColor = true;
            this.PauseButton.Click += new System.EventHandler(this.PauseButton_Click);
            // 
            // PlayButton
            // 
            this.PlayButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PlayButton.BackgroundImage")));
            this.PlayButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PlayButton.Location = new System.Drawing.Point(234, 151);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(36, 28);
            this.PlayButton.TabIndex = 18;
            this.PlayButton.UseVisualStyleBackColor = true;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // RewindButton
            // 
            this.RewindButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RewindButton.BackgroundImage")));
            this.RewindButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RewindButton.Location = new System.Drawing.Point(309, 151);
            this.RewindButton.Name = "RewindButton";
            this.RewindButton.Size = new System.Drawing.Size(37, 28);
            this.RewindButton.TabIndex = 19;
            this.RewindButton.UseVisualStyleBackColor = true;
            this.RewindButton.Click += new System.EventHandler(this.RewindButton_Click);
            // 
            // FullScreenButton
            // 
            this.FullScreenButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FullScreenButton.BackgroundImage")));
            this.FullScreenButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FullScreenButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.FullScreenButton.Location = new System.Drawing.Point(384, 151);
            this.FullScreenButton.Name = "FullScreenButton";
            this.FullScreenButton.Size = new System.Drawing.Size(36, 28);
            this.FullScreenButton.TabIndex = 16;
            this.FullScreenButton.UseVisualStyleBackColor = true;
            this.FullScreenButton.Click += new System.EventHandler(this.FullScreenButton_Click);
            // 
            // FastForwardButton
            // 
            this.FastForwardButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FastForwardButton.BackgroundImage")));
            this.FastForwardButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FastForwardButton.Location = new System.Drawing.Point(347, 151);
            this.FastForwardButton.Name = "FastForwardButton";
            this.FastForwardButton.Size = new System.Drawing.Size(36, 28);
            this.FastForwardButton.TabIndex = 20;
            this.FastForwardButton.UseVisualStyleBackColor = true;
            this.FastForwardButton.Click += new System.EventHandler(this.FastForwardButton_Click);
            // 
            // progressLabel
            // 
            this.progressLabel.Location = new System.Drawing.Point(13, 464);
            this.progressLabel.Name = "progressLabel";
            this.progressLabel.Size = new System.Drawing.Size(209, 13);
            this.progressLabel.TabIndex = 21;
            this.progressLabel.Text = "Select a file to transfer";
            this.progressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(12, 439);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(61, 23);
            this.CancelButton.TabIndex = 22;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Visible = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // Form1
            // 
            this.AccessibleName = "";
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(436, 481);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.progressLabel);
            this.Controls.Add(this.FastForwardButton);
            this.Controls.Add(this.RewindButton);
            this.Controls.Add(this.PlayButton);
            this.Controls.Add(this.FullScreenButton);
            this.Controls.Add(this.PauseButton);
            this.Controls.Add(this.LogoBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.FileTabs);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TransferButton);
            this.Controls.Add(this.TransferProgBar);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "OpenTV File Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.FileTabs.ResumeLayout(false);
            this.AudioPage.ResumeLayout(false);
            this.VideoPage.ResumeLayout(false);
            this.PicturePage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicturePreviewBox)).EndInit();
            this.ResumeLayout(false);

        }

        void player_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            switch (e.newState)
            {
                case 1:    // Stopped
                case 2:    // Paused
                case 8:    // MediaEnded
                case 3:    // Playing
                    player.uiMode = "none";
                    break;
            }
        }

        void Form1_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            CancelButton_Click(null, null);
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
        private System.Windows.Forms.PictureBox PicturePreviewBox;
        public System.Windows.Forms.TextBox SizeTextBox;
        public System.Windows.Forms.ListBox PictureListBox;
        public System.Windows.Forms.TabControl FileTabs;
        private System.Windows.Forms.Button PauseButton;
        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.Button RewindButton;
        private System.Windows.Forms.Button FullScreenButton;
        private System.Windows.Forms.Button FastForwardButton;
        public AxWMPLib.AxWindowsMediaPlayer player;
        public System.Windows.Forms.Label progressLabel;
        private System.Windows.Forms.Button CancelButton;
    }
}

