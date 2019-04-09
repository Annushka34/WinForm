using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgressBar
{
    public partial class Form1 : Form
    {
        int counter = 0;
        public Form1()
        {
            InitializeComponent();
            progressBar1.Step = 1;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;

            progressBar2.Value = 20;
            progressBar2.Step = 1;
            progressBar2.Maximum = 20;
           // progressBar2.Style = ProgressBarStyle.Marquee;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            checkedListBox1.Items.AddRange(new string[] { "red", "blue", "green" });
           
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = checkedListBox1.SelectedItem.ToString();
        }

        private void checkedListBox1_Click(object sender, EventArgs e)
        {
            label2.Text = checkedListBox1.CheckedItems.Count.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(counter.ToString());
            counter++;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label3.Text = comboBox1.SelectedItem.ToString();
        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Add(toolStripTextBox1.Text);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if(checkedListBox1.SelectedIndex != -1)
            //checkedListBox1.Items.RemoveAt(checkedListBox1.SelectedIndex);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if(numericUpDown1.Value==progressBar1.Maximum)
            {
                numericUpDown1.Value = 0;
            }
            progressBar1.Value = (int)numericUpDown1.Value;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar2.Value >0)// progressBar2.Maximum)
            progressBar2.Value -= progressBar2.Step;
            else    timer1.Stop();
        }

        private void START_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
