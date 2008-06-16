using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class IPConfigForm : Form
    {
        Form1 z;
        public IPConfigForm(Form1 y)
        {
            InitializeComponent();
            z = y;
            ipTextBox.Text = z.chosenIP;
            portTextBox.Text = z.chosenPort;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            z.chosenIP = ipTextBox.Text;
            z.chosenPort = portTextBox.Text;

            TextWriter configFile = new StreamWriter(Application.StartupPath + "\\config.txt.");
            configFile.WriteLine(z.chosenIP);
            configFile.WriteLine(z.chosenPort);
            configFile.Close();

            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
