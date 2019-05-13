using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14_UserControls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetState_Click(object sender, EventArgs e)
        {
            lblState.Text = string.Empty;
            lblState.Text += myButton1.btn_OK_Cancel.Text+"  ";
            lblState.Text += myButton2.btn_OK_Cancel.Text + "  ";
            lblState.Text += myButton3.btn_OK_Cancel.Text + "  ";
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            myButton1.SetLblText = "Test";
        }
    }
}
