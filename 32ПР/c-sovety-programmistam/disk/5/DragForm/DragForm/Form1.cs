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
        // Объявляем переменную, которая включает режим перетаскивания
        private bool bDragStatus;

        // Хранит координаты смещения при щелчке мышью
        private Point clickPoint;

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // Включаем режим перетаскивания
                // и сохраняем координаты мыши
                bDragStatus = true;
                clickPoint = new Point(e.X, e.Y);
            }
            else
            {
                bDragStatus = false;
            }
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (bDragStatus)
            {
                Point pointMoveTo;
                // Получим текущие координаты мыши в экранных координатах
                pointMoveTo = this.PointToScreen(new Point(e.X, e.Y));

                // Изменяем позицию на величину clickPoint
                pointMoveTo.Offset(-clickPoint.X, -clickPoint.Y);
                // Перемещаем форму
                this.Location = pointMoveTo;
            }
        }

        private void label1_MouseUp(object sender, MouseEventArgs e)
        {
            // Отключаем режим перетаскивания
            bDragStatus = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}