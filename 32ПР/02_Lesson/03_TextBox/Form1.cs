using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_TextBox
{
    public partial class Form1 : Form
    {
        string text = "";
        public Form1()
        {
            InitializeComponent();
          //  textBox1.Text = "hello";
          //  timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // size = new SizeF(size.Height - 1, size.Width - 1);
            //   button1.Scale(0.95f);
            // if (button1.Height <= 40)
            //  {
            //  timer1.Stop();
            //  this.Controls.Remove(button1);
            //  }
             this.Scale(0.9f);

          
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Scale(0.9f);
            MessageBox.Show("Closed");

            timer1.Stop();

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Closing");
            timer1.Start();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (text.Length < txtWrite.Text.Length)
            {
            if (pBar1.Value + 1 <= pBar1.Maximum)
                pBar1.Value += 1;
            }
            else if (text.Length > txtWrite.Text.Length)
            {
                if (pBar1.Value - 1 > pBar1.Minimum)
                    pBar1.Value -= 1;
            }
            txtView.Text = txtWrite.Text;
            text = txtWrite.Text;
        }

        private void txtWrite_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                listBox1.Items.Add(txtWrite.Text);
                txtWrite.Text = "";
            }
        }

        private void txtWrite_MouseUp(object sender, MouseEventArgs e)
        {
          //  MessageBox.Show(txtWrite.SelectedText);            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Font font = new Font(FontFamily.GenericMonospace, 20, FontStyle.Bold);
            txtWrite.Font = font;
            //txtWrite.
           // (txtWrite.SelectedText)
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(trackBar1.Value, trackBar1.Value, trackBar1.Value);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSelected.Text = listBox1.SelectedItem.ToString();
        }
    }
}
