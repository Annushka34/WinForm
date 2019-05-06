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
    public partial class FormCHild2 : Form
    {
        Form1 _form = null;
        User _u;
        public FormCHild2(Form1 form)
        {
            InitializeComponent();
            _form = form;
        }

        public FormCHild2(User u)
        {
            InitializeComponent();
            _u = u;
            if(_u != null)
            {
                txtName.Text = _u.Name;
                txtSurname.Text = _u.Surname;
                numericUpDown1.Value = _u.Age;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            _u.Name = txtName.Text;
            _u.Surname = txtSurname.Text;
            _u.Age = (int)numericUpDown1.Value;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCansel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
