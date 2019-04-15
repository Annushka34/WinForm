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
        public User u;
        Form1 f;
        public FormMainProgr()
        {
            InitializeComponent();
        }
        public FormMainProgr(User u): this()
        {
            this.u = u;
        }
        public FormMainProgr(Form1 f, User u) 
        {
            this.f = f;
            this.u = u;
            InitializeComponent();
            f.Hide();
        }

        private void FormMainProgr_Load(object sender, EventArgs e)
        {
            label1.Text = "HELLO " + u.name;
            label1.Image = Image.FromFile(u.Path + u.img+ ".jpg");
            
        }

        private void FormMainProgr_FormClosing(object sender, FormClosingEventArgs e)
        {
            f.Close();
        }
    }
}
