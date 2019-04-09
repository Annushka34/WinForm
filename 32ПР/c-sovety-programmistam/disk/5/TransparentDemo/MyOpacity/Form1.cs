using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyOpacity
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(100, 255, 200, 100);
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            button1.Scale(0.9f);
            if (button1.Size.Height <= 0)
            {
                button1.Enabled = false;
                timer1.Stop();
            }
            this.Opacity -= 0.05;
            if (this.Opacity <= 0)
            {
                this.Close();
            }
        }
    }
}
