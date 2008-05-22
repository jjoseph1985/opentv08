using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.DirectoryServices;
using System.IO;

namespace WindowsApplication1
{
    public partial class PicturePreviewForm : Form
    {
        public PicturePreviewForm()
        {
            InitializeComponent();

            this.KeyDown += new KeyEventHandler(PicturePreviewForm_KeyDown);
        }

        void PicturePreviewForm_KeyDown(object sender, KeyEventArgs e)
        {
            Form1 form = new Form1();
            FileData FD = new FileData();
            if (e.KeyValue == 27)
            {
                this.Close();
            }
            else if (e.KeyCode == Keys.Left)
            {
                int currIndex = form.PictureListBox.SelectedIndex;
                MessageBox.Show("left arrow clicked");
                currIndex = currIndex - 1; ;
                MessageBox.Show("left arrow clicked" + currIndex);
                //form.PictureListBox.SetSelected(1, true);
                //FD = (FileData)form.PictureListBox.SelectedItem;
                MessageBox.Show("left arrow clicked");
                //FullScreenPictureBox.ImageLocation = FD.GetFilePath();
            }
            else if (e.KeyCode == Keys.Right)
            {
                //form.PictureListBox.SelectedIndex += 1;
                //FD = (FileData)form.PictureListBox.SelectedItem;
                // FullScreenPictureBox.ImageLocation = FD.GetFilePath();
            }
            else
                e.Handled = true;

        }

    }
}
