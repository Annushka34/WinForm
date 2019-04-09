using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            // Рисуем вдавленный текст
            SolidBrush solBrush = new SolidBrush(Color.Gray);
            Font f = new Font("Tahoma", 48, FontStyle.Bold);
            Graphics g = CreateGraphics();
            g.Clear(BackColor);
            g.DrawString("C#.Народные советы", f, solBrush, 10, 10);
            solBrush.Color = Color.White;
            // Смещаем строку чуть ниже и правее
            g.DrawString("C#.Народные советы", f, solBrush, 12, 11);
            g.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Рисуем выпуклый текст
            SolidBrush solBrush = new SolidBrush(Color.Gray);
            Font f = new Font("Tahoma", 48, FontStyle.Bold);
            Graphics g = CreateGraphics();
            g.Clear(BackColor);
            g.DrawString("C#.Народные советы", f, solBrush, 10, 10);
            solBrush.Color = Color.White;
            // Смещаем строку чуть выше и левее
            g.DrawString("C#.Народные советы", f, solBrush, 8, 8);
            g.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Выводим контуры текста
            GraphicsPath pth = new GraphicsPath();
            // Добавляем строчку
            pth.AddString("C#.Народные советы", new FontFamily("Tahoma"), 
                0, 60, new Point(30, 30),
                StringFormat.GenericDefault);

            // Создаем синее перо
            Pen p = new Pen(Color.Blue, 2);

            // Выводим контурный текст
            Graphics g = CreateGraphics();
            g.DrawPath(p, pth);

            pth.Dispose();
            g.Dispose();
        }
    }
}