using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SimplePaint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Координаты мыши в момент нажатия
        int x_md, y_md;
        // Будем рисовать пером синего цвета и толщиной 3 пиксела
        Pen p = new Pen(Color.Blue, 3);
        // Отслеживаем нажатия кнопки, чтобы знать
        // когда пользователь заканчивает рисовать
        bool bPaint;
        
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            // Начинаем рисовать
            bPaint = true;
            // Координаты мыши в момент нажатия
            x_md = e.X;
            y_md = e.Y;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (bPaint)
            {
                // Создадим объект Graphics для рисования
                Graphics g = CreateGraphics();

                // Определяем координаты мыши при перемещении
                int x_mm = e.X;
                int y_mm = e.Y;
                // Рисуем
                g.DrawLine(p, x_md, y_md, x_mm, y_mm);

                // Передаем координаты мыши в переменные класса
                x_md = x_mm;
                y_md = y_mm;
                g.Dispose();
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            bPaint = false;
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            // Очистим форму от наших художеств при нажатии правой кнопки мыши
            if (e.Button == MouseButtons.Right)
            {
                Graphics g = CreateGraphics();
                g.Clear(this.BackColor);
                g.Dispose();
            }
        }

    }
}