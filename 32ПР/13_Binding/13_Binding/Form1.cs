using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13_Binding
{
    public partial class Form1 : Form
    {
        BindingSource bindingSource = new BindingSource();
        List<Person> people;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
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
            listBox1.DataSource = bindingSource;
            listBox2.DataSource = bindingSource;
            listBox2.DisplayMember = "Name";

            //textBox1.DataBindings.Add(new Binding("Text", bindingSource[0], "Name", true, DataSourceUpdateMode.OnPropertyChanged));
            //textBox2.DataBindings.Add(new Binding("Text", bindingSource[0], "Surname", true, DataSourceUpdateMode.OnPropertyChanged));
            //textBox3.DataBindings.Add(new Binding("Text", bindingSource[0], "Worker_type", true, DataSourceUpdateMode.OnPropertyChanged));
            //textBox4.DataBindings.Add(new Binding("Text", bindingSource[0], "Salary", true, DataSourceUpdateMode.OnPropertyChanged));

            textBox5.DataBindings.Add(new Binding("Text", listBox1, "selectedvalue"));
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            people.Add(new Person(textBox1.Text, textBox2.Text, textBox3.Text, "Magenta"));
            listBox1.DataSource = null;
            listBox1.DataSource = bindingSource;

            listBox2.DataSource = null;
            listBox2.DataSource = bindingSource;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                textBox1.DataBindings.Clear();
                textBox2.DataBindings.Clear();
                textBox3.DataBindings.Clear();
                textBox4.DataBindings.Clear();
                panel1.DataBindings.Clear();
                textBox1.DataBindings.Add(new Binding("Text", bindingSource[listBox1.SelectedIndex], "Name", true, DataSourceUpdateMode.OnPropertyChanged));
                textBox2.DataBindings.Add(new Binding("Text", bindingSource[listBox1.SelectedIndex], "Surname", true, DataSourceUpdateMode.OnPropertyChanged));
                textBox3.DataBindings.Add(new Binding("Text", bindingSource[listBox1.SelectedIndex], "Worker_type", true, DataSourceUpdateMode.OnPropertyChanged));
                textBox4.DataBindings.Add(new Binding("Text", bindingSource[listBox1.SelectedIndex], "Salary", true, DataSourceUpdateMode.OnPropertyChanged));
                panel1.DataBindings.Add(new Binding("BackColor", bindingSource[listBox1.SelectedIndex], "Color", true, DataSourceUpdateMode.OnPropertyChanged));
            }
        }
    }
}
