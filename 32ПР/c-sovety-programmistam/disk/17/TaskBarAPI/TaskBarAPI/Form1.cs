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
        private static extern IntPtr FindWindow(
        string className,
        string windowName);

        [DllImport("user32.dll")]
        private static extern IntPtr FindWindowEx(
        IntPtr hwndParent,
        IntPtr hwndChildAfter,
        string className,
        string windowName);

        [DllImport("user32.dll")]
        private static extern bool GetWindowRect(
        IntPtr hWnd,
        ref RECT rect);

        [DllImport("shell32.dll")]
        private static extern int SHAppBarMessage(
        int flag,
        ref AppBarData abd);

        [DllImport("user32.dll")]
        static extern bool ShowWindow(
        IntPtr hWnd, 
        int nCmdShow);

        [DllImport("user32.dll")]
        public static extern IntPtr SendMessage(IntPtr hWnd,
        UInt32 Msg, Int32 wParam, Int32 lParam);

        const int WM_SYSCOMMAND = 0x0112;

        private const int SC_TASKLIST = 0xF130;
        private const int ABM_GETSTATE = 4;
        private const int ABM_GETTASKBARPOS = 5;
        private const int ABM_SETSTATE = 10;
        private const int SW_HIDE = 0;
        private const int SW_SHOW = 5;

        // ��������� ������ �����
        private const int ABS_AUTOHIDE = 1;
        private const int ABS_ALWAYSONTOP = 2;
        private const int ABS_BOTH = 3;


        [StructLayout(LayoutKind.Sequential)]
        public struct AppBarData
        {
            public int cbSize;
            public IntPtr hWnd;
            public int uCallbackMessage;
            public int uEdge;
            public RECT rc;
            public IntPtr lParam;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct RECT
        {
            public int left;
            public int top;
            public int right;
            public int bottom;
        }

        public Form1()
        {
            InitializeComponent();
        }

        // ��������� ������ �����
        IntPtr hW;

        // ��������� ������ ����
        IntPtr hWndStart;

        // ��������� ������� �����������
        IntPtr tray;

        private void butHideStart_Click(object sender, EventArgs e)
        {
            // ���� ���� � ������� Shell_TrayWnd
            hW = FindWindowEx(IntPtr.Zero, IntPtr.Zero, "Shell_TrayWnd",null);

            // ������� ��������� ������ ����
            hWndStart = FindWindowEx(hW, IntPtr.Zero, "BUTTON", null);
            // ������ ������ ����
            ShowWindow(hWndStart, SW_HIDE);
        }

        private void butShowStart_Click(object sender, EventArgs e)
        {
            // ���������� ������ ����
            ShowWindow(hWndStart, SW_SHOW);
        }

        private void butPressStart_Click(object sender, EventArgs e)
        {
            // �������� �� ������ ����
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_TASKLIST, 0);

        }

        private void butHideTray_Click(object sender, EventArgs e)
        {
            hW = FindWindowEx(IntPtr.Zero, IntPtr.Zero, "Shell_TrayWnd", null);

            // ���������� ������� �����������
            tray = FindWindowEx(hW, IntPtr.Zero, "TrayNotifyWnd", null);

            // ������ ������� �����������
            ShowWindow(tray, SW_HIDE);
        }

        private void butShowTray_Click(object sender, EventArgs e)
        {
            ShowWindow(tray, SW_SHOW);
        }

        private void butHideClock_Click(object sender, EventArgs e)
        {
            // ��������� ������ �����
            hW = FindWindowEx(IntPtr.Zero, IntPtr.Zero, "Shell_TrayWnd", null);

            // ��������� ������� �����������
            tray = FindWindowEx(hW, IntPtr.Zero, "TrayNotifyWnd", null);

            // ��������� ��������� �����
            IntPtr trayclock = FindWindowEx(tray, IntPtr.Zero, "TrayClockWClass", null);
             
            // ������ ��������� ����
            ShowWindow(trayclock, SW_HIDE);
        }

        private void butTaskbar_Click(object sender, EventArgs e)
        {
            AppBarData bardata = new AppBarData();
            bardata.cbSize = Marshal.SizeOf(typeof(AppBarData));
            bardata.hWnd = Handle;

            int retval = SHAppBarMessage(ABM_GETSTATE, ref bardata);

            switch (retval)
            {
                case ABS_AUTOHIDE:
                    MessageBox.Show("������������� ������� � ������");
                    break;
                case ABS_ALWAYSONTOP:
                    MessageBox.Show("������ �� ������");
                    break;
                case ABS_BOTH:
                    MessageBox.Show("�������� ����� ������������� ������� � ������ � ���������� ������ ������ ����");
                    break;
            }
            
            // ������� ������� ������ �����
            SHAppBarMessage (ABM_GETTASKBARPOS, ref bardata);

            // ������� ���������� ��������������� ��������������
            MessageBox.Show("���������� ������ �����: (" + 
                bardata.rc.left + "," + bardata.rc.top + ")" +
                "-" + "(" +
                bardata.rc.right + "," + bardata.rc.bottom + ")");
        }
    }
}