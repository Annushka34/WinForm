using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10_TabControls
{
    public partial class Form1 : Form
    {
        public static TabControl tabs = new TabControl();
        SplitContainer splitContainer = new SplitContainer();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TextBox txt = new TextBox();
            txt.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            txt.Width = this.Width - 20;
            Controls.Add(txt);
            txt.KeyDown += Txt_KeyDown;
            tabs.SetBounds(0, 25, this.Width-18, this.Height - 100);
            tabs.Alignment = TabAlignment.Top;
            tabs.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            MyPage page1 = new MyPage("1");
            tabs.TabPages.Add(page1);
           


            TabPage page2 = new TabPage("Add new");
            page2.BackColor = Color.Red;
            tabs.TabPages.Add(page2);

            Button msg = new Button { Text = "msg" };
            msg.SetBounds(80, 80, 30, 20);
            msg.Click += delegate { splitContainer.Panel2Collapsed = !splitContainer.Panel2Collapsed; };

            
            splitContainer.Dock = DockStyle.Fill;
            splitContainer.Orientation = Orientation.Horizontal;
            TextBox txt2 = new TextBox();
            splitContainer.Panel1.Controls.Add(txt2);
            splitContainer.Panel1.Controls.Add(msg);

            splitContainer.Panel2.BackColor = Color.Pink;
            page2.Controls.Add(splitContainer);

            MyPage page3 = new MyPage("+");
            tabs.TabPages.Add(page3);

            Controls.Add(tabs);

            tabs.Click += Tabs_Click;
        }


        private void Txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if ((sender as TextBox).Text != "")
                {
                    tabs.SelectedTab.Text = (sender as TextBox).Text;
                }
            }
        }

        private void Tabs_Click(object sender, EventArgs e)
        {
            if (tabs.SelectedTab.Text == "+")
            {
                tabs.TabPages.Add(new MyPage("+"));
                tabs.SelectedTab.Text = "Google";
            }
        }
    }

    class MyPage :TabPage
    {
        public MyPage(string text)
        {         
            this.Text = text;
            TextBox txt = new TextBox();
            txt.Multiline = true;   
            this.BackColor = Color.Gray;
            txt.Dock = DockStyle.Top | DockStyle.Bottom;
            txt.Width = Form1.tabs.ClientRectangle.Width-10;
            txt.Height = Form1.tabs.ClientRectangle.Height - 300;
            this.Controls.Add(txt);

            Button b = new Button();
            b.Dock = DockStyle.Top;
            b.Text = "Open";
            b.BackColor = Color.AliceBlue;
            this.Controls.Add(b);
            b.Click += B_Click;
            

            Button b1 = new Button();
            b1.Dock = DockStyle.Top;
            b1.Text = "Close";
            b1.BackColor = Color.AliceBlue;
            this.Controls.Add(b1);
            b1.Click += B1_Click;
        }
        //----tabs = TabControl container
        private void B_Click(object sender, EventArgs e)
        {
            Form1.tabs.SelectTab(1);
        }

        private void B1_Click(object sender, EventArgs e)
        {
            Form1.tabs.TabPages.Remove(Form1.tabs.SelectedTab);
        }
    }
}
