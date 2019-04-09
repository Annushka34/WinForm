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
        const string strTextForButton = "Тестовая строкаааааааааааааа";

        public Form1()
        {
            InitializeComponent();
            
            button1.Text = strTextForButton;
            using (Graphics graphics = button1.CreateGraphics())
            {
                button1.Width = (int)graphics.MeasureString(strTextForButton, Font).Width;
                this.Text = button1.Width.ToString();
            }

            button2.Text = strTextForButton;

        }
    }
}