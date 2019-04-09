using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MenuDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (contextMenuStrip1.SourceControl == label1)
            {
                cmenuOpen.Text = "Label";
            }
            else
                cmenuOpen.Text = "Button";
        }

        private void timerMenu_Tick(object sender, EventArgs e)
        {
            SendKeys.Send("{ESC}");
            timerMenu.Stop(); 
        }

        private void contextMenuStrip1_Opened(object sender, EventArgs e)
        {
            //set interval to 5 seconds 
            timerMenu.Interval = 5000;
            timerMenu.Start();
        } 

    }
}