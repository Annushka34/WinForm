using _13_Binding;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13_DataGridView
{
    public partial class Form1 : Form
    {
        List<Person> people;
        public Form1()
        {
            InitializeComponent();
        }

        DataGridView dataGridView1 = new DataGridView();
        BindingSource bindingSource = new BindingSource();
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Controls.Add(dataGridView1);

            // Set up the DataGridView.
            dataGridView1.Dock = DockStyle.Fill;

            // Automatically generate the DataGridView columns.
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            //// Automatically resize the visible rows.
            dataGridView1.AutoSizeRowsMode =
                DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;

            //// Set the DataGridView control's border.
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;

            //// Put the cells in edit mode when user enters them.
            dataGridView1.EditMode = DataGridViewEditMode.EditOnEnter;

            dataGridView1.CellMouseClick += DataGridView1_CellMouseClick;
            dataGridView1.MultiSelect = false;


            people = new List<Person>
            {
                new Person("Vasja","Pupkin","Progammer", "Red"),
                new Person("Olga","Pupkin","Progammer", "Pink"),
                new Person("Sveta","Pupkin","Progammer", "Green"),
                new Person("Kolja","Pupkin","Progammer", "Violet"),
                new Person("Ivan","Pupkin","Progammer", "Orange"),
                new Person("Semen","Pupkin","Progammer", "Brown")
            };
            bindingSource.DataSource = people;
            dataGridView1.DataSource = bindingSource;
        }

        private void DataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(dataGridView1.SelectedRows.Count != 0)
          textBox1.Text =  dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            people.Add(new Person("111", "111", "111", "Brown"));
           // dataGridView1.Refresh();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = bindingSource;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                people.RemoveAt(dataGridView1.SelectedRows[0].Index);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = bindingSource;
            }
        }
    }
}
