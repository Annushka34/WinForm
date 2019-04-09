using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.Runtime.InteropServices;

namespace SystemMenu
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll", EntryPoint = "GetSystemMenu", SetLastError = true,
        CharSet = CharSet.Unicode, ExactSpelling = true,
        CallingConvention = CallingConvention.Winapi)]
        private static extern IntPtr GetSystemMenu(IntPtr hwnd,
        int bRevert);

        [DllImport("user32.dll")]
        private static extern bool AppendMenu(IntPtr hMenu, MenuFlags uFlags,
        uint wIDNewItem, String lpNewItem);

        // Флаги для системного меню
        public enum MenuFlags
        {
            MF_BITMAP = 0x00000004,
            MF_CHECKED = 0x00000008,
            MF_DISABLED = 0x00000002,
            MF_ENABLED = 0x00000000,
            MF_GRAYED = 0x00000001,
            MF_MENUBREAK = 0x00000020,
            MF_OWNERDRAW = 0x00000100,
            MF_POPUP = 0x00000010,
            MF_SEPARATOR = 0x00000800,
            MF_STRING = 0x00000000,
            MF_UNCHECKED = 0x00000000
        }

        public Form1()
        {
            InitializeComponent();

            // Получаем описатель системного меню
            IntPtr hSysMenu = GetSystemMenu(this.Handle, 0);

            // Добавляем новые пункты в системное меню
            AppendMenu(hSysMenu, MenuFlags.MF_SEPARATOR, 0, null);
            AppendMenu(hSysMenu, MenuFlags.MF_STRING, ID_ABOUT, "C#.Народные советы");
        }

        // Сообщение Windows
        const int WM_SYSCOMMAND = 0x0112;

        // Наш новый идентификатор для системного меню
        const int ID_ABOUT = 1000;

        protected override void WndProc(ref Message msg)
        {
            if (msg.Msg == WM_SYSCOMMAND)
            {
                if(msg.WParam.ToInt32()==ID_ABOUT)
                {
                    MessageBox.Show("Вы выбрали пункт системного меню");
                    return;
                }
            }
            base.WndProc(ref msg);
        }

    }
}