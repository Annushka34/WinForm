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

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Старт")
            {
                timer1.Enabled = true;
                button1.Text = "Стоп";
            }
            else
            {
                timer1.Enabled = false;
                button1.Text = "Старт";
            }
        }

        public static int counter = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            string typingText = "C#.Народные советы";
            
            this.Text = typingText.Substring(0,counter);
            counter++;

            if (counter > typingText.Length)
                counter = 0;
        }

        private void butScroll_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;
        }

        private string scrollText = "C#.Народные советы    ";

        private void timer2_Tick(object sender, EventArgs e)
        {
            scrollText = scrollText.Substring(1,
                    (scrollText.Length - 1)) + scrollText.Substring(0, 1);
            this.Text = scrollText;
        }


    }
}