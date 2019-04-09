using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Form1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyForm f = new MyForm("My first window");           
            Application.Run(f);            
        }
    }
    class MyForm : Form
    {
        Label l;
        int Y = 70;
        public MyForm(string name)
        { 
            Text = name;
            Width = 600;
            Height = 600;
            this.Location = new Point(10, 20);

            Button b = new Button();
            b.Location = new Point(20, 20);
            b.Text = "Click me";
            this.Controls.Add(b);

            l = new Label();
            l.Location = new Point(20, 50);
            this.Controls.Add(l);

            b.Click += B_Click;
        }

        private void B_Click(object sender, EventArgs e)
        {
            l.Text = "You press button ";
            Button b = new Button();
            b.Location = new Point(20, Y);
            Y += 25;
            b.Text = "Click me";
            this.Controls.Add(b);
        }
    }
}
