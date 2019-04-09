using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DifferentWindows
{
    public partial class PictureWindow : Form
    {
        public PictureWindow()
        {
            InitializeComponent();
        }

        public DialogResult ShowDialog(string s, Image img)
        {
            lblNameUser.Text = s;
            pictureBox1.Image = img;
            return ShowDialog();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnCANSEL_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
