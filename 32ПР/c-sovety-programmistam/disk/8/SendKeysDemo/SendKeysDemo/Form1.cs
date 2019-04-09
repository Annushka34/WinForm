using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace SendKeysDemo
{
    public partial class Form1 : Form
    {
        [DllImport("USER32.DLL")]
        static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
        
        [DllImport("USER32.DLL")]
        static extern bool SetForegroundWindow(IntPtr hWnd);


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Process note = Process.Start("notepad.exe");
            note.WaitForInputIdle();

            IntPtr notepadHandle = FindWindow(null, "Блокнот");

                SetForegroundWindow(notepadHandle);
                SendKeys.SendWait("C# ");
                SendKeys.SendWait(" Народные советы");
                SendKeys.SendWait("~");
                SendKeys.SendWait("    Обалдеть!");
        }
    }
}