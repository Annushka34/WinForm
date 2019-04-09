using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Security.Principal;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void butGetUserInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Environment.UserDomainName + @"\" +
               Environment.UserName);

        }

        private void butGetUserInfo2_Click(object sender, EventArgs e)
        {
            WindowsIdentity user = WindowsIdentity.GetCurrent();
            MessageBox.Show(user.Name.ToString());

        }
    }
}