using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace _01_ConsoleForm
{
    class Program
    {
        static void Main(string[] args)
        {
            // Application.Run(new MyForm());
            MyForm form = new MyForm("Hello");
            form.ShowDialog();
           // form.Show();
        }
    }

    class MyForm : Form
    {
        public MyForm(string text)
        {
            this.Text = text;
            this.Height = 300;
            this.Width = 600;
            this.Location = new Point(-20, 0);
            this.Click += MyForm_Click;
            this.MouseMove += MyForm_MouseMove;
        }

        private void MyForm_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = e.X + ":" + e.Y;
        }

        private void MyForm_Click(object sender, EventArgs e)
        {
            //Point locationForm = (sender as Form).Location;
            //this.Text = locationForm.X + ":" + locationForm.Y;
            //this.Location = new Point(120, 60);
            Button b = new Button();
            b.Text = "PRESS ME!";
            Random r = new Random();
            b.Location = new Point(r.Next(0,this.Width), r.Next(0, this.Height));
            this.Controls.Add(b);
            b.Click += B_Click;
        }

        private void B_Click(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.AliceBlue;
         
        }
    }
}
