using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

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
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(new CultureInfo("ru-RU"));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            InputLanguage myDefaultLanguage = InputLanguage.DefaultInputLanguage;
            InputLanguage myCurrentLanguage = InputLanguage.CurrentInputLanguage;
            textBox1.Text = "������� ���� �����: " +
                myCurrentLanguage.Culture.EnglishName + "\r\n";
            textBox1.Text += "���� ����� �� ���������: " +
                myDefaultLanguage.Culture.EnglishName + "\r\n";

            // ������� ������� ���� �����
            InputLanguage myCurrentLanguage2 = InputLanguage.CurrentInputLanguage;
            textBox1.Text += "����� ������� ���� �����: " +
                myCurrentLanguage2.Culture.EnglishName;

        }
    }
}