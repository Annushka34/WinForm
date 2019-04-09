using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace TreeViewDirectory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // ��������� ������ ����. ���������� ���� C:
            TreeNode rootNode = new TreeNode(@"C:\");
            treeDirectory.Nodes.Add(rootNode);
            // ���������� ������ ������� � ���������� ���
            FillNodes(rootNode);
            treeDirectory.Nodes[0].Expand();
            // ��������� ������ ����. ���������� ���� D:
            TreeNode rootNode2 = new TreeNode(@"D:\");
            treeDirectory.Nodes.Add(rootNode2);
            FillNodes(rootNode2);
            // �� ����� ���������� ���
            //treeDirectory.Nodes[1].Expand();
        }

        private void FillNodes(TreeNode dirNode)
        {
            DirectoryInfo dir = new DirectoryInfo(dirNode.FullPath);

            foreach (DirectoryInfo dirItem in dir.GetDirectories())
            {
                // ��������� ���� ��� ������ �����
                TreeNode newNode = new TreeNode(dirItem.Name);
                dirNode.Nodes.Add(newNode);
                newNode.Nodes.Add("*");
            }


        }

        private void treeDirectory_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            // ���� ������ ���� �� ���������� *, �� ������� ���
            // � �������� ������ ��������.
            if (e.Node.Nodes[0].Text == "*")
            {
                e.Node.Nodes.Clear();
                FillNodes(e.Node);
            }
        }
    }
}