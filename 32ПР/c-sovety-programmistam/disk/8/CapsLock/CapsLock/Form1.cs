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

        [DllImport("user32.dll")]
        static extern void keybd_event(byte bVk, byte bScan, uint dwFlags,
        UIntPtr dwExtraInfo);

        [DllImport("user32")]
        public static extern int GetKeyboardState(byte[] pbKeyState);   

        private const int VK_NUMLOCK = 0x90;
        private const int VK_SCROLL = 0x91;
        private const int VK_CAPITAL = 0x14;
        private const int KEYEVENTF_EXTENDEDKEY = 0x1;
        private const int KEYEVENTF_KEYUP = 0x2;

        private void butCapsLock_Click(object sender, EventArgs e)
        {
            // Включаем индикатор Caps Lock
            keybd_event(VK_CAPITAL, 0x45, KEYEVENTF_EXTENDEDKEY, (UIntPtr)0);
            keybd_event(VK_CAPITAL, 0x45, KEYEVENTF_EXTENDEDKEY | KEYEVENTF_KEYUP,
                (UIntPtr)0);
        }

        private void butNumLock_Click(object sender, EventArgs e)
        {
            // Включаем или выключаем индикатор Num Lock
            keybd_event(VK_NUMLOCK, 0x45, KEYEVENTF_EXTENDEDKEY, (UIntPtr)0);
            keybd_event(VK_NUMLOCK, 0x45, KEYEVENTF_EXTENDEDKEY | KEYEVENTF_KEYUP,
                (UIntPtr)0);
        }

        private void butScrollLock_Click(object sender, EventArgs e)
        {
            // Включаем или выключаем индикатор Scroll Lock
            keybd_event(VK_SCROLL, 0x45, KEYEVENTF_EXTENDEDKEY, (UIntPtr)0);
            keybd_event(VK_SCROLL, 0x45, KEYEVENTF_EXTENDEDKEY | KEYEVENTF_KEYUP,
                (UIntPtr)0);
        }

        private void butStatus_Click(object sender, EventArgs e)
        {
            bool CapsLockState;
            byte[] keyState = new byte[256];

            GetKeyboardState(keyState);

            CapsLockState = Convert.ToBoolean(keyState[VK_CAPITAL]);

            if (CapsLockState)
                lblCapsLock.Text = "Caps Lock: Вкл";
            else
                lblCapsLock.Text = "Caps Lock: Выкл";
        }

        private void butNumLockState_Click(object sender, EventArgs e)
        {
            lblCapsLock.Text = Control.IsKeyLocked(Keys.CapsLock).ToString();
                      
        }

    }
}