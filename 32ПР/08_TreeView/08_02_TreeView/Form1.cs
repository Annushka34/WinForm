using Newtonsoft.Json;
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

namespace _08_02_TreeView
{
    public partial class Form1 : Form
    {
        string imgDir;
        TreeView tw;
        ImageList imageList;
        List<Product> source;
        public Form1()
        {
            InitializeComponent();
            string fullPathToExe = System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory());
            imgDir = Path.Combine(Directory.GetParent(fullPathToExe).Parent.Parent.FullName, @"img\");
            source = new List<Product>()
            {
              new Product{ Name = "Yougurt", Category = "Milk", ImgInd = 0, Price = 18}
            };
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tw = new TreeView();
            tw.SetBounds(20, 20, 360, 460);
            this.Controls.Add(tw);

            //--------------CREATE IMAGE LIST--------------
            imageList = new ImageList();
            imageList.Images.Add(Image.FromFile(imgDir + "1.png"));
            imageList.ImageSize = new Size(50, 30);
            imageList.ColorDepth = ColorDepth.Depth32Bit;

            //----------Connect TreeView with ImgList
            tw.ImageList = imageList;


            TreeNode root = new TreeNode("Products", 0, 0);
            tw.Nodes.Add(root);          
            tw.MouseClick += Tw_MouseClick;
            tw.MouseDoubleClick += Tw_MouseDoubleClick;


            using (StreamReader sw = new StreamReader(imgDir + "products.txt"))
            {
                string prodJsonStr = sw.ReadToEnd();
                source = (List<Product>)JsonConvert.DeserializeObject(prodJsonStr, typeof(List<Product>));
            }
            foreach (var item in source)
            {
                FillNode(root, item);
            }
        }
        void FillNode(TreeNode sel, Product p)
        {
            if (p.ImgPath != null)
            {
                TreeNode newNode = new TreeNode(p.Name);
                imageList.Images.Add(new Bitmap(p.ImgPath));
                p.ImgInd = imageList.Images.Count - 1;
                newNode.ImageIndex = p.ImgInd;
                newNode.SelectedImageIndex = p.ImgInd;
                sel.Nodes.Add(newNode);
            }
        }

        void CreateNewNode (TreeNode sel, Product p)
        {
            TreeNode newNode = new TreeNode(p.Name);
            openFileDialog1.InitialDirectory = imgDir;
            if ( openFileDialog1.ShowDialog() == DialogResult.OK )
            {
                imageList.Images.Add(new Bitmap(openFileDialog1.FileName));
            }
            p.ImgInd = imageList.Images.Count - 1;
            p.ImgPath = openFileDialog1.FileName;
            newNode.ImageIndex = p.ImgInd;
            newNode.SelectedImageIndex = p.ImgInd;
            source.Add(p);
            sel.Nodes.Add(newNode);
        }

        private void Tw_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (tw.SelectedNode != null)
            {
                Product selectedProduct = source.Where(x => x.Name == tw.SelectedNode.Text).FirstOrDefault();
                label1.Text = selectedProduct.Name;
                label2.Text = selectedProduct.Category;
                label3.Text = selectedProduct.Price.ToString();
                pictureBox1.Image = imageList.Images[selectedProduct.ImgInd];
            }
        }

        private void Tw_MouseClick(object sender, MouseEventArgs e)
        {
         
        }

        class Product
        {
            public string Name { get; set; }
            public int Price { get; set; }
            public string  Category { get; set; }
            public int ImgInd { get; set; }
            public string ImgPath { get; set; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tw.SelectedNode != null)
            {
                if (source.Any(x => x.Name == textBox1.Text))
                    MessageBox.Show("Cant create dublicate");
                else
                {
                    Product p = new Product { Name = textBox1.Text, Category = comboBox1.SelectedItem.ToString()};
                    CreateNewNode(tw.SelectedNode, p);
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            string products = JsonConvert.SerializeObject(source);
            using (StreamWriter sw = new StreamWriter(imgDir + "products.txt"))
            {
                sw.WriteLine(products);
            }
        }
    }
}
