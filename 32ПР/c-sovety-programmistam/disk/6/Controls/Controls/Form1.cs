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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            const int MAX_LENGTH = 5;

            if (textBox1.Text.Length == MAX_LENGTH)
                // переводим фокус на следующий элемент управления
                SelectNextControl(textBox1, true, true, false, false);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Выводим кнопку button2 на передний край
            this.Controls.SetChildIndex(button2, 0);
        }
    }
}