using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_Lesson_ComboBox_FileDialog_Child
{
    public partial class Form1 : Form
    {
        int y = 20;
        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(linkLabel1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listPersons.Items.Add(textBox1.Text);
        }

        private void listPersons_SelectedIndexChanged(object sender, EventArgs e)
        {
            // label1.Text = listPersons.SelectedItem.ToString();
            //Label l2 = new Label();
            //l2.Text = "dhshdjhdskjfhksd";
            //l2.Location = new Point(100, 200);
            //lblSelected.Controls.Add(l2);
            foreach (var item in listPersons.SelectedItems)
            {
                Label l = new Label();
                l.Location = new Point(50, y);  
                l.Text = item.ToString();
                lblSelected.Controls.Add(l);
                y += 20;
            }
           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
                (sender as CheckBox).BackColor = Color.AliceBlue;
            else
                (sender as CheckBox).BackColor = Color.FromArgb(255,255,128);
        }
    }
}
