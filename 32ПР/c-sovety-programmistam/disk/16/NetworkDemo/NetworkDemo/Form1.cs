using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Collections;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        [DllImport("sensapi.dll")]
        private extern static bool IsNetworkAlive(ref int flags);

        private static int NETWORK_ALIVE_LAN = 0x00000001;
        private static int NETWORK_ALIVE_WAN = 0x00000002;
        

        public Form1()
        {
            InitializeComponent();
        }

        public static bool IsLanAlive()
        {
            return IsNetworkAlive(ref NETWORK_ALIVE_LAN);
        }
        public static bool IsWanAlive()
        {
            return IsNetworkAlive(ref NETWORK_ALIVE_WAN);
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            this.Text = IsLanAlive().ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Text = IsWanAlive().ToString();
        }
    }
}