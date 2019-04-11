using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_Forms
{
    public partial class FormMainProgr : Form
    {
        string userName;
        Form1 f;
        public FormMainProgr()
        {
            InitializeComponent();
        }
        public FormMainProgr(string userName): this()
        {
            this.userName = userName;
        }
        public FormMainProgr(Form1 f) 
        {
            this.f = f;
            this.userName = f.u.name;
            InitializeComponent();
            f.Hide();
        }

        private void FormMainProgr_Load(object sender, EventArgs e)
        {
            label1.Text = "HELLO " + userName;
            
        }
    }
}
