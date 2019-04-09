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
        [DllImport("user32.dll")]
        public static extern int EnumDisplaySettings(
          string deviceName, int modeNum, ref DEVMODE devMode);

        [DllImport("user32.dll")]
        public static extern int ChangeDisplaySettings(
              ref DEVMODE devMode, int flags); 

        [StructLayout(LayoutKind.Sequential)]
        public struct DEVMODE
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string dmDeviceName;
            public short dmSpecVersion;
            public short dmDriverVersion;
            public short dmSize;
            public short dmDriverExtra;
            public int dmFields;

            public short dmOrientation;
            public short dmPaperSize;
            public short dmPaperLength;
            public short dmPaperWidth;

            public short dmScale;
            public short dmCopies;
            public short dmDefaultSource;
            public short dmPrintQuality;
            public short dmColor;
            public short dmDuplex;
            public short dmYResolution;
            public short dmTTOption;
            public short dmCollate;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string dmFormName;
            public short dmLogPixels;
            public short dmBitsPerPel;
            public int dmPelsWidth;
            public int dmPelsHeight;

            public int dmDisplayFlags;
            public int dmDisplayFrequency;

            public int dmICMMethod;
            public int dmICMIntent;
            public int dmMediaType;
            public int dmDitherType;
            public int dmReserved1;
            public int dmReserved2;

            public int dmPanningWidth;
            public int dmPanningHeight;
        };

        public const int ENUM_CURRENT_SETTINGS = -1;
        public const int CDS_UPDATEREGISTRY = 0x01;
        public const int CDS_TEST = 0x02;
        public const int DISP_CHANGE_SUCCESSFUL = 0;
        public const int DISP_CHANGE_RESTART = 1;
        public const int DISP_CHANGE_FAILED = -1;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Screen screen = Screen.PrimaryScreen;
			
	        // Разрешение 640 на 480	
			int iWidth = 640;
			int iHeight = 480;
			
			DEVMODE dm = new DEVMODE();
			dm.dmDeviceName = new String (new char[32]);
			dm.dmFormName = new String (new char[32]);
			dm.dmSize = (short)Marshal.SizeOf (dm);

            if (0 != EnumDisplaySettings(null, ENUM_CURRENT_SETTINGS, ref dm))
            {
                dm.dmPelsWidth = iWidth;
                dm.dmPelsHeight = iHeight;

                int iRet = ChangeDisplaySettings(ref dm, CDS_TEST);

                if (iRet == DISP_CHANGE_FAILED)
                {
                    MessageBox.Show("Не получается поменять разрешение");
                }
                else
                {
                    iRet = ChangeDisplaySettings(ref dm, CDS_UPDATEREGISTRY);

                    switch (iRet)
                    {
                        case DISP_CHANGE_SUCCESSFUL:
                            {
                                break;
                                // разрешение успешно поменяли
                            }
                        case DISP_CHANGE_RESTART:
                            {
                                MessageBox.Show("Необходимо перезагрузить компьютер");
                                break;
                                // для старых версий windows 9x
                            }
                        default:
                            {
                                MessageBox.Show("Ошибка при изменении разрешения");
                                break;
                                // попытка не удалась
                            }
                    }
                }
            }
        }
    }
}