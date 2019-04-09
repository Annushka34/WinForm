using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_Lesson
{
    public partial class Form1 : Form
    {
        int sec = 0;
        public Form1()
        {
            InitializeComponent();
            monthCalendar1.AnnuallyBoldedDates = new DateTime[]
            {
                new DateTime(2019,4,7),
                new DateTime(2019,4,21)
            };
           // timer2.Start();
        }

        private void btnMy_Click(object sender, EventArgs e)
        {
            btnMy.Text = "!!!!Vaw";
            timer1.Start();

          //  Thread.Sleep(5000);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            btnMy.Text = "Catch me";
            int x = 5;
            int y = 200;
            Random r = new Random();
          

            Button[] b = new Button[10];
            //{
            //    // new Button()
            //    //{
            //    //    Text = "New Button 2",
            //    //    Location = new Point(x+100, y),
            //    //    BackColor = Color.Blue
            //    //},
            //    //  new Button()
            //    //{
            //    //    Text = "New Button 3",
            //    //    Location = new Point(x+200, y),
            //    //     BackColor = Color.Blue
            //    //}
            //};
            for (int i = 0; i < b.Count(); i++)
            {
               b[i] = new Button()
                {
                    Text = r.Next(0, 100).ToString(),
                    Height = 50,
                    Width = 50,
                    BackColor = Color.Blue
                };
                b[i].Click += Item_Click;
                b[i].Location = new Point(x += 100, y);
            }
            this.Controls.AddRange(b);
            timer1.Stop();
        }

        private void Item_Click(object sender, EventArgs e)
        {
            Button clickedBtn = (sender as Button);
            clickedBtn.Enabled = false;
            clickedBtn.BackColor = Color.Gray;
            clickedBtn.Text = "OK";
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
            lblSec.Text = (++sec).ToString();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
           
            string text = (sender as Button).Text;
            switch(text)
            {
                case "START":
                    (sender as Button).Text = "PAUSE";
                    (sender as Button).BackColor = Color.Red;
                    timer2.Start();
                    break;
                case "PAUSE":
                    (sender as Button).Text = "START";
                    (sender as Button).BackColor = Color.Empty;
                    timer2.Stop();
                    break;
                case "RESET":
                    sec = 0;
                    break;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            lblDateSel.Text = dateTimePicker1.Value.ToLongDateString();
            numericUpDown1.Value = dateTimePicker1.Value.Day;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            lblSec.Text = numericUpDown1.Value.ToString();
            sec = (int)numericUpDown1.Value;
        }
    }
}
