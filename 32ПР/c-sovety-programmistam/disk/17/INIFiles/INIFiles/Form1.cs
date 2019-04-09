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

        [DllImport("kernel32")]
        private static extern bool WritePrivateProfileString(string AppName,
        string KeyName, string lpString, string FileName);

        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string AppName,
        string KeyName, string lpDefault, StringBuilder ReturnedString,
        int Size, string FileName);

        [DllImport("kernel32.dll")]
        private static extern int GetPrivateProfileInt(string AppName,
        string KeyName, int nDefault, string FileName);

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Устанавливаем значение ключа Width и Height в разделе [Form] файла
            // C:\config.ini в соответствии с размерами формы
            WritePrivateProfileString("Form", 
                "Width", this.Width.ToString(), @"C:\config.ini");
            WritePrivateProfileString("Form",
                "Height", this.Height.ToString(), @"C:\config.ini");

            // Запоминаем текст в текстовом поле в разделе [Text] файла
            // C:\config.ini
            WritePrivateProfileString("TextBox1",
                "Text", textBox1.Text, @"C:\config.ini");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // читаем значение "Text" в секции [TextBox1] 
            // INI-файла config.ini
            StringBuilder sb = new StringBuilder(256);
            GetPrivateProfileString("TextBox1", "Text",
                "C#.Народные советы", sb, sb.Capacity, @"C:\config.ini");

            textBox1.Text = sb.ToString();

            // Читаем значение Width из ключа [Form]
            // файла INI file C:\CONFIG.INI
            this.Width = GetPrivateProfileInt("Form", "Width", 200, @"C:\config.ini");

            // Читаем значение Height из ключа [Form]
            // файла INI file C:\CONFIG.INI
            this.Height = GetPrivateProfileInt("Form", "Height", 200, @"C:\config.ini");
        }
    }
}