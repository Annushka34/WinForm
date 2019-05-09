using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13_BindingControls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.DataBindings.Add(new Binding("BackColor", textBox2, "Text", true, DataSourceUpdateMode.OnPropertyChanged));
            textBox1.DataBindings.Add(new Binding("Text", textBox2, "Text", true, DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new Binding("Height", numericUpDown1, "Value", true, DataSourceUpdateMode.OnPropertyChanged));
        }
    }
}
