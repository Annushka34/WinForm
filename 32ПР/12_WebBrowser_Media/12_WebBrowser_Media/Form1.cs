using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12_WebBrowser_Media
{
    public partial class Form1 : Form
    {
        string homePage;
        string uri;
        Rectangle closeRec = new Rectangle(80, 5, 7, 7);
        public Form1()
        {
            InitializeComponent();
            homePage = @"https://www.google.com";
            WindowState = FormWindowState.Maximized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WebBrowser browser = new WebBrowser();
            browser.Dock = DockStyle.Fill;
            tabControl1.TabPages[0].Controls.Add(browser);
            browser.Navigate(new Uri(homePage));
            textBox1.Text = homePage;
            tabControl1.TabPages[0].Text = browser.DocumentTitle;

            tabControl1.DrawMode = TabDrawMode.OwnerDrawFixed;
            tabControl1.DrawItem += tabControl1_DrawItem;
        }
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                NavigatePage();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            NavigatePage();
        }
        private void NavigatePage()
        {
            uri = CheckUri(textBox1.Text);
            WebBrowser currentBrowser = (WebBrowser)tabControl1.SelectedTab.Controls[0];
            currentBrowser.Navigate(new Uri(uri));
            currentBrowser.Navigated += CurrentBrowser_Navigated;
        }

        private void CurrentBrowser_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            WebBrowser currentBrowser = (WebBrowser)tabControl1.SelectedTab.Controls[0];
            tabControl1.SelectedTab.Text = currentBrowser.DocumentTitle + "   ";
        }

        private string CheckUri(string uri)
        {
            if (!uri.Contains("http://www") && !uri.Contains("https://www"))
            {
                uri = "https://www." + uri;
                textBox1.Text = uri;
            }
            else if (!uri.Contains("http"))
            {
                uri = "https://" + uri;
                textBox1.Text = uri;
            }
            return uri;
        }

        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            //e.Index - selected tab
            //  MessageBox.Show(e.Index.ToString());
            //Rectangle rec = tabControl1.GetTabRect(e.Index);
            //MessageBox.Show(rec.X.ToString());
            Image closeImg = new Bitmap(this.GetType(), "delete.ico");
            Image small = new Bitmap(closeImg, new Size(7, 7));
            //Graphics g = e.Graphics;
            //g.DrawImage(closeImg, rec.Width - 2, rec.Height - 2, 7, 7);


            Rectangle r = e.Bounds;

            r = this.tabControl1.GetTabRect(e.Index);
            r.Offset(2, 2);


            Brush TitleBrush = new SolidBrush(Color.Black);
            Font f = this.tabControl1.Font;
            string title = this.tabControl1.TabPages[e.Index].Text;

            e.Graphics.DrawString(title, f, TitleBrush, new PointF(r.X, r.Y));
            if (title == "    +")
                return;

            e.Graphics.DrawImage(small, new Point(r.X + (this.tabControl1.GetTabRect(e.Index).Width -
                15), 5));
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab.Text == "+")
            {
                WebBrowser browser = new WebBrowser();
                browser.Dock = DockStyle.Fill;
                tabControl1.SelectedTab.Controls.Add(browser);
                textBox1.Text = homePage;
                NavigatePage();
                TabPage newPage = new TabPage("+");
                tabControl1.TabPages.Add(newPage);
            }
        }

      

        private void tabControl1_MouseClick(object sender, MouseEventArgs e)
        {
            Rectangle r = this.tabControl1.GetTabRect(tabControl1.SelectedIndex);
            r.Offset(2, 2);
            Rectangle close = new Rectangle(r.Width-7, 0, r.X + (this.tabControl1.GetTabRect(tabControl1.SelectedIndex).Width - 5), 10);
            if (close.Contains(e.Location))
            {
                MessageBox.Show("Close");
                tabControl1.TabPages.RemoveAt(tabControl1.SelectedIndex);
            }
        }
    }
}
