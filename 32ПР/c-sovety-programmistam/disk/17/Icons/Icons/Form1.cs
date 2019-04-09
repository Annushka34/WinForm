using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        [DllImport("shell32.dll")]
        static extern IntPtr ExtractIcon(IntPtr hInst,
        string sFileName, int nIconIndex);

        [DllImport("shell32.dll", CharSet = CharSet.Auto, CallingConvention =
         CallingConvention.Winapi)]
        private static extern int PickIconDlg(IntPtr hwndOwner,
        string FileName, int nMaxFile, ref int lpdwIconIndex);

        [DllImport("shell32.dll")]
        public static extern IntPtr SHGetFileInfo(string pszPath,
            uint dwFileAttributes,
            ref SHFILEINFO psfi,
            uint cbSizeFileInfo,
            uint uFlags);

        public struct SHFILEINFO
        {
            public IntPtr hIcon;
            public IntPtr iIcon;
            public uint dwAttributes;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
            public string szDisplayName;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)]
            public string szTypeName;
        };

        public const uint SHGFI_ICON = 0x100;
        public const uint SHGFI_LARGEICON = 0x0;
        public const uint SHGFI_SMALLICON = 0x1;

        string filename = @"C:\windows\system32\shell32.dll";

        private int GetNumberOfIcon(string str)
        {
            return (int)ExtractIcon(this.Handle, str, -1);
        }

        /// <summary>
        /// Извлекает значок из указанного файла в заданную позицию
        /// </summary>
        /// <param name="str">Путь к файлу со значками</param>
        /// <param name="index">Номер значка в файле</param>
        /// <param name="x">Координата X</param>
        /// <param name="y">Координата Y</param>
        private void ExtractIconsFromFile(string str, int index, int x, int y)
        {
            IntPtr retval;

            retval = ExtractIcon(this.Handle, str, index);

            Icon icon = Icon.FromHandle(retval);
            Graphics g = CreateGraphics();
            g.DrawIcon(icon, x, y);
            g.Dispose();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = GetNumberOfIcon(filename).ToString();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // Выводим шестой значок из файла shell32.dll 
            ExtractIconsFromFile(filename, 15, 45, 25);
        }

        private void butShowPickDial_Click(object sender, EventArgs e)
        {
            // Выводим диалоговое окно Смена значка
            // и показываем выбранный значок в PictureBox

            // индекс выбираемого значка при открытии диалогового окна
            int iconindex = 3;
            // выводим диалоговое окно
            PickIconDlg(this.Handle, filename, 0, ref iconindex);

            IntPtr retval;
            // Извлекаем значок по индексу
            retval = ExtractIcon(this.Handle, filename, iconindex);
            // выводим в заголовке номер индекса (для проверки)
            this.Text = iconindex.ToString();

            // Выводим значок в рисуночной области
            Icon icon = Icon.FromHandle(retval);
            Graphics g = pictureBox1.CreateGraphics();
            g.DrawIconUnstretched(icon, new Rectangle(0, 0, 50, 50));
            g.Dispose();
        }

        private void butSHGetFileInfo_Click(object sender, EventArgs e)
        {
            int nIndex = 0;
            IntPtr hImgSmall;
            string fName = @"c:\windows\system32\mspaint.exe";
            SHFILEINFO shinfo = new SHFILEINFO();

            listView1.SmallImageList = imageList1;
            listView1.LargeImageList = imageList1;

            // Получаем маленькие значки
            hImgSmall = SHGetFileInfo(fName, 0,
                ref shinfo, (uint)Marshal.SizeOf(shinfo),
                SHGFI_ICON | SHGFI_SMALLICON);

            //Полученный значок возвращается как член структуры shinfo
            Icon myIcon = Icon.FromHandle(shinfo.hIcon);

            imageList1.Images.Add(myIcon);

            //добавляем имя файла и значок в listview
            listView1.Items.Add(fName, nIndex++);
        }
    }
}