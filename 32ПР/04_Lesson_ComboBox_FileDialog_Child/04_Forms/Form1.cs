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
        public List<User> users;

        public Form1()
        {
            InitializeComponent();
            users = new List<User>
            {
              new User{  email = "111@gmail.com", name = "Olga", pswd = "111", img = "2" },
               new User{  email = "semen@gmail.com", name = "Semen", pswd = "111", img = "3" }
        };
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           if (users.Any(u => u.email == txtEmail.Text && u.pswd == txtPswd.Text))
            {
                User user =  users.Where(u => u.email == txtEmail.Text && u.pswd == txtPswd.Text).FirstOrDefault();
                FormMainProgr f = new FormMainProgr(this, user);
                f.Show();
               // f.ShowDialog();
            }
            else
            {
                lblValidEmail.Text = "No such user";
            }
        }
    }
    public class User
    {
        public string email;
        public string pswd;
        public string name;
        public string img;
        public string Path { set; get; } = @"D:\ШАГ\forms\ПрикладиЗКласу\WinForm\32ПР\04_Lesson_ComboBox_FileDialog_Child\04_Forms\img\";

        //public User(string email)
        //{
        //    this.email = email;
        //    pswd = "123456";
        //    name = "Vasja";
        //    path =
        //    img = "1";
        //}
    }

}
