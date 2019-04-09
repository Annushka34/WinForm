using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using Microsoft.VisualBasic;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void butInsert_Click(object sender, EventArgs e)
        {
            string partBookTitle = "C#.советы";
            string insertText = "Народные ";
            string bookTitle = partBookTitle.Insert(3, insertText);
            MessageBox.Show(bookTitle);
        }

        private void butRemove_Click(object sender, EventArgs e)
        {
            string bookTitle = "C#.Народные советы";
            // Удаляем подстроку с третьей позиции
            bookTitle = bookTitle.Remove(2);
            MessageBox.Show(bookTitle);
        }

        private void butSubstring_Click(object sender, EventArgs e)
        {
            string bookTitle = "C#.Народные советы";
            // Извлекаем подстроку с шестой позиции с размером в три символа
            bookTitle = bookTitle.Substring(5, 3);
            MessageBox.Show(bookTitle);
        }

        private void butIndexOf_Click(object sender, EventArgs e)
        {
            string str1 = "око";
            string str2 = "Царь-колокол";
            int i = str2.IndexOf(str1);
            // Проверяем, входит ли строка око в слово Царь-колокол
            if (i >= 0) MessageBox.Show(str1 + " входит в строку " + str2);
        }

        private void butConvert_Click(object sender, EventArgs e)
        {
            string tankman = "4";
            string dog = "1";
            textBox1.Text = tankman + dog; // получим 41
            int all = int.Parse(tankman) + int.Parse(dog);
            textBox1.Text += Environment.NewLine + all.ToString();  // получим 5
        }

        private void butSpecial_Click(object sender, EventArgs e)
        {
            int charCode = 169;
            char specialChar = Convert.ToChar(charCode);
            textBox1.Text = specialChar.ToString();

            // Unicode-код для торговой марки
            charCode = 0x00AE;
            specialChar = Convert.ToChar(charCode);
            textBox1.Text += specialChar.ToString();
        }

        private void butRepeat_Click(object sender, EventArgs e)
        {
            // Создаем строку из 5 звездочек
            System.String FiveStars = new System.String('*', 5);
            textBox1.Text = FiveStars;
        }

        private void butColorName_Click(object sender, EventArgs e)
        {
            // Задаем цвет
            Color clr = Color.Blue;
            // Получим имя выбранного цвета
            textBox1.Text = (TypeDescriptor.GetConverter(clr).ConvertToString(clr));

            // Обратная задача. Конвертируем название цвета Green в объект Color
            clr = (Color)TypeDescriptor.GetConverter(typeof(Color)).ConvertFromString("Green");
            // Закрашиваем форму в выбранный цвет
            this.BackColor = clr;

        }

        public void SayHello(string name)
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentNullException("name");
            MessageBox.Show(string.Concat("Hello, ", name));
        }

       
        private void butReverseVB_Click(object sender, EventArgs e)
        {
            string myString = textBox1.Text;
            // Используем встроенную функцию Visual Basic
            textBox1.Text = Strings.StrReverse(myString);
        }

        public static string ReverseString(string str)
        {
            // Проверка на существование строки.
            if (string.IsNullOrEmpty(str))
            {
                return str;
            }

            // Создадим объект StringBuilder с нужной длиной.
            StringBuilder revStr = new StringBuilder(str.Length);
            // Перебираем в цикле все символы
            // и присоединяем каждый символ к StringBuilder
            for (int count = str.Length - 1; count > -1; count--)
            {
                revStr.Append(str[count]);
            }
            // Возвращаем перевернутую строку
            return revStr.ToString();
        }

        private void butReverseCS_Click(object sender, EventArgs e)
        {
            textBox1.Text = ReverseString(textBox1.Text);

                        
        }

        private void butFormatStr_Click(object sender, EventArgs e)
        {
            string AutoName;
            AutoName = "BMW";
            textBox1.Text = 
                String.Format("Стоимость {0} равна {1:0.0;c}", AutoName, 12000);
        }
       
    }
}