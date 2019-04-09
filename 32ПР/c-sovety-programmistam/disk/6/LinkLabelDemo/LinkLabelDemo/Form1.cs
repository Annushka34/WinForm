using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lnkSearchUrl.Text = "Yandex Google Rambler GoGo";
            lnkSearchUrl.LinkBehavior = LinkBehavior.HoverUnderline;
            lnkSearchUrl.Links.Add(0, 6, "www.yandex.ru");
            lnkSearchUrl.Links.Add(7, 6, "www.google.ru");
            lnkSearchUrl.Links.Add(14, 7, "www.rambler.ru");
            lnkSearchUrl.Links.Add(22, 4, "www.gogo.ru");
            lnkSearchUrl.LinkClicked += 
                new LinkLabelLinkClickedEventHandler(lnkCommon_LinkClicked);
            
        }

        private void lnkMySite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://rusproject.narod.ru/");
        }

        private void lnkCommon_LinkClicked(object sender,
            LinkLabelLinkClickedEventArgs e)
        {
            LinkLabel lnk = new LinkLabel();
            lnk = (LinkLabel)sender;
            lnk.Links[lnk.Links.IndexOf(e.Link)].Visited = true;
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }
    }
}