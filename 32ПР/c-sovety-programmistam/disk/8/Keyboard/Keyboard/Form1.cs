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
            textBox1.Text = "Текущий язык ввода: " +
                myCurrentLanguage.Culture.EnglishName + "\r\n";
            textBox1.Text += "Язык ввода по умолчанию: " +
                myDefaultLanguage.Culture.EnglishName + "\r\n";

            // Выводим текущия язык ввода
            InputLanguage myCurrentLanguage2 = InputLanguage.CurrentInputLanguage;
            textBox1.Text += "Новый текущий язык ввода: " +
                myCurrentLanguage2.Culture.EnglishName;

        }
    }
}