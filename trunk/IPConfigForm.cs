using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class IPConfigForm : Form
    {
        Form1 y = new Form1();
        public IPConfigForm(Form1 y)
        {
            InitializeComponent();

            this.y = y;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            y.chosenIP = ipTextBox.Text;
            y.chosenPort = portTextBox.Text;
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
