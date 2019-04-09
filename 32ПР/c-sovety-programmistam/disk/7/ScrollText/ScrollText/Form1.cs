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

        Single y_vert;
        Single x_horiz;

        Graphics g;
        Font f;
        string scrollText = "C#.Народные советы";

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (rbHoriz.Checked)
            {
                g.Clear(this.BackColor);
                g.DrawString(scrollText, f, Brushes.Black, x_horiz, y_vert);
                if (x_horiz <= -100)
                {
                    x_horiz = this.Width;
                }
                else
                {
                    x_horiz -= 5;
                }
            }
            else
            {
                g.Clear(this.BackColor);
                g.DrawString(scrollText, f, Brushes.Black, x_horiz, y_vert);
                if (y_vert <= (0 - 10))
                {
                    y_vert = this.Height;
                }
                else
                {
                    y_vert -= 5;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            y_vert = this.Height;
            x_horiz = this.Width - 300;

            timer1.Interval = 100;
            timer1.Start();
            f = new Font("Tahoma", 14, FontStyle.Bold, GraphicsUnit.Point);
        }
    }
}