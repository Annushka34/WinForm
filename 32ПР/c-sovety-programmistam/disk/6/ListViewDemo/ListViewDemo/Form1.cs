using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ListViewDemo
{
    public partial class Form1 : Form
    {
        private ListViewColumnSorter lvwColumnSorter;

        public Form1()
        {
            InitializeComponent();
            // Создаем экземпляр  ListViewColumnSorter  и связываем его с ListView 
            lvwColumnSorter = new ListViewColumnSorter();
            this.listView1.ListViewItemSorter = lvwColumnSorter; 
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            // Используется для создания заголовков
            ColumnHeader columnheader;
            // Используется для создания элементов в ListView
            ListViewItem listviewitem;

            // Устанавливаем нужный вид 
            listView1.View = View.Details;

            // Создаем несколько элементов, содержащих имена и фамилии 
            listviewitem = new ListViewItem("Александр");
            listviewitem.SubItems.Add("Суворов");
            this.listView1.Items.Add(listviewitem);
            listviewitem = new ListViewItem("Наполеон");
            listviewitem.SubItems.Add("Бонапарт");
            this.listView1.Items.Add(listviewitem);
            listviewitem = new ListViewItem("Михаил");
            listviewitem.SubItems.Add("Кутузов");
            this.listView1.Items.Add(listviewitem);
            listviewitem = new ListViewItem("Юлий");
            listviewitem.SubItems.Add("Цезарь");
            this.listView1.Items.Add(listviewitem);

            // Создаем колонки 
            columnheader = new ColumnHeader();
            columnheader.Text = "Имя";
            this.listView1.Columns.Add(columnheader);
            columnheader = new ColumnHeader();
            columnheader.Text = "Фамилия";
            this.listView1.Columns.Add(columnheader);

            // Проходим через все элементы и устанавливаем размер каждого заголовка колонки
            // равным тексту
            foreach (ColumnHeader ch in this.listView1.Columns) { ch.Width = -2; } 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            listView1.Items.Add("Алла");
            listView1.Items.Add("София");

            listView1.Items[0].UseItemStyleForSubItems = false; 
            listView1.Items[0].SubItems.Add("Пугачева", Color.Pink, Color.Yellow, Font);
            listView1.Items[1].UseItemStyleForSubItems = false;
            listView1.Items[1].SubItems.Add("Ротару", Color.Teal, Color.Violet, Font);
        }

        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Определяем, если колонка, на которой щелкнули, уже является отсортированной колонкой
            if (e.Column == lvwColumnSorter.SortColumn)
            {
                // Переворачиваем направление сортировки
                if (lvwColumnSorter.Order == SortOrder.Ascending)
                {
                    lvwColumnSorter.Order = SortOrder.Descending;
                }
                else
                {
                    lvwColumnSorter.Order = SortOrder.Ascending;
                }
            }
            else
            {
                // Устанавливаем число колонки для сортировки
                // По умолчанию сортировка по возрастанию
                lvwColumnSorter.SortColumn = e.Column;
                lvwColumnSorter.Order = SortOrder.Ascending;
            }

            // Сортируем с новыми настройками
            this.listView1.Sort();
        }
    }
}