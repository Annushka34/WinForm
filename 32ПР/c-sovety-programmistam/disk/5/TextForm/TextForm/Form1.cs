using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            this.BackColor = Color.Cyan;
            GraphicsPath gp = new GraphicsPath();
            string myText = "C#.Народные советы";
            gp.AddString(myText, new FontFamily("Tahoma"),
                (int)FontStyle.Bold, 70, new Point(35, 5),
                StringFormat.GenericDefault);
            
            this.Region = new Region(gp);
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}