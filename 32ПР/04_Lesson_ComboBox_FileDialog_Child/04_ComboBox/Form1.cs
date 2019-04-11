using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_ComboBox
{
    public partial class Form1 : Form
    {
        Dictionary<string, List<string>> goods;
        public Form1()
        {
            InitializeComponent();
            cmbCateg.Items.Add("Крупи");
            goods = new Dictionary<string, List<string>>();
            goods["Крупи"] = new List<string> { "Рис", "Гречка", "Борошно" };
            goods["Молочні"] = new List<string> { "Творог", "Молоко","Йогурт","Сир" };
            goods["М'ясні"] = new List<string> { "Курятина" };
        }

        private void cmbCateg_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selected = goods.Where(x=>x.Key == cmbCateg.SelectedItem.ToString()).Select(x=>x.Value).FirstOrDefault();
            cmbGoods.Items.Clear();
            cmbGoods.Items.AddRange(selected.ToArray());
        }

        private void cmbGoods_SelectedIndexChanged(object sender, EventArgs e)
        {
           lblInfo.Text = (sender as ComboBox).SelectedItem.ToString();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            //groupBox1.Location = new Point(groupBox1.Location.X, vScrollBar1.Value * 2);
            button1.Location = new Point(button1.Location.X, vScrollBar1.Value * 2);
        }
    }
}
