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
            if (e.KeyValue == 27)
            {
                this.Close();
            }
        }

    }
}
