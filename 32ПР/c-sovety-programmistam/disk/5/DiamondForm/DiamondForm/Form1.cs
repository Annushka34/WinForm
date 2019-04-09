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
            // Задаем цвет прозрачности
            this.TransparencyKey = Color.Gold;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.Gold);

            e.Graphics.FillPolygon(Brushes.Aquamarine, new PointF[] {
                new Point(this.ClientRectangle.Width / 2, 0), 
                new Point(this.ClientRectangle.Width, this.ClientRectangle.Height / 2), 
                new Point(this.ClientRectangle.Width / 2, this.ClientRectangle.Height), 
                new Point(0, this.ClientRectangle.Height / 2)});

            Font f = new Font(this.Font.Name, 20);
            e.Graphics.DrawString("C#.Народные советы",
                f, Brushes.Black, 20,
                (this.ClientRectangle.Height / 2) - (f.Height / 2));
        }

  

    }
}