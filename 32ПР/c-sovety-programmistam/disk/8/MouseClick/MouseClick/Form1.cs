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

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            // ¬ыводим координаты мыши в заголовке формы
            this.Text = "MouseClick: " +  e.Button.ToString() +
                        " " + e.Location.ToString();
        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // ¬ыводим координаты мыши в заголовке формы
            this.Text = "MouseDoubleClick: " + e.Button.ToString() +
                        " " + e.Location.ToString();
        }
    }
}