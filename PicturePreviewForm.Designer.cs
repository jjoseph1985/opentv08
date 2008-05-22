namespace WindowsApplication1
{
    partial class PicturePreviewForm
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
            this.FullScreenPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.FullScreenPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // FullScreenPictureBox
            // 
            this.FullScreenPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.FullScreenPictureBox.BackColor = System.Drawing.SystemColors.ControlText;
            this.FullScreenPictureBox.InitialImage = null;
            this.FullScreenPictureBox.Location = new System.Drawing.Point(0, 0);
            this.FullScreenPictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.FullScreenPictureBox.Name = "FullScreenPictureBox";
            this.FullScreenPictureBox.Size = new System.Drawing.Size(540, 419);
            this.FullScreenPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.FullScreenPictureBox.TabIndex = 0;
            this.FullScreenPictureBox.TabStop = false;
            this.FullScreenPictureBox.LoadCompleted += new System.ComponentModel.AsyncCompletedEventHandler(this.FullScreenPictureBox_LoadCompleted);
            // 
            // PicturePreviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(540, 419);
            this.Controls.Add(this.FullScreenPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PicturePreviewForm";
            this.Text = "PicturePreviewForm";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.FullScreenPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        void FullScreenPictureBox_LoadCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            if ((FullScreenPictureBox.Image.Width > FullScreenPictureBox.Width) || (FullScreenPictureBox.Image.Height > FullScreenPictureBox.Height))
                FullScreenPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            else
                FullScreenPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;

            FullScreenPictureBox.Visible = true;
        }

        #endregion

        public System.Windows.Forms.PictureBox FullScreenPictureBox;

    }
}