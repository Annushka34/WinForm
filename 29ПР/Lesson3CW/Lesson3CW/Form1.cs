using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson3CW
{
    public partial class Form1 : Form
    {
        Image img;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = @"D:\ШАГ\forms\ПрикладиЗКласу\Lesson3CW\Lesson3CW\img";
            openFileDialog.Filter = "images|*.img;*.jpeg;*.bmp; *.jpg";
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            if(openFileDialog.ShowDialog()==DialogResult.OK)
            {
                img = new Bitmap(openFileDialog.FileName);
                pictureBox1.Image = img;
            }
            label1.Text = img.Size.Width + " " + img.Size.Height;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int maxH = 30;
            int maxW = 30;
            double resizeH = img.Size.Height / maxH;
            double resizeW = img.Size.Width / maxW;

            double resize = resizeH > resizeW ? resizeH : resizeW;


          

            Image newImg = new Bitmap((int)(img.Size.Width / resize), (int)(img.Size.Height / resize));
            Graphics g = Graphics.FromImage(newImg);
            Rectangle rec = new Rectangle(0, 0, (int)(img.Size.Width / resize), (int)(img.Size.Height / resize));
            g.DrawImage(img,0,0, (int)(img.Size.Width / resize), (int)(img.Size.Height / resize));
            //img.Dispose();
            img = newImg;
            pictureBox1.Image = img;
            label1.Text = img.Size.Width + " " + img.Size.Height;

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = @"D:\ШАГ\forms\ПрикладиЗКласу\Lesson3CW\Lesson3CW\img";
            if(saveFileDialog.ShowDialog()==DialogResult.OK)
            {
                img.Save(saveFileDialog.FileName);
            }
        }

        public byte[] ImageToByteArray(Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }
    }
}
