using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_TreeView
{
    public partial class Form1 : Form
    {
        TreeView tw = null;
        string path = @"D:\ШАГ\PICTURES\";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tw = new TreeView();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            ImageList imgs = new ImageList();
            imgs.ImageSize = new Size(30, 40);
            imgs.ColorDepth = ColorDepth.Depth32Bit;

            for (int i = 1; i <= 5; i++)
            {
                imgs.Images.Add(new Bitmap(path + i.ToString() + ".jpg"));
            }

            tw.SetBounds(10, 10, 350, 200);

            this.Controls.Add(tw);

            TreeNode root = new TreeNode("root");
            tw.Nodes.Add(root);

            int indPicture = 1;

            for (int i = 0; i < 10; i++)
            {
            TreeNode nodeChild1 = new TreeNode("child1", indPicture, indPicture+1);
                
                root.Nodes.Add(nodeChild1);
                indPicture++;
                if (indPicture == 4) indPicture = 1;
            }
            tw.MouseClick += Tw_MouseClick;
            tw.MouseDoubleClick += Tw_MouseDoubleClick;


            //----Додаємо картинки---
           
            tw.ImageList = imgs;
            tw.SelectedImageIndex = 2;          
          
        }

        private void Tw_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (tw.SelectedNode.Nodes != null)
                    tw.SelectedNode.Remove();
            }
        }

        private void Tw_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                TreeNode newNode = new TreeNode("newNode");
                //if(tw.SelectedNode.IsSelected == true)
                tw.SelectedNode.Nodes.Add(newNode);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tw.SelectedNode.Nodes.Add(new TreeNode(textBox1.Text, 4, 2));
        }
    }
}
