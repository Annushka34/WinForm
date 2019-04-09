using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ListBoxDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("One");
            listBox1.Items.Add("Two");
            listBox1.Items.Add("Three");

            lstColor.Items.Add(Color.Red.Name);
            lstColor.Items.Add(Color.Yellow.Name);
            lstColor.Items.Add(Color.Green.Name);
            lstColor.Items.Add(Color.Blue.Name);
        }

        private void butInsert_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text != "")
            {
                listBox1.Items.Insert(1, textBox1.Text);
                textBox1.Text = "";
            }

            // Подгоняем ширину списка под самый длинный текст
            Graphics g = listBox1.CreateGraphics();
            float maxWidth = 0f;
            float height = 0f;

            for (int i = 0; i < listBox1.Items.Count; ++i)
            {
                float w = g.MeasureString(listBox1.Items[i].ToString(), listBox1.Font).Width;
                if (w > maxWidth)
                    maxWidth = w;
                height += listBox1.GetItemHeight(i);
            }
            g.Dispose();

            listBox1.Width = (int)(maxWidth + 8 + ((height > listBox1.Height - 4) ? 16 : 0)); // 16 - ширина прокрутки

            
        }

        private void butDelete_Click(object sender, EventArgs e)
        {
            int nSelectedIndex = this.listBox1.SelectedIndex;
            listBox1.Items.RemoveAt(nSelectedIndex);
        }

        private void listBox1_DragDrop(object sender, DragEventArgs e)
        {
            //Извлекаем имя перетаскиваемого файла
            string[] astrings = (string[])e.Data.GetData(DataFormats.FileDrop, true);
            
            foreach (string strfile in astrings)
            {
                // только имя файла 
                listBox1.Items.Add(strfile.Substring(1 + strfile.LastIndexOf(@"\")));

                // или полный путь к файлу 
                listBox1.Items.Add(strfile); 
            } 
        }

        private void listBox1_DragEnter(object sender, DragEventArgs e)
        {
            //Разрешаем Drop только файлам
            e.Effect = e.Data.GetDataPresent(DataFormats.FileDrop) ? DragDropEffects.All : DragDropEffects.None;
        }

        private void lstColor_DrawItem(object sender, DrawItemEventArgs e)
        {
            if ((e.State & DrawItemState.Selected) != 0)
                e.Graphics.FillRectangle(SystemBrushes.Highlight, e.Bounds);
            else
                e.Graphics.FillRectangle(Brushes.White, e.Bounds);

            string itemText = lstColor.Items[e.Index].ToString();
            Color color = Color.FromName(itemText);

            //Рисуем строку
            e.Graphics.DrawString(itemText, Font, new SolidBrush(color), e.Bounds);
            Pen pen = new Pen(color);
            
            //Рисуем линию под строкой
            e.Graphics.DrawLine(pen, e.Bounds.X, e.Bounds.Bottom - 1, e.Bounds.Right, e.Bounds.Bottom - 1);
        }
    }
}