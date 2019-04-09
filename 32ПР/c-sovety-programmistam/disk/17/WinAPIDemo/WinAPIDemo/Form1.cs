using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace WinAPIDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Функция для блокировки компьютера
        [DllImport("user32.dll")]
        private static extern void LockWorkStation();

        //Функция для проверки прав администратора
        [DllImport("shell32.dll")]
        public static extern bool IsUserAnAdmin();

        // Функция, константы и структура для мигания окна
        public const int FLASHW_STOP = 0;
        public const int FLASHW_CAPTION = 0x00000001;
        public const int FLASHW_TRAY = 0x00000002;
        public const int FLASHW_ALL = (FLASHW_CAPTION | FLASHW_TRAY);
        public const int FLASHW_TIMER = 0x00000004;
        public const int FLASHW_TIMERNOFG = 0x0000000C;

        [StructLayout(LayoutKind.Sequential)]
        public struct FLASHWINFO
        {
            [MarshalAs(UnmanagedType.U4)]
            public int cbSize;
            public IntPtr hwnd;
            [MarshalAs(UnmanagedType.U4)]
            public int dwFlags;
            [MarshalAs(UnmanagedType.U4)]
            public int uCount;
            [MarshalAs(UnmanagedType.U4)]
            public int dwTimeout;
        }

        [DllImport("user32.dll")]
        public static extern bool FlashWindowEx([MarshalAs(UnmanagedType.Struct)]
        ref FLASHWINFO pfwi);

        [DllImport("shell32.dll")]
        static extern uint SHFormatDrive(IntPtr hwnd,
        uint drive,
        uint fmtID,
        uint options);


        // Функция для открытия и закрытия лотка привода CD
        [DllImport("winmm.dll", EntryPoint = "mciSendStringA",
        CharSet = CharSet.Ansi)]
        public static extern int mciSendString(string strCommand,
        StringBuilder strReturnString, int cchReturn, IntPtr hwndCallback);

  
        private void butLockComp_Click(object sender, EventArgs e)
        {
            // Блокируем компьютер
            LockWorkStation();
        }

        private void butFlashWindow_Click(object sender, EventArgs e)
        {
            FLASHWINFO fwi = new FLASHWINFO(); 

            fwi.cbSize = Marshal.SizeOf(fwi);
            fwi.hwnd = this.Handle;
            fwi.dwFlags = FLASHW_TRAY;
            fwi.dwTimeout = 0;
            fwi.uCount = 5;

            FlashWindowEx(ref fwi);
        }

        private void butOpenCD_Click(object sender, EventArgs e)
        {
            // Открываем лоток
            mciSendString("set CDAudio door open", null, 0, IntPtr.Zero);
        }

        private void butCloseCD_Click(object sender, EventArgs e)
        {
            // Закрываем лоток
            mciSendString("set CDAudio door closed", null, 0, IntPtr.Zero);
        }

        private void butIsAdmin_Click(object sender, EventArgs e)
        {
            MessageBox.Show(IsUserAnAdmin().ToString());
        }

        private void butFormatDiskDial_Click(object sender, EventArgs e)
        {
            SHFormatDrive(this.Handle, 3, 0, 0);
        }
    }
}