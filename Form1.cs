using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.DirectoryServices;
using System.Xml;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.Collections;
using System.Net.Sockets;
using System.Threading;
using WMPLib;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        bool check;
        MainMenu mainMenu = new MainMenu();
        ContextMenu label4ContextMenu = new ContextMenu();
        public bool movieFlag = false;
        public string chosenIP = "10.34.33.214";
        public string chosenPort = "8221";

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
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
 
            ReadXML();

            this.Menu = mainMenu;
            MenuItem miFile = mainMenu.MenuItems.Add("&File");
            miFile.MenuItems.Add(new MenuItem("&Add File(s)", new EventHandler(this.FileOpen_Clicked), Shortcut.CtrlF));
            miFile.MenuItems.Add("-");
            miFile.MenuItems.Add(new MenuItem("&Add Folder", new EventHandler(this.FolderOpen_Clicked), Shortcut.CtrlO));
            miFile.MenuItems.Add("-");
            miFile.MenuItems.Add(new MenuItem("&Connection Settings", new EventHandler(this.ConnSet_Clicked), Shortcut.CtrlC));
            miFile.MenuItems.Add("-");
            miFile.MenuItems.Add(new MenuItem("&Exit", new EventHandler(this.FileExit_Clicked), Shortcut.CtrlX));
        }

        void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            this.player.fullScreen = false;
            this.player.uiMode = "None";
        }



        /// <summary>
        /// Key Down Events
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 

        void VideoListBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 46)
            {
                this.VideoListBox.Items.RemoveAt(VideoListBox.SelectedIndex);
                ClearFields();
                CreateXML("Video");
            }
        }

        void AudioListBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 46)
            {
                this.AudioListBox.Items.RemoveAt(AudioListBox.SelectedIndex);
                ClearFields();
                CreateXML("Audio");
            }
        }

        void PictureListBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 46)
            {
                this.PictureListBox.Items.RemoveAt(PictureListBox.SelectedIndex);
                ClearFields();
                CreateXML("Image");
            }
        }
        
        private void AudioListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            PicturePreviewBox.Visible = false;
            if (AudioListBox.SelectedIndex != -1)
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
            PicturePreviewBox.Visible = false;
            if (VideoListBox.SelectedIndex != -1)
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
            player.Visible = false;
            if (player.playState == WMPPlayState.wmppsPlaying)
            {
                if (movieFlag == true) 
                {
                    player.Ctlcontrols.stop();
                    movieFlag = false;
                }
            }
            PicturePreviewBox.Visible = true;
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

        private void ConnSet_Clicked(object sender, System.EventArgs e)
        {
            IPConfigForm ip = new IPConfigForm(this);
            ip.ShowDialog();
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
            PicturePreviewBox.SizeMode = PictureBoxSizeMode.Zoom;

            //displays file size
            this.SizeTextBox.Text = data.GetFileSize();

            ////displays the thumbnail image
            PicturePreviewBox.ImageLocation = data.GetFilePath();

            //displays the file path to the file info box
            this.PathTextBox.Text = data.GetFilePath();

            //displays the file type
            this.TypeTextBox.Text = data.GetFileExtension();
            
        }

        private void ClearFields()
        {
            this.SizeTextBox.Clear();

            this.PathTextBox.Clear();

            this.PicturePreviewBox.ImageLocation = "";

            this.TypeTextBox.Clear();
        }

        private void AddFiles(string fileName)
        {
            try
            {
                FileInfo FI = new FileInfo(fileName);
                FileData FD = new FileData(FI.FullName);

                if (FD.GetFileType() == "Audio")
                {
                    for (int i = 0; i < AudioListBox.Items.Count; i++)
                    {
                        if (FD == (FileData)AudioListBox.Items[i])
                        {
                            AudioListBox.Items.RemoveAt(i);
                            i--;
                        }
                    }
                    AudioListBox.Items.Add(FD);
                    FileTabs.SelectTab(AudioPage);

                    check = true;
                    CreateXML("Audio");
                }
                else if (FD.GetFileType() == "Video")
                {
                    for (int i = 0; i < VideoListBox.Items.Count; i++)
                    {
                        if (FD == (FileData)VideoListBox.Items[i])
                        {
                            VideoListBox.Items.RemoveAt(i);
                            i--;
                        }
                    }

                    VideoListBox.Items.Add(FD);
                    FileTabs.SelectTab(VideoPage);

                    check = true;
                    CreateXML("Video");
                }
                else if (FD.GetFileType() == "Image")
                {
                    for(int i = 0; i<PictureListBox.Items.Count;i++)
                    {
                        if (FD == (FileData)PictureListBox.Items[i])
                        {
                            PictureListBox.Items.RemoveAt(i);
                            i--;
                        }
                    }

                    PictureListBox.Items.Add(FD);
                    FileTabs.SelectTab(PicturePage);
                    
                    check = true;
                    CreateXML("Image");
                }
                else if (FD.GetFileType() == "Invalid")
                {
                    MessageBox.Show("Invalid File: " + fileName, "Invalid File", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception)
            {
            }
        }

        public void FullScreenButton_Click(object sender, EventArgs e)
        {
            PicturePreviewForm imagePreview = new PicturePreviewForm(this.PictureListBox);
            FileData FD = new FileData();
            if (FileTabs.SelectedTab == PicturePage)
            {
                FD = (FileData)this.PictureListBox.SelectedItem;               
                imagePreview.Show();
                imagePreview.FullScreenPictureBox.ImageLocation = FD.GetFilePath();
            }
            else if(FileTabs.SelectedTab == AudioPage)
            {
                if (player.playState == WMPPlayState.wmppsPlaying)
                    player.fullScreen = true;
                else
                    MessageBox.Show("Please Start Audio File First.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (FileTabs.SelectedTab == VideoPage)
            {
                if (player.playState == WMPPlayState.wmppsPlaying)
                {
                    player.uiMode = "full";
                    player.fullScreen = true;
                }
                else
                    MessageBox.Show("Please Start Video File First.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
        private void CreateXML(string type)
        {
            ListBox myBox = new ListBox();
            if (type == "Audio")
                myBox = this.AudioListBox;
            else if (type == "Image")
                myBox = this.PictureListBox;
            else
                myBox = this.VideoListBox;

            string filename = Application.StartupPath + "\\" + type + ".xml";

            ArrayList theFiles = new ArrayList();
            foreach (FileData theFile in myBox.Items)
            {
                theFiles.Add(theFile);
            }

            XmlSerializer serializer = new XmlSerializer(typeof(ArrayList), new Type[] { typeof(FileData) });
            TextWriter writer = new StreamWriter(filename);
            serializer.Serialize(writer, theFiles);
            writer.Close();
        }

        protected void ReadXML()
        {
            string filename;
            XmlSerializer serializer = new XmlSerializer(typeof(ArrayList), new Type[] { typeof(FileData) });
            
            //IMAGES
            filename = Application.StartupPath + "\\Image.xml";
            if (File.Exists(filename) == true)
            {
                FileStream fs = new FileStream(filename, FileMode.Open);

                ArrayList list = serializer.Deserialize(fs) as ArrayList;
                foreach (FileData o in list)
                {
                    this.PictureListBox.Items.Add(o);
                }
            }

            //VIDEOS
            filename = Application.StartupPath + "\\Video.xml";
            if (File.Exists(filename) == true)
            {
                FileStream fs = new FileStream(filename, FileMode.Open);

                ArrayList list = serializer.Deserialize(fs) as ArrayList;
                foreach (FileData o in list)
                {
                    this.VideoListBox.Items.Add(o);
                }
            }

            //AUDIO
            filename = Application.StartupPath + "\\Audio.xml";
            if (File.Exists(filename) == true)
            {
                FileStream fs = new FileStream(filename, FileMode.Open);

                ArrayList list = serializer.Deserialize(fs) as ArrayList;
                foreach (FileData o in list)
                {
                    this.AudioListBox.Items.Add(o);
                }
            }
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            FileData FD = new FileData();
            if (player.playState == WMPPlayState.wmppsPaused)
            {
                player.Ctlcontrols.play();
            }
            else
            {
                try
                {
                    if (FileTabs.SelectedTab == AudioPage)
                    {
                        player.Visible = true;
                        FD = (FileData)AudioListBox.SelectedItem;
                        player.URL = FD.GetFilePath();
                        player.Ctlcontrols.play();
                    }
                    else if (FileTabs.SelectedTab == VideoPage)
                    {
                        movieFlag = true;
                        player.Visible = true;
                        FD = (FileData)VideoListBox.SelectedItem;
                        player.URL = FD.GetFilePath();
                        player.Ctlcontrols.play();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("No File Selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void PauseButton_Click(object sender, EventArgs e)
        {
            if (player.playState == WMPPlayState.wmppsPaused)
                player.Ctlcontrols.play();
            else
                player.Ctlcontrols.pause();

            if (movieFlag == true)
                movieFlag = false;
        }

        private void FastForwardButton_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.currentPosition += 10;
        }

        private void RewindButton_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.currentPosition -= 10;
        }

        private void TransferButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (chosenIP != "" && chosenPort != "" && chosenPort != null && chosenIP != null)
                {
                    Socket s1 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    String szIPSelected = chosenIP;
                    String szPort = chosenPort;
                    int alPort = System.Convert.ToInt16(szPort, 10);
                    System.Net.IPAddress remoteIPAddress = System.Net.IPAddress.Parse(szIPSelected);
                    System.Net.IPEndPoint remoteEndPoint = new System.Net.IPEndPoint(remoteIPAddress, alPort);
                    s1.Connect(remoteEndPoint);

                    FileData FD = new FileData();
                    if (FileTabs.SelectedTab == AudioPage)
                        FD = (FileData)AudioListBox.SelectedItem;
                    else if (FileTabs.SelectedTab == VideoPage)
                        FD = (FileData)VideoListBox.SelectedItem;
                    else if (FileTabs.SelectedTab == PicturePage)
                        FD = (FileData)PictureListBox.SelectedItem;

                    string fileName = FD.GetFileName() + "." + FD.GetFileExtension();
                    string filePath = FD.GetFileDirPath() + "\\";
                    byte[] fileNameByte = Encoding.ASCII.GetBytes(fileName);

                    byte[] fileData = File.ReadAllBytes(filePath + fileName);
                    byte[] clientData = new byte[4 + fileNameByte.Length + fileData.Length];
                    byte[] fileNameLen = BitConverter.GetBytes(fileNameByte.Length);

                    fileNameLen.CopyTo(clientData, 0);
                    fileNameByte.CopyTo(clientData, 4);
                    fileData.CopyTo(clientData, 4 + fileNameByte.Length);

                    byte[] clientDataLen = BitConverter.GetBytes(clientData.Length);

                    long bytesToSend = clientData.Length;
                    long bytesSent = 0;
                    byte[] buffer = new byte[1024];
                   
                    TransferProgBar.Minimum = 0;
                    TransferProgBar.Maximum = 100;
                    TransferProgBar.Value = 0;

                    //Send size packet
                    s1.Send(clientDataLen, clientDataLen.Length, SocketFlags.None);
                    
                    //Loop through packets
                    while(bytesSent < bytesToSend)
                    {
                        int i;
                        for (i = 0; i < buffer.Length; i++)
                        {
                            if (bytesSent + i < clientData.Length)
                                buffer[i] = clientData[bytesSent + i];
                            else
                                break;
                        }

                        bytesSent += s1.Send(buffer, i, SocketFlags.None);

                        double percentSent = (100.00 / bytesToSend) * bytesSent;
                        TransferProgBar.Value = (int)Math.Floor(percentSent);
                        progressLabel.Text = bytesSent + "/" + bytesToSend + " bytes sent (" + (int)Math.Floor(percentSent) + "%)";
                        Application.DoEvents();
                    }
                    TransferProgBar.Value = 0;
                    progressLabel.Text = "Select a file to transfer";
                    Application.DoEvents();
                    s1.Close();
                }
                else
                    MessageBox.Show("No Data Entered for IP Address and/or Port Number. Please Check The Settings From The File Menu.", "Error. Missing Info.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

    }
}