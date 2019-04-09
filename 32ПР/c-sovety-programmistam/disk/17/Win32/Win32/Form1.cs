using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Win32API;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        [DllImport("User32.Dll")]
        public static extern void SetWindowText(IntPtr hwnd, String lpString);

        [DllImport("user32.dll")]
        public static extern int GetWindowText(IntPtr hwnd,
            StringBuilder buf, int nMaxCount);

        [DllImport("user32.dll")]
        public static extern int GetClassName(IntPtr hwnd,
            [MarshalAs(UnmanagedType.LPStr)] StringBuilder buf,
            int nMaxCount);

        [StructLayout(LayoutKind.Sequential)]
        public struct RECT
        {
            public int left;
            public int top;
            public int right;
            public int bottom;
        }

        [DllImport("user32.dll")]
        public static extern int GetWindowRect(IntPtr hwnd, ref RECT lpRect);

        [DllImport("user32.dll")]
        public static extern int GetWindowRect(IntPtr hwnd, ref Rectangle rc);

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //SetWindowText(this.Handle, "How are you?");
            Win32.SetWindowText(this.Handle, "Я самый умный");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sTitleBar = new StringBuilder(255);
            GetWindowText(this.Handle, sTitleBar, sTitleBar.Capacity);
            MessageBox.Show(sTitleBar.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StringBuilder sClassName = new StringBuilder(255);
            GetClassName(this.Handle, sClassName, sClassName.Capacity);
            MessageBox.Show(sClassName.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int w, h;
            RECT rc = new RECT();
            GetWindowRect(this.Handle, ref rc);
            w = rc.right - rc.left;
            h = rc.bottom - rc.top;
            MessageBox.Show("Ширина формы: " + w + "\n\rВысота формы: " + h);

            //Rectangle r = new Rectangle();
            //GetWindowRect(this.Handle, ref r);
            
            //MessageBox.Show("Ширина формы: " + r.Width + "\n\rВысота формы: " + r.Height);

        }
    }
}