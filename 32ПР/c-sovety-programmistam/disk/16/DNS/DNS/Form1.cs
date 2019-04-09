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

        private void butGetDNS_Click(object sender, EventArgs e)
        {
            System.Net.IPHostEntry host;

            host = System.Net.Dns.GetHostEntry("yandex.ru");

            foreach (System.Net.IPAddress ip in host.AddressList)
            {
                MessageBox.Show(ip.ToString());
            }
        }



        private void butGetNETBIOS_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Environment.MachineName);
        }

        private void butGetLocalIP_Click_1(object sender, EventArgs e)
        {
            string strIP = "";
            System.Net.IPHostEntry host;
            host = System.Net.Dns.GetHostEntry(strIP);

            foreach (System.Net.IPAddress ip in host.AddressList)
            {
                MessageBox.Show(ip.ToString());
            }
        }
    }
}