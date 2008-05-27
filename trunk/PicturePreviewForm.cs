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
        ListBox lb = new ListBox(); 

        public PicturePreviewForm(ListBox tempLB)
        {
            InitializeComponent();
            lb = tempLB;
            this.KeyDown += new KeyEventHandler(PicturePreviewForm_KeyDown);
        }

        void PicturePreviewForm_KeyDown(object sender, KeyEventArgs e)
        {
            FileData FD = new FileData();
            if (e.KeyValue == 27)
            {
                this.Close();
            }
            else if (e.KeyCode == Keys.Left)
            {
                int currIndex = lb.SelectedIndex;
                lb.SetSelected(currIndex, false);
                if (currIndex == 0)
                    currIndex = lb.Items.Count - 1;
                else
                    currIndex = currIndex - 1; 
                lb.SetSelected(currIndex, true);
                FD = (FileData)lb.SelectedItem;
                FullScreenPictureBox.ImageLocation = FD.GetFilePath();
            }
            else if (e.KeyCode == Keys.Right)
            {
                int currIndex = lb.SelectedIndex;
                lb.SetSelected(currIndex, false);
                if (currIndex == lb.Items.Count - 1)
                    currIndex = 0;
                else
                    currIndex = currIndex + 1;
                lb.SetSelected(currIndex, true);
                FD = (FileData)lb.SelectedItem;
                FullScreenPictureBox.ImageLocation = FD.GetFilePath();
            }
            else
                e.Handled = true;

        }


    }
}
