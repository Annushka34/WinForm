using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.Runtime.InteropServices;

namespace RemoveX
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Получаем описатель системного меню
            IntPtr hSysMenu = GetSystemMenu(this.Handle, 0);
            int menucount = GetMenuItemCount(hSysMenu);
            // Убираем последний пункт меню - команду Закрыть
            RemoveMenu(hSysMenu, menucount - 1, MenuFlags.MF_BYPOSITION);
            // Убираем предпоследний пункт меню - разделитель
            RemoveMenu(hSysMenu, menucount - 2, MenuFlags.MF_BYPOSITION);
            // Перерисовываем меню
            DrawMenuBar(hSysMenu);
        }

        // Флаги для системного меню
        public enum MenuFlags
        {
            MF_BYCOMMAND = 0x00000000,
            MF_BYPOSITION = 0x00000400,
        }


        [DllImport("user32.dll")]
        private static extern IntPtr GetSystemMenu(IntPtr hwnd,
        int bRevert);

        [DllImport("user32.dll")]
        private static extern int GetMenuItemCount(IntPtr hMenu);


        [DllImport("user32.dll")]
        private static extern int RemoveMenu(IntPtr hMenu, 
        int Position, MenuFlags uFlags);

        [DllImport("user32.dll")]
        private static extern bool DrawMenuBar(IntPtr hWnd);


        private void butExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        } 


    }
}