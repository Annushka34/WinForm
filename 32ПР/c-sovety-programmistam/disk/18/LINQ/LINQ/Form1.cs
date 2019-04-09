using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LINQ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Linq1();
        }

        // В этом примере выводим на экран числа из заданного массива, 
        // чьи значения меньше или равны 8. 
        // The sample uses a query expression to create a new sequence of integers 
        //and then iterates over each element in the sequence, printing its value. 
        public void Linq1()
        {
            // Задаем массив чисел
            int[] numbers = { 12, 14, 21, 3, 9, 8, 6, 7, 2, 10, 1, 2, 3, 4 };

            // Выбираем из них числа, меньше чем 8
            var lowNums =
                from n in numbers
                where n <= 8
                select n;

            foreach (var x in lowNums)
            {
                // Выводим числа, подходящие нашему условию
                textBox1.Text += x.ToString() + " ";
            }
        }


        public void Linq2()
        {
            string[] digits = { "ноль", "один", "два", "три", "четыре", 
                        "пять", "шесть", "семь", "восемь", "девять" };

            var shortDigits = digits.Where((digit, index) => digit.Length < index);

            foreach (var d in shortDigits)
            {
                textBox1.Text += String.Format("Длина слова {0} меньше его значения.", d) +
                    Environment.NewLine;
            }
        }

        
        public void Linq3()
        {
            int[] numbers = { 1, 3, 5, 7, 9, 11, 13, 15 };

            var numsPlusOne =
                from n in numbers
                select n + 1;

            foreach (var i in numsPlusOne)
            {
                textBox1.Text += i + " ";
            }
        }


        //Пример выводит имя каждого числа массива, 
        //индексированного во втором массиве, который содержит имена.
        public void Linq4()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            string[] strings = { "ноль", "один", "два", "три", "четыре", 
                         "пять", "шесть", "семь", "восемь", "девять" };

            var textNums =
                from n in numbers
                select strings[n];

            foreach (var s in textNums)
            {
                textBox1.Text += s + Environment.NewLine;
            }
        }

        //Этот пример печатает строки из массива в верхнем и нижнем регистре. 
        //Данный пример демонстрирует использование анонимных типов в выбранном выражении. 
        //Анонимный тип имеет два поля - Upper и Lower, 
        //которые позволяет выводить строки в разных регистрах.
        public void Linq5()
        {
            string[] words = { "МарТыШка", "оСеЛ", "КОЗел", "мИшка" };

            var upperLowerWords =
                from w in words
                select new { Upper = w.ToUpper(), Lower = w.ToLower() };

            foreach (var ul in upperLowerWords)
            {
                textBox1.Text +=
                    String.Format("Верхний регистр: {0}, Нижний регистр: {1}", ul.Upper, ul.Lower) +
                    Environment.NewLine;
            }
        }

        //Оператор Take
        //Оператор Take возвращает количество элементов массива, начиная с первого.
        public void Linq6()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            // Берем первые три элемента массива
            var first3Numbers = numbers.Take(3);

            foreach (var n in first3Numbers)
            {
                textBox1.Text += n + Environment.NewLine;
            }
        }

        //Оператор TakeWhile
        //Оператор TakeWhile выполняет то же самое, что и Take, 
        //только выбор заканчивается, когда перестает, выполняется определенное условие.
        //В этом примере проходим через элементы массива, пока число меньше шести. 
        public void Linq7()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var firstNumbersLessThan6 = numbers.TakeWhile(n => n < 6);

            MessageBox.Show("Первые числа, которые меньше 6:");
            foreach (var n in firstNumbersLessThan6)
            {
                textBox1.Text += n + Environment.NewLine;
            }
        }

        //Оператор Skip
        //Оператор Skip, наоборот выдает все элементы, 
        //пропуская определенное количество начальных элементов массива. 
        //Например, получим элементы массива, кроме первых четырех элементов
        public void Linq8()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var notFirst4Numbers = numbers.Skip(4);

            // Пропускаем первые 4 элемента
            foreach (var n in notFirst4Numbers)
            {
                textBox1.Text += n + Environment.NewLine;
            }
        }

        //Оператор SkipWhile
        //Оператор SkipWhile выбирает все элементы массива, 
        //начиная с того, на котором условие перестало выполняться.

        //Этот пример печатает все элементы массива, 
        //пропуская элементы до тех пор, пока не попадется число, 
        //которое делится на 3 без остатка.

        public void Linq9()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var allButFirst3Numbers = numbers.SkipWhile(n => n % 3 != 0);

            textBox1.Text =
                "Последовательность элементов начинается с первого элемента, которое делится без остатка на 3:"
                + Environment.NewLine;

            foreach (var n in allButFirst3Numbers)
            {
                textBox1.Text += n + Environment.NewLine;
            }
        }
    }
}
