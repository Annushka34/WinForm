using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void butSaveJPG_Click(object sender, EventArgs e)
        {
            IDataObject oDataOjb = System.Windows.Forms.Clipboard.GetDataObject();
            if(oDataOjb.GetDataPresent(System.Windows.Forms.DataFormats.Bitmap))
            {
                Image oImgOjb = (Image)oDataOjb.GetData(DataFormats.Bitmap,true);
                // Сохраняем в файл типа JPG
                oImgOjb.Save(@"c:\test.jpg",System.Drawing.Imaging.ImageFormat.Jpeg);
            }
        }
    }
}