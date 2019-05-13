using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14_UserControlComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAplly_Click(object sender, EventArgs e)
        {
            City selectedCity = myComboBox1.GetCity;
            lblSelectedRegion.Text = 
                String.Format("City Id {0} Name {1}, Region Id {2} Name {3}, Country Id {4} Name {5}",
                selectedCity.Id, selectedCity.Name, selectedCity.Region.Id, selectedCity.Region.Name,
                selectedCity.Region.Country.Id, selectedCity.Region.Country.Name);
        }
    }
}
