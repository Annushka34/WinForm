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
            // form1 �������� ����������� ������ Form1 � Form2.cs, ������������ ��� public
            form2.form1 = this;
            // ���������� ����� Form2
            form2.ShowDialog();
        }
    }
}