using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyHoles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();


            Rectangle rec = new Rectangle(10, 10, 50, 50);
            Graphics g;
            g = this.CreateGraphics();

            Color c1 = Color.FromArgb((System.Byte)100, (System.Byte)100, (System.Byte)100);

            SolidBrush br = new SolidBrush(c1);
            g.FillEllipse(br, rec);
            Button b = new Button();
            b.Location = rec.Location;
            b.Size = rec.Size;
            b.FlatAppearance.BorderSize = 0;
            this.Controls.Add(b);
            


            button2.BackColor = Color.FromArgb(255, 100, 100);
            label1.BackColor = Color.FromArgb(255, 100, 100);
            this.TransparencyKey = Color.FromArgb((System.Byte)255, (System.Byte)100, (System.Byte)100);

        }
    }
}
