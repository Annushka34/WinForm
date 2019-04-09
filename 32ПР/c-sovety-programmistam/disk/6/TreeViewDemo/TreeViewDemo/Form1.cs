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
            // Create a root node.
            TreeNode rootNode = treeView1.Nodes.Add("Коты");

            TreeNode childNode = rootNode.Nodes.Add("Барсик");
            childNode.Tag = "Барсик - большой и умный кот";

            childNode = rootNode.Nodes.Add("Рыжик");
            childNode.Tag = "Рыжик - очень любопытный кот";

            childNode = rootNode.Nodes.Add("Мурзик");
            childNode.Tag = "Мурзик - ленивый кот";

            childNode = rootNode.Nodes.Add("Пушок");
            childNode.Tag = "Пушок - белый и пушистый кот";

            // Раскрываем все узлы дерева
            rootNode.ExpandAll();
        }

        private void treeView1_MouseMove(object sender, MouseEventArgs e)
        {
            // Получим узел в текущей позиции мыши
            TreeNode theNode = this.treeView1.GetNodeAt(e.X, e.Y);

            // Установим ToolTip, только если мышь задержалась на узле
            if ((theNode != null))
            {
                // Проверяем, что свойство tag не пустое
                if (theNode.Tag != null)
                {
                    // Меняем ToolTip, если мышь переместилась на другой узел
                    if (theNode.Tag.ToString() != this.toolTip1.GetToolTip(this.treeView1))
                    {
                        this.toolTip1.SetToolTip(this.treeView1, theNode.Tag.ToString());
                    }
                }
                else
                {
                    this.toolTip1.SetToolTip(this.treeView1, "");
                }
            }
            else     // Если указатель не над узлом, то очистим подсказку
            {
                this.toolTip1.SetToolTip(this.treeView1, "");
            }
        }


    }
}