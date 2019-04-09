using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Globalization;
using System.Threading;

namespace CultureExplorer
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TreeView treeView1;
		private System.Windows.Forms.Splitter splitter1;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Код культуры",
            ""}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "Имя на английском",
            ""}, -1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "Имя на родном языке",
            ""}, -1);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "Туп культуры",
            ""}, -1);
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new string[] {
            "Текущая дата (Кратко)",
            ""}, -1);
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem(new string[] {
            "Текущая дата (Подробно)",
            ""}, -1);
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem(new string[] {
            "Текущее время (Кратко)",
            ""}, -1);
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem(new string[] {
            "Текущее время (Подробно)",
            ""}, -1);
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem(new string[] {
            "Число (35,500.75)",
            ""}, -1);
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem(new string[] {
            "Валюта (1,750.25)",
            ""}, -1);
            System.Windows.Forms.ListViewItem listViewItem11 = new System.Windows.Forms.ListViewItem(new string[] {
            "Тип календаря",
            ""}, -1);
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.GridLines = true;
            listViewItem1.UseItemStyleForSubItems = false;
            listViewItem2.UseItemStyleForSubItems = false;
            listViewItem3.UseItemStyleForSubItems = false;
            listViewItem4.UseItemStyleForSubItems = false;
            listViewItem5.UseItemStyleForSubItems = false;
            listViewItem6.UseItemStyleForSubItems = false;
            listViewItem7.UseItemStyleForSubItems = false;
            listViewItem8.UseItemStyleForSubItems = false;
            listViewItem9.UseItemStyleForSubItems = false;
            listViewItem10.UseItemStyleForSubItems = false;
            listViewItem11.UseItemStyleForSubItems = false;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6,
            listViewItem7,
            listViewItem8,
            listViewItem9,
            listViewItem10,
            listViewItem11});
            this.listView1.Location = new System.Drawing.Point(192, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(337, 318);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Данные";
            this.columnHeader1.Width = 181;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Значения";
            this.columnHeader2.Width = 146;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView1.HideSelection = false;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(182, 318);
            this.treeView1.Sorted = true;
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(182, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(10, 318);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
            this.ClientSize = new System.Drawing.Size(529, 318);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.Text = "Culture Explorer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			TreeNode tempNode;

            // Добавляем к дереву нейтральные культуры, как корневые узлы
			foreach (CultureInfo CultureX in CultureInfo.GetCultures(CultureTypes.NeutralCultures))
			{
				tempNode = new TreeNode(CultureX.EnglishName + " [" + CultureX.Name + "]");
				tempNode.Tag = CultureX;
				treeView1.Nodes.Add(tempNode);
			}
            // Перебираем все конкретные культуры
            // и добавляем каждую из них к родительской нейтральной культуре в дереве
            foreach (CultureInfo CultureX in CultureInfo.GetCultures(CultureTypes.SpecificCultures))
            {
                foreach (TreeNode NodeX in treeView1.Nodes)
                {
                    if (NodeX.Tag.Equals(CultureX.Parent))
                    {
                        tempNode = new TreeNode(CultureX.EnglishName + " [" + CultureX.Name + "]");
                        tempNode.Tag = CultureX;
                        tempNode.ForeColor = Color.Red;
                        foreach (CultureInfo CultureY in CultureInfo.GetCultures(CultureTypes.InstalledWin32Cultures))
                        {
                            if (CultureY.Equals(CultureX))
                            {
                                tempNode.ForeColor = Color.Black;
                                break;
                            }
                        }
                        NodeX.Nodes.Add(tempNode);
                        break;
                    }
                }
            }
		}

		private void treeView1_AfterSelect(object sender, System.Windows.Forms.TreeViewEventArgs e)
		{
			CultureInfo selectedCulture;
			selectedCulture = (CultureInfo)treeView1.SelectedNode.Tag;
			if (selectedCulture.IsNeutralCulture == true)
			{
				listView1.Items[3].SubItems[1].Text = "Нейтральная";
				for (int x = 4; x <= 10; x++)
					listView1.Items[x].SubItems[1].Text = "Нейтральная культура";
			}
			else
			{
				Thread.CurrentThread.CurrentCulture = selectedCulture;
				listView1.Items[3].SubItems[1].Text = "Конкретная";
				listView1.Items[4].SubItems[1].Text = (DateTime.Now).ToShortDateString();
				listView1.Items[5].SubItems[1].Text = (DateTime.Now).ToLongDateString();
				listView1.Items[6].SubItems[1].Text = (DateTime.Now).ToShortTimeString();
				listView1.Items[7].SubItems[1].Text = (DateTime.Now).ToLongTimeString();
				listView1.Items[8].SubItems[1].Text = (35500.75).ToString("n");
				listView1.Items[9].SubItems[1].Text = (1750.25).ToString("c");
				listView1.Items[10].SubItems[1].Text = (selectedCulture.Calendar.ToString()).Remove(0,21);
			}
			listView1.Items[0].SubItems[1].Text = selectedCulture.Name;
			listView1.Items[1].SubItems[1].Text = selectedCulture.EnglishName;
			listView1.Items[2].SubItems[1].Text = selectedCulture.NativeName;
        }
	}
}
