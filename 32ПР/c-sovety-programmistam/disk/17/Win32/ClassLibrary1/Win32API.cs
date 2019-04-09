using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace Win32API
{
    public class Win32
    {
        [DllImport("User32.Dll")]
        public static extern void SetWindowText(IntPtr hwnd, String lpString);
    }
}
