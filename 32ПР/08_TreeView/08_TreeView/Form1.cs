using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _08_TreeView
{
    public partial class Form1 : Form
    {
        string imgDir;
        TreeView tw;
        ImageList imageList;
        public Form1()
        {
            InitializeComponent();
            string fullPathToExe = System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory());
            imgDir = Path.Combine(Directory.GetParent(fullPathToExe).Parent.Parent.FullName, @"img\");          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Tw_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && tw.SelectedNode != null)
            {
                tw.LabelEdit = true;
                tw.SelectedNode.EndEdit(true);
            }
            if (e.Button == MouseButtons.Right && tw.SelectedNode != null)
            {
                if ( MessageBox.Show("Do you want to delete "+ tw.SelectedNode.Text, "DELETE", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                        tw.Nodes.Remove(tw.SelectedNode);
                }
            }
        }
                private void Tw_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                TreeNode sel = tw.SelectedNode;
                if (sel != null)
                {
                    TreeNode copy = (TreeNode)sel.Clone();
                    if (sel.Parent != null)
                    {
                        TreeNode parent = sel.Parent;
                        parent.Nodes.Add(copy);

                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tw = new TreeView();
            tw.SetBounds(20, 20, 360, 460);
            this.Controls.Add(tw);

            //--------------CREATE IMAGE LIST--------------
            imageList = new ImageList();
            imageList.Images.Add(Image.FromFile(imgDir + "1.png"));
            imageList.Images.Add(new Bitmap(imgDir + "2.png"));
            imageList.Images.Add(new Bitmap(imgDir + "3.png"));
            //il.Images.Add(new Bitmap(path + "4.png"));
            //il.Images.Add(new Bitmap(path + "5.png"));
            imageList.ImageSize = new Size(50, 30);
            imageList.ColorDepth = ColorDepth.Depth32Bit;

            //----------Connect TreeView with ImgList
            tw.ImageList = imageList;


            TreeNode root = new TreeNode("root", 0, 1);
            tw.Nodes.Add(root);

            TreeNode[] chils = new TreeNode[5];
            chils[0] = new TreeNode("child 1", 2, 1);
            chils[1] = new TreeNode("child 2", 2, 1);
            chils[2] = new TreeNode("child 3", 2, 1);
            chils[3] = new TreeNode("child 4", 2, 1);
            chils[4] = new TreeNode("child 5", 2, 1, new TreeNode[] { new TreeNode("child_child", 0, 1) });
            root.Nodes.AddRange(chils);

            TreeNode copy = (TreeNode)root.Clone();
            tw.Nodes.Add(copy);

            tw.MouseClick += Tw_MouseClick;
            tw.MouseDoubleClick += Tw_MouseDoubleClick;

            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && tw.SelectedNode != null)
            {
                string text = textBox1.Text;
                TreeNode newNode = new TreeNode(text, 2, 1);
                tw.SelectedNode.Nodes.Add(newNode);
            }
        }
    }
}
