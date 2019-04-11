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
    public partial class Form1 : Form
    {
        public User u;
      
        public Form1()
        {
            InitializeComponent();
            u = new User("111@gmail.com");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
          //  if (u.email == txtEmail.Text && u.pswd == txtPswd.Text)
            {
                FormMainProgr f = new FormMainProgr(this);
                f.Show();

               // f.ShowDialog();
            }
        }
    }
    public struct User
    {
        public string email;
        public string pswd;
        public string name;
        public User(string email)
        {
            this.email = email;
            pswd = "123456";
            name = "Vasja";
        }
    }

}
