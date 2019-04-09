using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OperatingSystem os = Environment.OSVersion;
            listBox1.Items.Add(os.Version);
            listBox1.Items.Add(os.Platform);
            listBox1.Items.Add(os.ServicePack);
            listBox1.Items.Add(os.VersionString);
        }

        private void CheckOSVersion()
        {
            OperatingSystem os = Environment.OSVersion;
            Version version = os.Version;
            if ((version.Major == 5) && (version.Minor == 1) || version.Major >= 6)
            {
                MessageBox.Show("Программа может запускаться в вашей операционной системе");
            }
            else
            {
                MessageBox.Show
                    ("Эта версия операционной системы не поддерживается." + 
                    "\r\n Используйте Windows XP или Windows Vista");
             }
        }

        private void butCheckOS_Click(object sender, EventArgs e)
        {
            CheckOSVersion();
        }
    }
}