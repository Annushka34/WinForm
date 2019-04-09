using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_ListView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {        
            
            ListView lw = new ListView();
            lw.Location = new Point(10, 10);
            lw.Size = new Size(500, 300);
            lw.View = View.Tile;
            lw.FullRowSelect = true;


            ImageList img = new ImageList();
            img.Images.Add(new Bitmap(@"D:\ШАГ\PICTURES\1.jpg"));
            img.Images.Add(new Bitmap(@"D:\ШАГ\PICTURES\2.jpg"));
            img.Images.Add(new Bitmap(@"D:\ШАГ\PICTURES\3.jpg"));

            lw.SmallImageList = img;
            lw.LargeImageList = img;

            lw.Columns.Add("Name", 100);
            lw.Columns.Add("Color", 100);
            lw.Columns.Add("Price", 100);

            ListViewItem item1 = new ListViewItem();
            item1.Text = "Mersedes";            
            item1.SubItems.Add("Red");
            item1.SubItems.Add("1000000");
            lw.Items.Add(item1);
            item1.ImageIndex = 0;


            ListViewItem item2 = new ListViewItem();
            item2.Text = "Shkoda";
            item2.SubItems.Add("Red");
            item2.SubItems.Add("1005000");
            lw.Items.Add(item2);
            item2.ImageIndex = 1;


          



            this.Controls.Add(lw);
        }
    }
}
