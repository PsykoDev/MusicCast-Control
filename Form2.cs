using MusicCast_Control.Config;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicCast_Control
{
    public partial class Form2 : Form
    {
        ConfigBuild ConfigBuild = new();
        string NewIp;
        public Form2()
        {
            InitializeComponent();
            this.FormClosing += Form2_FormClosing;
            textBox1.PlaceholderText = "IP Ex: 192.168.1.0";
            TopMost = true;
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1.AddFormClosed = true;
        }

        private async void AddButton_Click(object sender, EventArgs e)
        {
            await ConfigBuild.updateConfig(textBox1.Text);
            Form1.AddFormClosed = true;
            DialogResult result = MessageBox.Show("Please restart application ", "New IP", MessageBoxButtons.YesNo);
            switch (result)
            {
                case DialogResult.Yes:
                    {
                        Application.Restart();
                        break;
                    }
                case DialogResult.No:
                    {
                        Close();
                        break;
                    }
            }
            
        }
    }
}
