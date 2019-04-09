using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace AnimatedCursors
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll", EntryPoint = "LoadCursorFromFileW",
        CharSet = CharSet.Unicode)]
        public static extern IntPtr LoadCursorFromFile(String fileName);

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fileName = @"D:\archive\cursors\cat-h.ani";
            // ��������� ������ �� �����
            IntPtr hCursor = LoadCursorFromFile(fileName);
            // ������������� ��� � �������� �������� ������� �����
            this.Cursor = new Cursor(hCursor);
        }
    }
}