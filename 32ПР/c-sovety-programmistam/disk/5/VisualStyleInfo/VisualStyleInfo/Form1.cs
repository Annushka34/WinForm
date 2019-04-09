using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace VisualStyleInfo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const int WM_THEMECHANGED = 0x031A;

        protected override void WndProc(ref Message m)
        {
           // выводим сообщение 
           // при смене визуальных стилей
           if (m.Msg == WM_THEMECHANGED)
	         MessageBox.Show ("Стиль изменился!");
	       base.WndProc (ref m);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add(VisualStyleInformation.Author);
            listBox1.Items.Add(VisualStyleInformation.ColorScheme);
            listBox1.Items.Add(VisualStyleInformation.Company);
            listBox1.Items.Add(VisualStyleInformation.Copyright);
            listBox1.Items.Add(VisualStyleInformation.Description);
            listBox1.Items.Add(VisualStyleInformation.DisplayName);
            listBox1.Items.Add(VisualStyleInformation.IsEnabledByUser);
        }
    }
}