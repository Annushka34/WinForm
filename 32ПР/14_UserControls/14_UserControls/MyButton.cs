using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14_UserControls
{
    public partial class MyButton : UserControl
    {
        public MyButton()
        {
            InitializeComponent();
        }

        public string SetLblText
        {
            set
            {
                lbl_Ok_Cancel.Text = value;
            }
        }

        private void btn_OK_Cancel_Click(object sender, EventArgs e)
        {
            if (btn_OK_Cancel.Text == "OK")
            {
                btn_OK_Cancel.Text = "Cancel";
                lbl_Ok_Cancel.Text = "You press OK";
                btn_OK_Cancel.BackColor = Color.FromArgb(255, 192, 128);
            }
            else
            {
                btn_OK_Cancel.Text = "OK";
                lbl_Ok_Cancel.Text = "You press Cancel";
                btn_OK_Cancel.BackColor = Color.AliceBlue;
            }
        }
    }
}
