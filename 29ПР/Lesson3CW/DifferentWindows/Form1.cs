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
    public partial class Form1 : Form
    {
        Image img;
        public List<User> users = new List<User>();
        Button addNewUser = new Button();
        UsersWindow usersWindow = null;
        public Form1()
        {
            InitializeComponent();
            addNewUser.Location = new Point(13, 45);
            addNewUser.Text = "Add new user";
            addNewUser.Width = 100;
            this.Controls.Add(addNewUser);
            addNewUser.Visible = false;
            addNewUser.Click += AddNewUser_Click;
        }

        private void AddNewUser_Click(object sender, EventArgs e)
        {
            label1.Font = new Font(FontFamily.GenericMonospace, 12, FontStyle.Regular);
            label1.Text = "Name";
            pictureBox1.Image = null;
            pictureBox1.Visible = true;
            textBox1.Visible = true;
            textBox1.Text = " ";
            btnImg.Visible = true;
            addNewUser.Visible = false;
        }

        private void btnImg_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            img = LoadPicture();

            PictureWindow pictureWindow = new PictureWindow();
            if(pictureWindow.ShowDialog(name, img) == DialogResult.OK)
                {
                User u = new User();
                u.name = name;
                u.photo = img;
                users.Add(u);
                //змінюємо формочку
                label1.Font = new Font(FontFamily.GenericMonospace, 18, FontStyle.Bold);
                label1.Text = "Added "+name;
                pictureBox1.Visible = false;
                textBox1.Visible = false;
                btnImg.Visible = false;
                addNewUser.Visible = true;
                
                }

        }

        private Image LoadPicture()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = @"D:\ШАГ\forms\ПрикладиЗКласу\Lesson3CW\Lesson3CW\img";
            openFileDialog.Filter = "images|*.img;*.jpeg;*.bmp; *.jpg";
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                img = new Bitmap(openFileDialog.FileName);
                pictureBox1.Image = img;
            }
            return img;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (usersWindow != null)
            {
                usersWindow.Close();
            }
            usersWindow = new UsersWindow(this);
            usersWindow.Show();
            // this.Hide();
        }
    }

    public class User
    {
        public Image photo { set; get; }
        public string name { set; get; }

    }
}
