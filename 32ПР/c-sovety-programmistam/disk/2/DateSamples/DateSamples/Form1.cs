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

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now;
            MessageBox.Show(today.Date.ToLongDateString());
        }

        private void butCompare_Click(object sender, EventArgs e)
        {
            // Измеряем производительность для UtsNow
            //DateTime dt = DateTime.UtcNow;
            //Stopwatch sw = new Stopwatch();
            //for (int i = 0; i < 10; i++)
            //{
            //    sw.Start();
            //    for (int j = 0; j < 100000; j++)
            //    {
            //        if (DateTime.UtcNow == dt)
            //        {
            //            /* do action */
            //        }
            //    }
            //    MessageBox.Show(sw.ElapsedTicks.ToString());
            //}

            // Аналогичная проверка производительности для Now
            DateTime dt = DateTime.Now;
            Stopwatch sw = new Stopwatch();
            for (int i = 0; i < 10; i++)
            {
                sw.Start();
                for (int j = 0; j < 100000; j++)
                {
                    if (DateTime.Now == dt)
                    {
                        /* do action */
                    }
                }
                MessageBox.Show(sw.ElapsedTicks.ToString());
            }

        }

        private void butTimeSpan_Click(object sender, EventArgs e)
        {
            DateTime curdate = DateTime.Now;
            // Прибавляем семь дней к текущей дате
            DateTime mydate = curdate.AddDays(7);
            MessageBox.Show(mydate.ToShortDateString());
        }

        private void butDateDiffVB_Click(object sender, EventArgs e)
        {
            DateTime date1 = new DateTime(1945, 5, 9);  // Первая дата
            DateTime date2 = new DateTime(2007, 8, 21); // Вторая дата

            // Вычисляем разницу в днях при помощи перечисления DateInterval.Day
            long diff = DateAndTime.DateDiff(DateInterval.Day, date1, date2,
                FirstDayOfWeek.Monday, FirstWeekOfYear.System);

            // Выводим результат в заголовке формы
            this.Text = diff.ToString();
        }

        // Наш собственный метод вычисления разницы в датах
        public static int DaysDiff(DateTime date1, DateTime date2)
        {
            return date1.Subtract(date2.Date).Days;
        }

        private void butDateDiffCS_Click(object sender, EventArgs e)
        {
            string howdays = DaysDiff(DateTime.Today, new DateTime(1966, 07, 27)).ToString();
            MessageBox.Show("Со дня моего дня рождения прошло: " + howdays);
        }

        private void butLeapYear_Click(object sender, EventArgs e)
        {
            bool leapYear = DateTime.IsLeapYear(DateTime.Now.Year);
            MessageBox.Show(
                String.Format("{0} является высокосным годом: {1}",
                DateTime.Now.Year, leapYear));
        }

        /// <summary>
        /// Алгоритм для вычисления католической Пасхи
        /// http://snippets.dzone.com/posts/show/765
        /// </summary>
        /// <param name="year">Год</param>
        /// <returns>Пасха</returns>
        public static DateTime EasterDate(int year)
        {
            int Y = year;
            int a = Y % 19;
            int b = Y / 100;
            int c = Y % 100;
            int d = b / 4;
            int e = b % 4;
            int f = (b + 8) / 25;
            int g = (b - f + 1) / 3;
            int h = (19 * a + b - d - g + 15) % 30;
            int i = c / 4;
            int k = c % 4;
            int L = (32 + 2 * e + 2 * i - h - k) % 7;
            int m = (a + 11 * h + 22 * L) / 451;
            int month = (h + L - 7 * m + 114) / 31;
            int day = ((h + L - 7 * m + 114) % 31) + 1;
            DateTime dt = new DateTime(year, month, day);
            return dt;
        }

        private void butEaster_Click(object sender, EventArgs e)
        {
            // когда была католическая Пасха в 2006 году
            MessageBox.Show(EasterDate(2006).ToLongDateString());

        }

        private void butDateTime_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;

            listBox1.Items.Clear();
            listBox1.Items.Add("d: " + dt.ToString("d"));
            listBox1.Items.Add("D: " + dt.ToString("D"));
            listBox1.Items.Add("f: " + dt.ToString("f"));
            listBox1.Items.Add("F: " + dt.ToString("F"));
            listBox1.Items.Add("g: " + dt.ToString("g"));
            listBox1.Items.Add("G: " + dt.ToString("G"));
            listBox1.Items.Add("m: " + dt.ToString("m"));
            listBox1.Items.Add("r: " + dt.ToString("r"));
            listBox1.Items.Add("s: " + dt.ToString("s"));
            listBox1.Items.Add("u: " + dt.ToString("u"));
            listBox1.Items.Add("U: " + dt.ToString("U"));
            listBox1.Items.Add("y: " + dt.ToString("y"));

            listBox1.Items.Add("MMMM dd: " + dt.ToString("MMMM dd"));
            listBox1.Items.Add("MM/dd/yyyy: " + dt.ToString("MM/dd/yyyy"));
            listBox1.Items.Add("MM/dd/yyyy HH:mm: " + dt.ToString("MM/dd/yyyy HH:mm"));
            listBox1.Items.Add("MM/dd/yyyy hh:mm tt: " + dt.ToString("MM/dd/yyyy hh:mm tt"));
            listBox1.Items.Add("MM/dd/yyyy H:mm: " + dt.ToString("MM/dd/yyyy H:mm"));
            listBox1.Items.Add("MM/dd/yyyy h:mm tt: " + dt.ToString("MM/dd/yyyy h:mm tt"));
            listBox1.Items.Add("MM/dd/yyyy HH:mm:ss: " + dt.ToString("MM/dd/yyyy HH:mm:ss"));
            
            listBox1.Items.Add("dddd, dd MMMM yyyy: " + dt.ToString("dddd, dd MMMM yyyy"));
            listBox1.Items.Add("dddd, dd MMMM yyyy HH:mm:ss: " + dt.ToString("dddd, dd MMMM yyyy HH:mm:ss"));
            listBox1.Items.Add("ddd, dd MMM yyyy HH':'mm':'ss 'GMT': " + dt.ToString("ddd, dd MMM yyyy HH':'mm':'ss 'GMT'"));
            
            listBox1.Items.Add("yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK: " + dt.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK"));
            listBox1.Items.Add("yyyy'-'MM'-'dd'T'HH':'mm':'ss: " + dt.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss"));
            listBox1.Items.Add("yyyy MMMM: " + dt.ToString("yyyy MMMM"));

            listBox1.Items.Add("H:mm: " + dt.ToString("H:mm"));
            listBox1.Items.Add("HH:mm: " + dt.ToString("HH:mm"));
            listBox1.Items.Add("HH:mm:ss: " + dt.ToString("HH:mm:ss"));
            listBox1.Items.Add("h:mm tt: " + dt.ToString("h:mm tt"));
            listBox1.Items.Add("hh:mm tt: " + dt.ToString("hh:mm tt"));
        }

    }
}