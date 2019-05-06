using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11_ChildForm
{
    public partial class MainForm : Form
    {
        Form1 _f;
        public MainForm(Form1 f)
        {
            InitializeComponent();
            _f = f;
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _f.Close();
        }
    }
}
