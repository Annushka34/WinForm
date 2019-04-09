using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_Form
{
    public partial class Form1 : Form
    {
        bool isClicked = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            isClicked = !isClicked;
            btnPressMe.BackColor = isClicked ? Color.Azure : Color.Red;
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            btnPressMe.Visible = true;
            Random r = new Random();
            btnPressMe.Location = new Point(r.Next(0, this.Width - 100), r.Next(0, this.Height - 50));
            DialogResult res =  MessageBox.Show("You click button", "BOX", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            switch(res)
            {
                case DialogResult.Yes:
                    lblMsgBox.Text = "You press OK";
                    break;
                case DialogResult.Cancel:
                    lblMsgBox.Text = "You press Cancel";
                    break;
                case DialogResult.No:
                    lblMsgBox.Text = "You press NO";
                    break;
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Point p = new Point(btnPressMe.Location.X - 10, btnPressMe.Location.Y - 10);
            Rectangle rectangle = new Rectangle(p, new Size(btnPressMe.Width + 20, btnPressMe.Height + 20));
            if ( rectangle.Contains(new Point(e.X, e.Y)) )
            {
                MessageBox.Show("You enter this area");
            }

        }
    }
}
