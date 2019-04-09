using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Bitmap animatedImage = new Bitmap(Application.StartupPath +
                "\\" + "anicat.gif");
        bool currentlyAnimating = false;

        // Метод для анимации
        public void AnimateImage()
        {
            if (!currentlyAnimating)
            {
                ImageAnimator.Animate(animatedImage, 
                    new EventHandler(this.OnFrameChanged));
                currentlyAnimating = true;
            }
        }

        private void OnFrameChanged(object o, EventArgs e)
        {
            //Force a call to the Paint event handler.
            this.Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            //Начинаем анимацию
            AnimateImage();

            // Получим следующий кадр
            ImageAnimator.UpdateFrames();

            // Выводим следующий кадр для анимации
            e.Graphics.DrawImage(this.animatedImage, new Point(0, 0));
        }

        private void button1_Click(object sender, EventArgs e)
        {
           if (ImageAnimator.CanAnimate(animatedImage) == false)
                MessageBox.Show("Это не анимированная картинка");
            else
            {
                // Подсчитываем число фреймов в анимированной картинке
                FrameDimension frameDim =
                    new FrameDimension(animatedImage.FrameDimensionsList[0]);
                int frameCount = animatedImage.GetFrameCount(frameDim);
                MessageBox.Show("Картинка содержит: " + frameCount + " кадров");

                // Сохраняем фреймы в отдельные файлы BMP
                for (int i = 0; i < frameCount; i++)
                {
                    animatedImage.SelectActiveFrame(frameDim, i);
                    MemoryStream ms = new MemoryStream();
                    animatedImage.Save(ms, ImageFormat.Bmp);
                    Image saveImg = Image.FromStream(ms);
                    saveImg.Save(string.Format("anicat{0}.bmp", i));
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Останавливаем анимацию
            ImageAnimator.StopAnimate(animatedImage,
                new EventHandler(this.OnFrameChanged));         
        }




    }
}