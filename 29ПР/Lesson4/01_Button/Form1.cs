using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_Button
{
    public partial class Form1 : Form
    {
       

        static int countStyles = 3;
        ToolStripMenuItem[] itemsUA = new ToolStripMenuItem[countStyles];
        ToolStripMenuItem[] itemsEN = new ToolStripMenuItem[countStyles];
        string path = @"D:\ШАГ\forms\ПрикладиЗКласу\Lesson4\img\";
        Color old; 
        public Form1()
        {
            InitializeComponent();
            old = this.BackColor;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MainMenuStrip = menuStrip1;
            menuStrip2.Visible = false;

            for (int i = 0; i < countStyles; i++)
            {
                itemsEN[i] = new ToolStripMenuItem();
                itemsUA[i] = new ToolStripMenuItem();
                itemsEN[i].CheckOnClick = true;
                itemsUA[i].CheckOnClick = true;
                itemsUA[i].Click += Form1_Click;
                itemsEN[i].Click += Form1_Click;
            }

            itemsEN[1].Checked = true;
            itemsUA[1].Checked = true;
            itemsEN[0].Text = "Red";
            itemsEN[1].Text = "Normal";
            itemsEN[2].Text = "Picture";
            itemsUA[0].Text = "Червоний";
            itemsUA[1].Text = "Звичайний";
            itemsUA[2].Text = "Картинка";

            стильToolStripMenuItem.DropDownItems.AddRange(itemsUA);
            styleToolStripMenuItem.DropDownItems.AddRange(itemsEN);

            ImageList imgs = new ImageList();
            imgs.ImageSize = new Size(8, 8);
            imgs.Images.Add(new Bitmap(path+"1.png"));
            imgs.Images.Add(new Bitmap(path + "2.png"));
            imgs.Images.Add(new Bitmap(path + "3.png"));


            menuStrip1.ImageList = imgs;
            menuStrip2.ImageList = imgs;

            for(int i = 0; i < menuStrip1.Items.Count; i++)
            {
                menuStrip1.Items[i].ImageIndex = i;
                menuStrip2.Items[i].ImageIndex = i;
            }
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem clicked = (ToolStripMenuItem)sender;
            int index = 0;
            for (int i = 0; i < countStyles; i++)
            {
                if (itemsEN[i] == clicked || itemsUA[i] == clicked)
                {
                    itemsEN[i].Checked = true;
                    itemsUA[i].Checked = true;
                    index = i;
                }
                else
                {
                    itemsEN[i].Checked = false;
                    itemsUA[i].Checked = false;
                }
                switch(index)
                {
                    case 0:
                        this.BackgroundImage = null;
                        this.BackColor = Color.Red;
                        break;
                    case 1:
                        this.BackgroundImage = null;
                        this.BackColor = old;
                        break;
                    case 2:
                        this.BackgroundImage = new Bitmap(path + "back1.jpg");
                        break;
                }
            }
        }
       
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (btnLang.Checked == true)
            {
                btnLang.Text = "EN";
                menuStrip1.Visible = false;
                menuStrip2.Visible = true;
            }
            else
            {
                btnLang.Text = "UA";
                menuStrip1.Visible = true;
                menuStrip2.Visible = false;
            }
        }

    }
}
