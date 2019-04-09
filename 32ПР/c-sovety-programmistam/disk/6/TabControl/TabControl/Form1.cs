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
            // Переключаемся на другую вкладку при помощи SelectedTab
            this.tabControl1.SelectedTab = this.tabPage2;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Переключаемся на другую вкладку при помощи SelectedIndex
            this.tabControl1.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // не работает
            this.button1.Focus();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            // работает
            this.button1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Добавляем новую вкладку 
            tabControl1.Controls.Add(new TabPage("Новая вкладка"));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Удалить выбранную вкладку 
            tabControl1.Controls.Remove(tabControl1.SelectedTab); 
        }


        /// <summary>
        /// Вставляет закладку в заданную позицию
        /// </summary>
        /// <param name="tabNumber">Номер вкладки</param>
        /// <param name="tabControl">Элемент TabControl</param>
        private void InsertTab(int tabNumber, ref TabControl tabControl)
        {
            int counter = tabControl.Controls.Count;
            if (tabNumber < 0 || tabNumber > counter)
            {
                tabControl.Controls.Add(new TabPage("Вкладка"));
                return;
            }

            int target = tabControl.SelectedIndex;

            // сохраняем существующие ярлычки и очищаем элементы 
            Control[] c = new Control[counter];
            tabControl.Controls.CopyTo(c, 0);
            tabControl.Controls.Clear();

            // Добавляем ярлычки до вставляемого элемента 
            for (int i = 0; i < target; ++i)
                tabControl.Controls.Add(c[i]);
            // Вставляем свой ярлычок 
            tabControl.Controls.Add(new TabPage("Вставленная вкладка"));

            // Добавляем ярлычки после вставляемого элемента 
            for (int i = target; i < counter; ++i)
                tabControl.Controls.Add(c[i]);

            // Выбираем вставленную вкладку 
            tabControl.SelectedIndex = target;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Добавляем ярлычок во вторую позицию
            InsertTab(2, ref tabControl1);
        }

    }
}