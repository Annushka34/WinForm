using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(
                ((System.Byte)(255)),
                ((System.Byte)(100)),
                ((System.Byte)(128)));
            this.TransparencyKey = System.Drawing.Color.FromArgb(
                ((System.Byte)(255)),
                ((System.Byte)(100)), 
                ((System.Byte)(128)));
        }

    }
}