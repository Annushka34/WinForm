using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05_TabControl
{
    public partial class Form1 : Form
    {
        TabControl tabControl = new TabControl();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tabControl.Dock = DockStyle.Fill;
            this.Controls.Add(tabControl);
            tabControl.MouseClick += TabControl_MouseClick;

            TabPage page1 = new TabPage("Google");
            TabPage page2 = new TabPage("+");

            MyTextBox textBox1 = new MyTextBox();
            page1.Controls.Add(textBox1);

            MyTextBox textBox2 = new MyTextBox();
            page2.Controls.Add(textBox2);

            tabControl.TabPages.Add(page1);
            tabControl.TabPages.Add(page2);
        }

        private void TabControl_MouseClick(object sender, MouseEventArgs e)
        {
            int indexClicedPage = tabControl.SelectedIndex;
            TabPage clickedPage = tabControl.TabPages[indexClicedPage];

            if(indexClicedPage == tabControl.TabPages.Count-1)
            {
                clickedPage.Text = "Google";
                TabPage page = new TabPage("+");
                page.Controls.Add(new MyTextBox());
                tabControl.TabPages.Add(page);
            }
        }
    }

    class MyTextBox: TextBox
    {
        public MyTextBox()
        {
            this.Dock = DockStyle.Fill;
            this.Multiline = true;
            this.BackColor = Color.AliceBlue;
        }
    }
}
