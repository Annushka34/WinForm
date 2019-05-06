using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11_MDI
{
    public partial class Form2 : Form
    {
        Form1 _f;
        public Form2(Form1 f, string text)
        {
            InitializeComponent();
            _f = f;
            this.Text = text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _f.focused = !_f.focused;
            _f.ChangeFocus();
        }
    }
}
