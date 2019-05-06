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
    public partial class Form1 : Form
    {
        FormChild form;
        FormCHild2 formUser;
        MainForm mainForm = null;
        User u = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShowModal_Click(object sender, EventArgs e)
        {
            lblWarning.Text = "";
            string text = txtName.Text;
            if (text != "")
            {
                //---case 1----
                //form = new FormChild(text);
                //form.ShowDialog();
                //---case 2---
                //form = new FormChild();
                //DialogResult result =  form.ShowDialog(text);
                //lblWarning.Text = result.ToString();
                //---case 3---
                form = new FormChild();
                form.SetText(text);
                DialogResult result = form.ShowDialog();
                lblWarning.Text = result.ToString();
            }
            else
                lblWarning.Text = "Enter user name";
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            //-----CREATE NEW USER-----
            u = new User();
            // formUser = new FormCHild2(this);
            formUser = new FormCHild2(u);
            ChildResultUser();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            u = new User();
            u.Name = txtName.Text;
            u.Surname = txtSurname.Text;
            u.Age = int.Parse(numAge.Value.ToString());
         //   formUser = new FormCHild2(this);
            formUser = new FormCHild2(u);
            ChildResultUser();
        }

        void ChildResultUser()
        {
            DialogResult result = formUser.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtName.Text = u.Name;
                txtSurname.Text = u.Surname;
                numAge.Value = u.Age;
                this.Text = "Привіт " + u.Name;
            }
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            if (mainForm == null )
            {
                mainForm = new MainForm(this);
                mainForm.Show();
                this.Hide();
            }
        }
    }
}
