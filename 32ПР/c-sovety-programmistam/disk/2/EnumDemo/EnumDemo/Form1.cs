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

        enum Cats { Рыжик = 3, Барсик = 5, Мурзик, Васька, Пушок };

        private void button1_Click(object sender, EventArgs e)
        {
            // Перечисляем все элементы перечисления
            string[] catNames = Enum.GetNames(typeof(Cats));

            foreach (string s in catNames)
            {
                listBox1.Items.Add(s);
            }

            // Перечисляем все значения перечисления
            int[] valCats = (int[])Enum.GetValues(typeof(Cats));

            foreach (int val in valCats)
            {
                listBox1.Items.Add(val.ToString());
            }

            MessageBox.Show(catNames[3].ToString());
            MessageBox.Show(valCats[3].ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Получаем массив строк, содержащих все цвета в системе
            string[] allcolors = Enum.GetNames(typeof(System.Drawing.KnownColor));

            listBox1.Items.Clear();

            // Выводим все имена в список
            listBox1.Items.AddRange(allcolors);

            // другой вариант
            //foreach (string s in allcolors)
            //{                
            //    listBox1.Items.Add(s);
            //}
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Object ColorEnum;
            ColorEnum = System.Enum.Parse(typeof(KnownColor),listBox1.Text);
            KnownColor SelectedColor = (KnownColor)ColorEnum;
            this.BackColor = System.Drawing.Color.FromKnownColor(SelectedColor);
        }
    }
}