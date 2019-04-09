using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.IO;

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
            String[] arguments = Environment.GetCommandLineArgs();
            textBox1.Text = arguments[1];
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Environment.GetCommandLineArgs().Length > 1)
            {   // ���� ���� �������� ��������� ������
                if (Environment.GetCommandLineArgs()[1] == "csharp")
                { // ���� ������ �������� ������������ �� csharp
                    this.Text = "������������������ ������������";
                }
                else
                {
                    MessageBox.Show("� ��� ��� ���� ��� ������� ���������");
                    this.Close();
                }
            }
            else
            {
                // ��������� ������ ���������
                MessageBox.Show("� ��� ��� ���� ��� ������� ���������");
                this.Close();
            }     
        }
    }
}
 
