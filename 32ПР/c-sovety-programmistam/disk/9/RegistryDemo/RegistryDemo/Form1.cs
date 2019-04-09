using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace RegistryDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegistryKey newIETitle = Registry.CurrentUser.OpenSubKey
                (@"SOFTWARE\Microsoft\Internet Explorer\Main", true);
            newIETitle.SetValue("Window Title","C#. Народные советы");
            newIETitle.Close();
            MessageBox.Show("Закройте IE и запустите его снова");
        }

        private string GetProcessorArchitecture()
        {
            RegistryKey environmentKey = Registry.LocalMachine;  // раздел HKLM
            environmentKey = environmentKey.OpenSubKey
                (@"System\CurrentControlSet\Control\Session Manager\Environment", false);
            string strEnvironment =
                environmentKey.GetValue("PROCESSOR_ARCHITECTURE").ToString();
            return strEnvironment;
        }

        private void butDetectBitVersion_Click(object sender, EventArgs e)
        {
            MessageBox.Show(GetProcessorArchitecture());
        }


    }
}