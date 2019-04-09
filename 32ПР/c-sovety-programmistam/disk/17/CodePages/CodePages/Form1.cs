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
        [DllImport("Kernel32.dll")]
        static extern bool EnumSystemCodePages(CODEPAGE_ENUMPROC lpLocaleEnumProc, int dwFlags);
        delegate bool CODEPAGE_ENUMPROC(string lpLocaleString);

        const int CP_INSTALLED = 0x00000001;

        public Form1()
        {
            InitializeComponent();
        }

        private bool EnumCodePagesProc(string locale)
        {
            listBox1.Items.Add(locale);
            return true;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            EnumSystemCodePages(new CODEPAGE_ENUMPROC(EnumCodePagesProc), CP_INSTALLED);
        }
    }
}