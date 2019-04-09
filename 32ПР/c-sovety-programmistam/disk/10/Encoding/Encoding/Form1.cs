using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void butKOI8R_Click(object sender, EventArgs e)
        {
            System.IO.FileStream fs = new System.IO.FileStream(@"D:\MyBook\CSharp_Tips\koi8r.txt", System.IO.FileMode.OpenOrCreate);
            System.IO.StreamReader sr = 
                new System.IO.StreamReader(fs, System.Text.Encoding.GetEncoding("KOI8-r"), false);
            textBox1.Text = sr.ReadToEnd();
        }

        private void butSaveWin1251_Click(object sender, EventArgs e)
        {
            System.IO.StreamWriter sw = 
                new System.IO.StreamWriter(@"D:\MyBook\CSharp_Tips\win.txt",false, System.Text.Encoding.GetEncoding(1251));
            sw.Write(textBox1.Text);
            sw.Close();
        }
    }
}