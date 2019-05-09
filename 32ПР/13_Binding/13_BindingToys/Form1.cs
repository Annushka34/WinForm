using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13_BindingToys
{
    public partial class Form1 : Form
    {
        List<Toy> toys;
        BindingSource bindingSource = new BindingSource();
        int selectedInd = -1;
        bool isEdited = false;
        public Form1()
        {
            InitializeComponent();
            tableLayoutPanel1.ColumnStyles[1].Width = 0;

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            toys = new List<Toy>
            {
                new Toy{ Name = "Car", Age=8, Price = 120}
            };
            bindingSource.DataSource = toys;
            dataGridView1.DataSource = bindingSource;

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //// Automatically resize the visible rows.
            dataGridView1.AutoSizeRowsMode =
                DataGridViewAutoSizeRowsMode.AllCells;
            //// Set the DataGridView control's border.
            dataGridView1.BorderStyle = BorderStyle.None;
            //// Put the cells in edit mode when user enters them.
            dataGridView1.EditMode = DataGridViewEditMode.EditOnEnter;
            dataGridView1.CellMouseClick += DataGridView1_CellMouseClick;
            dataGridView1.MultiSelect = false;
        }

        private void DataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            selectedInd = dataGridView1.SelectedRows[0].Index;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            isEdited = true;
            tableLayoutPanel1.ColumnStyles[1].Width = 60;
            if (selectedInd != -1)
            {
                textBox1.DataBindings.Clear();
                textBox2.DataBindings.Clear();
                textBox3.DataBindings.Clear();
                textBox1.DataBindings.Add("Text", bindingSource[selectedInd], "Name");
                textBox2.DataBindings.Add("Text", bindingSource[selectedInd], "Age");
                textBox3.DataBindings.Add("Text", bindingSource[selectedInd], "Price");
            }
            else
            {

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.ColumnStyles[1].Width = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.ColumnStyles[1].Width = 0;
            bindingSource.DataSource = null;
            bindingSource.DataSource = toys;
        }
        Toy toy = null;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            isEdited = false;
            tableLayoutPanel1.ColumnStyles[1].Width = 60;
            toy = new Toy();
            textBox1.DataBindings.Clear();
            textBox2.DataBindings.Clear();
            textBox3.DataBindings.Clear();
            textBox1.DataBindings.Add("Text", toy, "Name");
            textBox2.DataBindings.Add("Text", toy, "Age");
            textBox3.DataBindings.Add("Text", toy, "Price");
           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (toy != null && !isEdited)
                toys.Add(toy);
        
            bindingSource.DataSource = null;
            bindingSource.DataSource = toys;
            tableLayoutPanel1.ColumnStyles[1].Width = 0;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (selectedInd != -1)
            {
                toys.RemoveAt(selectedInd);
                bindingSource.DataSource = null;
                bindingSource.DataSource = toys;
            }
            }
    }
}
