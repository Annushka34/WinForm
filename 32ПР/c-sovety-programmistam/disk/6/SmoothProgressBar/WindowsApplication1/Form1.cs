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

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.smoothProgressBar1.Value > 0)
            {
                this.smoothProgressBar1.Value--;
                this.smoothProgressBar2.Value++;
            }
            else
            {
                this.timer1.Enabled = false;
            } 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.smoothProgressBar1.Value = 100;
            this.smoothProgressBar2.Value = 0;

            this.timer1.Interval = 1;
            this.timer1.Enabled = true; 

           
        }
    }
}