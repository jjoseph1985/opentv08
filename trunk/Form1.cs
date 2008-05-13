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
        string temp;
        bool check;
        MainMenu mainMenu = new MainMenu();
        ContextMenu label4ContextMenu = new ContextMenu();
        string[] imageArray = new string[10];
        int i = 0;

        public Form1()
        {
            InitializeComponent();

            //gives event handler notification of control forms
            this.AudioListBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.Files_DragDrop);
            this.AudioListBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.Files_DragEnter);
            this.VideoListBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBox1_DragDrop);
            this.VideoListBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.listBox1_DragEnter);
            this.PictureListBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBox2_DragDrop);
            this.PictureListBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.listBox2_DragEnter);

            this.Menu = mainMenu;
            MenuItem miFile = mainMenu.MenuItems.Add("&File");
            miFile.MenuItems.Add(new MenuItem("&Add File(s)", new EventHandler(this.FileOpen_Clicked), Shortcut.CtrlF));
            miFile.MenuItems.Add("-");
            miFile.MenuItems.Add(new MenuItem("&Add Folder", new EventHandler(this.FolderOpen_Clicked), Shortcut.CtrlO));
            miFile.MenuItems.Add("-");
            miFile.MenuItems.Add(new MenuItem("&Exit", new EventHandler(this.FileExit_Clicked), Shortcut.CtrlX));
        
            PictureListBox.Items.Add(new FileData("C:\\Documents and Settings\\Jeremy\\Desktop\\Nate_Wolverine_2.jpg"));
        }

        private void Files_SelectedIndexChanged(object sender, EventArgs e)
        {

            PopulateFields((FileData)this.AudioListBox.SelectedItem);

        }

        private void Files_DragEnter(object sender, System.Windows.Forms.DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }

        private void Files_DragDrop(object sender, System.Windows.Forms.DragEventArgs e)
        {
            
            string[] s = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            int i;
            for (i = 0; i < s.Length; i++)
            {
                //s[i] = s[i].Substring(s[i].LastIndexOf("\\") + 1);
                AudioListBox.Items.Add(s[i]);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateFields((FileData)this.VideoListBox.SelectedItem);
        }

        private void listBox1_DragEnter(object sender, System.Windows.Forms.DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }

        private void listBox1_DragDrop(object sender, System.Windows.Forms.DragEventArgs e)
        {
            string[] s = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            int i;
            for (i = 0; i < s.Length; i++)
                VideoListBox.Items.Add(s[i]);
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateFields((FileData)this.PictureListBox.SelectedItem);
        }

        private void listBox2_DragEnter(object sender, System.Windows.Forms.DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }

        private void listBox2_DragDrop(object sender, System.Windows.Forms.DragEventArgs e)
        {
            string[] s = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            int i;
            for (i = 0; i < s.Length; i++)
                PictureListBox.Items.Add(s[i]);
        }

        private void FileOpen_Clicked(object sender, System.EventArgs e)
        {
            check = false;

            while (check == false)
            {
                if (openFileDialog4.ShowDialog() == DialogResult.OK)
                {
                    foreach(string fileName in openFileDialog4.FileNames)
                    {
                        //fileName = openFileDialog4.FileName;
                        FileInfo FI = new FileInfo(fileName);

                        if ((FI.Extension == ".mp3") || (FI.Extension == ".m4a") || (FI.Extension == ".wav") || (FI.Extension == ".wma"))
                        {
                            temp = FI.Name.ToString();
                            AudioListBox.Items.Add(temp);
                            check = true;
                            FileTabs.SelectTab(AudioPage);
                        }
                        else if ((FI.Extension == ".avi") || (FI.Extension == ".mov") || (FI.Extension == ".divx") || (FI.Extension == ".MP4"))
                        {
                            temp = FI.Name.ToString();
                            VideoListBox.Items.Add(temp);
                            check = true;
                            FileTabs.SelectTab(VideoPage);
                        }
                        else if ((FI.Extension == ".bmp") || (FI.Extension == ".jpg") || (FI.Extension == ".gif") || (FI.Extension == ".png") || (FI.Extension == ".tif") || (FI.Extension == ".jpeg") || (FI.Extension == ".JPG"))
                        {
                            temp = FI.Name;
                            int a = temp.LastIndexOf('.');
                            temp = temp.Remove(a, 5);
                            PictureListBox.Items.Add(temp);
                            imageArray[i] = FI.FullName;
                            i++;
                            check = true;
                            FileTabs.SelectTab(PicturePage);
                        }
                        else
                        {
                            MessageBox.Show("Invalid File. Please select a media file.", "Invalid File", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
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
                    string foldername = this.folderBrowserDialog1.SelectedPath;

                    foreach(string fileName in Directory.GetFiles(foldername))
                    {
                        FileInfo FI = new FileInfo(fileName);

                        if ((FI.Extension == ".mp3") || (FI.Extension == ".m4a") || (FI.Extension == ".wav") || (FI.Extension == ".wma"))
                        {
                            temp = FI.Name.ToString();
                            AudioListBox.Items.Add(temp);
                            check = true;
                            FileTabs.SelectTab(AudioPage);
                        }
                        else if ((FI.Extension == ".avi") || (FI.Extension == ".mov") || (FI.Extension == ".divx") || (FI.Extension == ".MP4"))
                        {
                            temp = FI.Name.ToString();
                            VideoListBox.Items.Add(temp);
                            check = true;
                            FileTabs.SelectTab(VideoPage);
                        }
                        else if ((FI.Extension == ".bmp") || (FI.Extension == ".jpg") || (FI.Extension == ".gif") || (FI.Extension == ".png") || (FI.Extension == ".tif") || (FI.Extension == ".jpeg") || (FI.Extension == ".JPG"))
                        {
                            temp = FI.Name.ToString();
                            PictureListBox.Items.Add(temp);
                            check = true;
                            FileTabs.SelectTab(PicturePage);
                        }
                        else
                        {
                            MessageBox.Show("Invalid file. File will not be added.", "Invalid File", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
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
            this.TypeTextBox.Text = data.GetFileType();
            
        }
       
    }
}