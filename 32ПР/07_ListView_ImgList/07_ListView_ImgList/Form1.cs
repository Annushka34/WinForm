﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _07_ListView_ImgList
{
    public partial class Form1 : Form
    {
        string path = @"D:\ШАГ\forms\ПрикладиЗКласу\WinForm\32ПР\07_ListView_ImgList\img\";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ImageList il = new ImageList();
            il.Images.Add(Image.FromFile(path + "1.png"));
            il.Images.Add(new Bitmap(path + "2.png"));
            il.Images.Add(new Bitmap(path + "3.png"));
            il.Images.Add(new Bitmap(path + "4.png"));
            il.Images.Add(new Bitmap(path + "5.png"));
            il.ImageSize = new Size(50, 50);
            il.ColorDepth = ColorDepth.Depth32Bit;

            chB1.ImageList = il;
            chB2.ImageList = il;
            chB3.ImageList = il;

            chB1.ImageIndex = 0;
            chB2.ImageIndex = 1;
            chB3.ImageIndex = 2;
        }
    }
}
