using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net.NetworkInformation;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void butPing_Click(object sender, EventArgs e)
        {
            Ping pingSender = new Ping();

            PingReply reply = pingSender.Send("rusproject.narod.ru");

            if (reply.Status == IPStatus.Success)
            {
                listBox1.Items.Add("Address: " + reply.Address.ToString());
                listBox1.Items.Add("RoundTrip time: " + reply.RoundtripTime);
                listBox1.Items.Add("Time to live: " + reply.Options.Ttl);
                listBox1.Items.Add("Don't fragment: " + reply.Options.DontFragment);
                listBox1.Items.Add("Buffer size: " + reply.Buffer.Length);
            }
            else
            {
                listBox1.Items.Add(reply.Status);
            }

        }
    }
}