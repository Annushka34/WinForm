using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11_MDI
{
    public partial class Form1 : Form
    {
        public bool focused = true;
        public int[] arrField = new int[9];
        Form2 f1;
        Form2 f2;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            f1 = new Form2(this, "Vasja");
            f2 = new Form2(this, "Olga");
            f1.Show();
            f2.Show();

            f1.Location = new Point(400, 50);
            f2.Location = new Point(50, 50);
            f1.Focus();
          
        }

        public void ChangeFocus()
        {
            if (focused == true)
            {
                f2.BackColor = DefaultBackColor;
                f1.BackColor = Color.Red; f1.Focus();
                foreach (var item in f1.Controls)
                {
                    if (item is TextBox)
                        (item as TextBox).Focus();
                }
               
                
            }
            else
            {
                f1.BackColor = DefaultBackColor;
                f2.BackColor = Color.Red; f2.Focus();
                foreach (var item in f2.Controls)
                {
                    if (item is TextBox)
                        (item as TextBox).Focus();
                }
            }
        }
    }
}
