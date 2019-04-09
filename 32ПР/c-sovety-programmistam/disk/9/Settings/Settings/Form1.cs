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

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Properties.Settings.Default.BackgroundColor;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.BackgroundColor = Color.Red;
            Properties.Settings.Default.Save();
        }
    }
}