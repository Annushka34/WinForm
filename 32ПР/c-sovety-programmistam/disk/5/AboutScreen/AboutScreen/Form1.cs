using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AboutScreen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void butScreenRes_Click(object sender, EventArgs e)
        {
            // Определяем размеры экрана
            textBox1.Text = Screen.PrimaryScreen.Bounds.Width.ToString() + 
                "x" + Screen.PrimaryScreen.Bounds.Height.ToString();
        }

        private void butWorkArea_Click(object sender, EventArgs e)
        {
            // Определся рабочую область экрана
            textBox1.Text = Screen.GetWorkingArea(this).Width.ToString() + 
                "x" + Screen.GetWorkingArea(this).Height.ToString();
        }
    }
}