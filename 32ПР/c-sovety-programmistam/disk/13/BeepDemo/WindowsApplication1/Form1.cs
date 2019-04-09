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
        [DllImport("kernel32.dll")]
        public static extern bool Beep(int freq, int duration);

        [DllImport("user32.dll")]
        public static extern int MessageBeep(uint n); 


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Beep(500, 500);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBeep(0x0); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Microsoft.VisualBasic.Interaction.Beep(); 
        }
    }
}