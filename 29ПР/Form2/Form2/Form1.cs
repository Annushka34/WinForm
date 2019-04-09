using Form2.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form2
{
    public partial class Form1 : Form
    {
        int Y = 20;
        public Form1()
        {
            InitializeComponent();
            this.MouseMove += Form1_MouseMove1;
            btnStop.Enabled = false;
        }

        private void Form1_MouseMove1(object sender, MouseEventArgs e)
        {
            lbl1.Text = "moved";
            Point p = btn1.Location;
            Rectangle rec = new Rectangle(p, btn1.Size);
            Point XY = new Point(e.X, e.Y);
            if(rec.Contains(XY))
            {
                btn1.Text = "You catch me";
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = e.X + " " + e.Y;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            btn1.Text = "Clicked";
            Button b = new Button();
            b.Location = new Point(10, Y);
            b.Text = "BTN";
            Y += 25;
            b.Click += B_Click;
            pnl1.Controls.Add(b);
        }

        private void B_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Enabled = false;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Interval = 500;
            btnStart.Enabled = false;
            btnStop.Enabled = true;
            timer1.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = true;
            btnStop.Enabled = false;
            timer1.Stop();
        }

        int counter = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblCount.Text = (counter++).ToString();
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            Label l = new Label();
            string img = Resources.img1;
            Image image = Image.FromFile(img);
            l.Size = image.Size;
            l.Image = image;
            pnl2.Controls.Add(l);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
