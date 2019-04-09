using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TransparentDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void butClose_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity -=  0.1;
            if (this.Opacity <= 0)
                this.Close();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            this.Opacity = (double)numericUpDown1.Value / 100;
        }

        //protected override void WndProc(ref Message m)
        //{
        //    const int WM_NCLBUTTONDOWN = 0x00A1;
        //    const int WM_NCMOUSEMOVE = 0x00A0;
        //    const int WM_ACTIVATEAPP = 0x001C;


        //    if (m.Msg == WM_NCLBUTTONDOWN)
        //    {
        //        this.Opacity = 0.5;
        //    }

        //    if (m.Msg == WM_NCMOUSEMOVE)
        //    {
        //        this.Opacity = 1.0;
        //    }

        //    if (m.Msg == WM_ACTIVATEAPP)
        //    {
        //        if (m.WParam.ToInt32() != 0)
        //        {
        //            this.Opacity = 1.0;
        //        }
        //        else
        //        {
        //            this.Opacity = 0.5;
        //        }
        //    }

        //    base.WndProc(ref m);
        //}


    }
}