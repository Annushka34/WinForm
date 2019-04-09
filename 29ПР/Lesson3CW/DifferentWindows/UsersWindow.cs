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
    public partial class UsersWindow : Form
    {
        public Form1 parentForm = null;
        public UsersWindow()
        {
            InitializeComponent();
        }
        public UsersWindow(Form1 f)
        {
            this.parentForm = f;
            this.parentForm.Hide();
            InitializeComponent();
        }
        private void UsersWindow_Load(object sender, EventArgs e)
        {
            //listBox1.DataSource = parentForm.users;
            foreach (var items in parentForm.users)
                listBox1.Items.Add(items.name);
        }      

        private void UsersWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            parentForm.Show();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = "";
            if (listBox1.SelectedIndex != -1)
            {
                //label1.Text = listBox1.SelectedItem.ToString();
                foreach (var item in listBox1.SelectedItems)
                {
                    str += item.ToString()+" ";
                }
                label1.Text = str;
            }
        }
    }
}
