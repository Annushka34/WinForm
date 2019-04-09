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
            Form2 form2 = new Form2();
            // form1 является экземпляром класса Form1 в Form2.cs, определенный как public
            form2.form1 = this;
            // Показываем форму Form2
            form2.ShowDialog();
        }
    }
}