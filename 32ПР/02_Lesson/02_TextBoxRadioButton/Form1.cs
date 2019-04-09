using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_TextBoxRadioButton
{
    public partial class Form1 : Form
    {
        Label l = new Label();
        Point pStart;
        Point pEnd;
        public Form1()
        {
            InitializeComponent();
            this.Controls.Add(l);
        }

        private void chBMale_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            if(checkBox.Checked)
            {
                txt1.Text += checkBox.Text;
            }
            if(!checkBox.Checked)
            {
                txt1.Text = "";
            }
        }

        private void chBBoth_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            {
                chBMale.Checked = true;
                chBFemale.Checked = true;
            }
            else
            {
                chBMale.Checked = false;
                chBFemale.Checked = false;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as RadioButton).Checked)
            {
                l.Text = (sender as RadioButton).Text;
                
                l.Location = new Point(100, 300);

            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            pStart = e.Location;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            pEnd = e.Location;
            Button b = new Button();
            //TODO: add check smoller point
            b.Size = new Size( pEnd.X - pStart.X, pEnd.Y - pStart.Y);
            b.Location = pStart;
            b.BackColor = Color.FromArgb(255, 255, 253);
            b.Text = "BUTTON";
            b.Click += B_Click;
            this.Controls.Add(b);
        }

        private void B_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(sender as Button);
            if ( (e as MouseEventArgs).Button == MouseButtons.Left)
            {

            }
        }
    }
}
