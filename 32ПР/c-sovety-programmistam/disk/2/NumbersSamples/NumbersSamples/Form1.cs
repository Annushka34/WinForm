using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void butToString_Click(object sender, EventArgs e)
        {
            int parrots = 38;
            textBox1.Text = parrots.ToString("X8");
        }

        private void butBin_Click(object sender, EventArgs e)
        {
            int myvalue = 4;
            textBox1.Text = Convert.ToString(myvalue, 2);  // возвратит 100

        }

        private void butConvert_Click(object sender, EventArgs e)
        {
            int myValue = 365;
            // Преобразуем в восьмеричное значение
            MessageBox.Show(Convert.ToString(myValue, 8));

            // Преобразуем в шестнадцатеричное значение
            MessageBox.Show(Convert.ToString(myValue, 16));
        }

        private void butGuid_Click(object sender, EventArgs e)
        {
            Guid newGuid = Guid.NewGuid();
            // Уникальный идентификатор с дефисами
            //MessageBox.Show(newGuid.ToString());

            // Уникальный идентификатор без дефисов
            textBox1.Text = newGuid.ToString("N");

        }

        private void butIsNumericVB_Click(object sender, EventArgs e)
        {
            // введите в текстовое поле любое число или слово
            string numstring = textBox1.Text;
            bool bResult1;
            bResult1 = Information.IsNumeric(numstring);
            MessageBox.Show("Является ли " + numstring + " числом: " + bResult1);             
        }

        // Пишем собственную функцию IsNumeric на чистом C#
        static bool IsNumeric(object Expression)
        {
            // Возвращаемое значение
            bool isNum;

            // Переменная, используемая в качестве параметра
            // в методе TryParse
            double retNum;

            // Метод TryParse конвертирует строку в заданный стиль
            // и локальный формат.
            isNum = Double.TryParse(Convert.ToString(Expression), 
                System.Globalization.NumberStyles.Any, 
                System.Globalization.NumberFormatInfo.InvariantInfo, out retNum);

            return isNum;
        }

        private void butIsNumericCS_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Является ли " + textBox1.Text + " числом: " + IsNumeric(textBox1.Text));
        }		
    }
}