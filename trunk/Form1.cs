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
            this.Files.DragDrop += new System.Windows.Forms.DragEventHandler(this.Files_DragDrop);
            this.Files.DragEnter += new System.Windows.Forms.DragEventHandler(this.Files_DragEnter);
            this.listBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBox1_DragDrop);
            this.listBox1.DragEnter += new System.Windows.Forms.DragEventHandler(this.listBox1_DragEnter);
            this.listBox2.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBox2_DragDrop);
            this.listBox2.DragEnter += new System.Windows.Forms.DragEventHandler(this.listBox2_DragEnter);

            this.Menu = mainMenu;
            MenuItem miFile = mainMenu.MenuItems.Add("&File");
            miFile.MenuItems.Add(new MenuItem("&Add File(s)", new EventHandler(this.FileOpen_Clicked), Shortcut.CtrlF));
            miFile.MenuItems.Add("-");
            miFile.MenuItems.Add(new MenuItem("&Add Folder", new EventHandler(this.FolderOpen_Clicked), Shortcut.CtrlO));
            miFile.MenuItems.Add("-");
            miFile.MenuItems.Add(new MenuItem("&Exit", new EventHandler(this.FileExit_Clicked), Shortcut.CtrlX));
        
            listBox2.Items.Add(new FileData("C:\\Documents and Settings\\Jeremy\\Desktop\\Nate_Wolverine_2.jpg"));
        }

        private void Files_SelectedIndexChanged(object sender, EventArgs e)
        {

            PopulateFields((FileData)this.Files.SelectedItem);

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
                Files.Items.Add(s[i]);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateFields((FileData)this.listBox1.SelectedItem);
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
                listBox1.Items.Add(s[i]);
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateFields((FileData)this.listBox2.SelectedItem);
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
                listBox2.Items.Add(s[i]);
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
                            Files.Items.Add(temp);
                            check = true;
                            tabControl1.SelectTab(AudioPage);
                        }
                        else if ((FI.Extension == ".avi") || (FI.Extension == ".mov") || (FI.Extension == ".divx") || (FI.Extension == ".MP4"))
                        {
                            temp = FI.Name.ToString();
                            listBox1.Items.Add(temp);
                            check = true;
                            tabControl1.SelectTab(VideoPage);
                        }
                        else if ((FI.Extension == ".bmp") || (FI.Extension == ".jpg") || (FI.Extension == ".gif") || (FI.Extension == ".png") || (FI.Extension == ".tif") || (FI.Extension == ".jpeg") || (FI.Extension == ".JPG"))
                        {
                            temp = FI.Name;
                            int a = temp.LastIndexOf('.');
                            temp = temp.Remove(a, 5);
                            listBox2.Items.Add(temp);
                            imageArray[i] = FI.FullName;
                            i++;
                            check = true;
                            tabControl1.SelectTab(PicturePage);
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
                            Files.Items.Add(temp);
                            check = true;
                            tabControl1.SelectTab(AudioPage);
                        }
                        else if ((FI.Extension == ".avi") || (FI.Extension == ".mov") || (FI.Extension == ".divx") || (FI.Extension == ".MP4"))
                        {
                            temp = FI.Name.ToString();
                            listBox1.Items.Add(temp);
                            check = true;
                            tabControl1.SelectTab(VideoPage);
                        }
                        else if ((FI.Extension == ".bmp") || (FI.Extension == ".jpg") || (FI.Extension == ".gif") || (FI.Extension == ".png") || (FI.Extension == ".tif") || (FI.Extension == ".jpeg") || (FI.Extension == ".JPG"))
                        {
                            temp = FI.Name.ToString();
                            listBox2.Items.Add(temp);
                            check = true;
                            tabControl1.SelectTab(PicturePage);
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
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;

            //displays file size
            this.textBox4.Text = data.GetFileSize();

            ////displays the thumbnail image
            pictureBox2.ImageLocation = data.GetFilePath();

            //displays the file path to the file info box
            this.textBox2.Text = data.GetFilePath();

            //displays the file type
            this.textBox3.Text = data.GetFileType();
            
        }
       
    }
}