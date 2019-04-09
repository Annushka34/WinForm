// Картинка спящего котенка взята с сайта http://www.nnm.ru

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;

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
            // Получить изображение
            Image img = pictureBox1.Image;

            // Создаем объект атрибутов изображения
            ImageAttributes ia = new ImageAttributes();

            // создаем атрибуты по матрице преобразования
            ColorMatrix cm = new ColorMatrix();
            cm.Matrix00 = cm.Matrix11 = cm.Matrix22 = -1;

            ia.SetColorMatrix(cm);

            // Рисуем новое изображение с помощью преобразования
            Graphics g = Graphics.FromImage(img);
            g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);

            // Обновить рисунок
            pictureBox1.Invalidate();

            g.Dispose();        

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Получить изображение
            Image img = pictureBox1.Image;

            // Создаем объект атрибутов изображения
            ImageAttributes ia = new ImageAttributes();

            // создаем атрибуты по матрице преобразования
            ColorMatrix cm = new ColorMatrix();
            cm.Matrix00 = 1 / 3f;
            cm.Matrix01 = 1 / 3f;
            cm.Matrix02 = 1 / 3f;
            cm.Matrix10 = 1 / 3f;
            cm.Matrix11 = 1 / 3f;
            cm.Matrix12 = 1 / 3f;
            cm.Matrix20 = 1 / 3f;
            cm.Matrix21 = 1 / 3f;
            cm.Matrix22 = 1 / 3f;

            ia.SetColorMatrix(cm);

            // Рисуем новое изображение с помощью преобразования
            Graphics g = Graphics.FromImage(img);
            g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height,
               GraphicsUnit.Pixel, ia);

            // Обновляем рисунок
            pictureBox1.Invalidate();

            g.Dispose();  
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Получить изображение
            Image img = pictureBox1.Image;

            // Создаем объект атрибутов изображения
            ImageAttributes ia = new ImageAttributes();

            // создаем атрибуты по матрице преобразования
            ColorMatrix cm = new ColorMatrix();
            cm.Matrix00 = 0;
            cm.Matrix11 = 0;
            cm.Matrix22 = 0;
            cm.Matrix33 = 0.25f;

            ia.SetColorMatrix(cm);

            // Рисуем новое изображение с помощью преобразования
            Graphics g = Graphics.FromImage(img);
            g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height,
                GraphicsUnit.Pixel, ia);

            // Обновляем рисунок
            pictureBox1.Invalidate();

            g.Dispose();  

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            ControlPaint.DrawImageDisabled(g, pictureBox1.Image, 2, 2, Color.Red);

            g.Dispose();
        }
    }
}