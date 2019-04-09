using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            
        }
        
        public Form1 form1;

        private void Form2_Load(object sender, EventArgs e)
        {
            this.txtGetText.Text = ((Form1)this.form1).textBox1.Text;
        }
    }
}