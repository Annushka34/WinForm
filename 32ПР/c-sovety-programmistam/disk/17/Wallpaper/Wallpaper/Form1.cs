using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Microsoft.Win32;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        static extern int SystemParametersInfo(
            int uAction, int uParam, string lpvParam, int fuWinIni);

        // Константы
        const int SPI_SETDESKWALLPAPER = 20;
        const int SPIF_UPDATEINIFILE = 0x01;
        const int SPIF_SENDWININICHANGE = 0x02;

        public enum WallpaperStyle : int
        {
            Tiled, Centered, Stretched
        }

        private void butSetWallpaper_Click(object sender, EventArgs e)
        {
            string imageFileName;
            imageFileName = Application.StartupPath + "/mycat.bmp";

            RegistryKey key = Registry.CurrentUser.OpenSubKey(
                "Control Panel\\Desktop", true);

            WallpaperStyle style;

            style = (WallpaperStyle)Enum.Parse(typeof(WallpaperStyle), 
                cboStyleWallpaper.Text);


            switch (style)
            {
                case WallpaperStyle.Stretched:
                    key.SetValue(@"WallpaperStyle", "2");
                    key.SetValue(@"TileWallpaper", "0");
                    break;

                case WallpaperStyle.Centered:
                    key.SetValue(@"WallpaperStyle", "1");
                    key.SetValue(@"TileWallpaper", "0");
                    break;

                case WallpaperStyle.Tiled:
                    key.SetValue(@"WallpaperStyle", "1");
                    key.SetValue(@"TileWallpaper", "1");
                    break;
            }

            SystemParametersInfo(SPI_SETDESKWALLPAPER, 0, 
                imageFileName, SPIF_UPDATEINIFILE | SPIF_SENDWININICHANGE);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // связываем комбинированное окно с перечислением WallpaperStyle
            cboStyleWallpaper.DataSource = System.Enum.GetNames(typeof(WallpaperStyle));
        }

    }
}