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
            TreeNode rootNode = treeView1.Nodes.Add("����");

            TreeNode childNode = rootNode.Nodes.Add("������");
            childNode.Tag = "������ - ������� � ����� ���";

            childNode = rootNode.Nodes.Add("�����");
            childNode.Tag = "����� - ����� ���������� ���";

            childNode = rootNode.Nodes.Add("������");
            childNode.Tag = "������ - ������� ���";

            childNode = rootNode.Nodes.Add("�����");
            childNode.Tag = "����� - ����� � �������� ���";

            // ���������� ��� ���� ������
            rootNode.ExpandAll();
        }

        private void treeView1_MouseMove(object sender, MouseEventArgs e)
        {
            // ������� ���� � ������� ������� ����
            TreeNode theNode = this.treeView1.GetNodeAt(e.X, e.Y);

            // ��������� ToolTip, ������ ���� ���� ����������� �� ����
            if ((theNode != null))
            {
                // ���������, ��� �������� tag �� ������
                if (theNode.Tag != null)
                {
                    // ������ ToolTip, ���� ���� ������������� �� ������ ����
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
            else     // ���� ��������� �� ��� �����, �� ������� ���������
            {
                this.toolTip1.SetToolTip(this.treeView1, "");
            }
        }


    }
}