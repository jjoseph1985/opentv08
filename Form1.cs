using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.DirectoryServices;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        bool check;
        MainMenu mainMenu = new MainMenu();
        ContextMenu label4ContextMenu = new ContextMenu();

        public Form1()
        {
            InitializeComponent();

            //gives event handler notification of control forms
            this.AudioListBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.AudioListBox_DragDrop);
            this.AudioListBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.AudioListBox_DragEnter);
            this.AudioListBox.KeyDown += new KeyEventHandler(AudioListBox_KeyDown);
            this.VideoListBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.VideoListBox_DragDrop);
            this.VideoListBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.VideoListBox_DragEnter);
            this.VideoListBox.KeyDown += new KeyEventHandler(VideoListBox_KeyDown);
            this.PictureListBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.PictureListBox_DragDrop);
            this.PictureListBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.PictureListBox_DragEnter);
            this.PictureListBox.KeyDown += new KeyEventHandler(PictureListBox_KeyDown);

            this.Menu = mainMenu;
            MenuItem miFile = mainMenu.MenuItems.Add("&File");
            miFile.MenuItems.Add(new MenuItem("&Add File(s)", new EventHandler(this.FileOpen_Clicked), Shortcut.CtrlF));
            miFile.MenuItems.Add("-");
            miFile.MenuItems.Add(new MenuItem("&Add Folder", new EventHandler(this.FolderOpen_Clicked), Shortcut.CtrlO));
            miFile.MenuItems.Add("-");
            miFile.MenuItems.Add(new MenuItem("&Exit", new EventHandler(this.FileExit_Clicked), Shortcut.CtrlX));
        }


        /// <summary>
        /// Key Down Events
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void VideoListBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 46)
            {
                this.VideoListBox.Items.RemoveAt(VideoListBox.SelectedIndex);
                ClearFields();
            }
        }

        void AudioListBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 46)
            {
                this.AudioListBox.Items.RemoveAt(AudioListBox.SelectedIndex);
                ClearFields();
            }
        }

        void PictureListBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 46)
            {
                this.PictureListBox.Items.RemoveAt(PictureListBox.SelectedIndex);
                ClearFields();
            }
        }
        
        private void AudioListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            PopulateFields((FileData)this.AudioListBox.SelectedItem);

        }

        private void AudioListBox_DragEnter(object sender, System.Windows.Forms.DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }

        private void AudioListBox_DragDrop(object sender, System.Windows.Forms.DragEventArgs e)
        {
            
            string[] s = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            int i;
            for (i = 0; i < s.Length; i++)
            {
                AddFiles(s[i]);
            }
        }

        private void VideoListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateFields((FileData)this.VideoListBox.SelectedItem);
        }

        private void VideoListBox_DragEnter(object sender, System.Windows.Forms.DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }

        private void VideoListBox_DragDrop(object sender, System.Windows.Forms.DragEventArgs e)
        {
            string[] s = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            int i;
            for (i = 0; i < s.Length; i++)
                AddFiles(s[i]);
        }

        private void PictureListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(PictureListBox.SelectedIndex != -1)
                PopulateFields((FileData)this.PictureListBox.SelectedItem);
        }

        private void PictureListBox_DragEnter(object sender, System.Windows.Forms.DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }

        private void PictureListBox_DragDrop(object sender, System.Windows.Forms.DragEventArgs e)
        {
            string[] s = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            int i;
            for (i = 0; i < s.Length; i++)
                AddFiles(s[i]);
        }

        private void FileOpen_Clicked(object sender, System.EventArgs e)
        {
            check = false;

            while (check == false)
            {
                if (openFileDialog4.ShowDialog() == DialogResult.OK)
                {
                    foreach (string fileName in openFileDialog4.FileNames)
                    {
                        AddFiles(fileName);
                    }
                }
                else
                {
                    check = true;
                }
            }   
       }

        private void FolderOpen_Clicked(object sender, System.EventArgs e)
        {
            check = false;

            while (check == false)
            {
                if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                    string folderName = this.folderBrowserDialog1.SelectedPath;

                    foreach (string fileName in Directory.GetFiles(folderName))
                    {   
                        AddFiles(fileName);
                    }
                }
                else
                {
                    check = true;
                }

            }
        }

        private void FileExit_Clicked(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void PopulateFields(FileData data)
        {
            //sets the picture box thumbnail size
            PreviewBox.SizeMode = PictureBoxSizeMode.Zoom;

            //displays file size
            this.SizeTextBox.Text = data.GetFileSize();

            ////displays the thumbnail image
            PreviewBox.ImageLocation = data.GetFilePath();

            //displays the file path to the file info box
            this.PathTextBox.Text = data.GetFilePath();

            //displays the file type
            this.TypeTextBox.Text = data.GetFileExtension();
            
        }

        private void ClearFields()
        {
            this.SizeTextBox.Clear();

            this.PathTextBox.Clear();

            this.PreviewBox.ImageLocation = "";

            this.TypeTextBox.Clear();
        }

        private void AddFiles(string fileName)
        {
                FileInfo FI = new FileInfo(fileName);
                FileData FD = new FileData(FI.FullName);

                if (FD.GetFileType() == "Audio")
                {
                    AudioListBox.Items.Add(FD);
                    check = true;
                    FileTabs.SelectTab(AudioPage);
                }
                else if (FD.GetFileType() == "Video")
                {
                    VideoListBox.Items.Add(FD);
                    check = true;
                    FileTabs.SelectTab(VideoPage);
                }
                else if (FD.GetFileType() == "Image")
                {
                    PictureListBox.Items.Add(FD);
                    check = true;
                    FileTabs.SelectTab(PicturePage);
                }
                else if (FD.GetFileType() == "Invalid")
                {
                    MessageBox.Show("Invalid File. Please select a media file.", "Invalid File", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }         
        }
    }
}