using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14_UserControlComboBox
{
    public partial class MyComboBox : UserControl
    {
        List<Country> countries = null;
        List<Region> regions = null;
        List<City> cities = null;

        City selectedCity = null;
        public MyComboBox()
        {
            InitializeComponent();
        }

        private void MyComboBox_Load(object sender, EventArgs e)
        {
            countries = new List<Country>
            {
                new Country { Id = 1, Name = "Ukraine"},
                new Country { Id = 2, Name = "Poland"},
                new Country { Id = 3, Name = "Italy"},
                new Country { Id = 4, Name = "Russia"}
            };
            cmbCountry.DataSource = countries;
            cmbCountry.ValueMember = "Id";
            cmbCountry.DisplayMember = "Name";


            regions = new List<Region>
            {
                new Region { Id = 1, Name = "Рівненська", CountryId = 1, Country = countries.Where(x=>x.Id==1).FirstOrDefault()},
                new Region { Id = 2, Name = "Хмельницька", CountryId = 1, Country = countries.Where(x=>x.Id==1).FirstOrDefault()},
                new Region { Id = 3, Name = "Мазовецьке", CountryId = 2, Country = countries.Where(x=>x.Id==2).FirstOrDefault()},
                new Region { Id = 4, Name = "Нижньосілезьке", CountryId = 2, Country = countries.Where(x=>x.Id==2).FirstOrDefault()}
            };
            cmbRegion.DataSource = regions.Where(x=>x.Country == (Country)cmbCountry.SelectedItem).ToList();
            cmbRegion.ValueMember = "Id";
            cmbRegion.DisplayMember = "Name";


            cities = new List<City>
            {
                new City { Id = 1, Name = "Рівне", RegionId = 1, Region = regions.Where(x=>x.Id== 1).FirstOrDefault()},
                new City { Id = 2, Name = "Остріг", RegionId = 1, Region = regions.Where(x=>x.Id== 1).FirstOrDefault()},
                new City { Id = 3, Name = "Здолбунів", RegionId = 1, Region = regions.Where(x=>x.Id== 1).FirstOrDefault()},
                new City { Id = 4, Name = "Вроцлав", RegionId = 3, Region = regions.Where(x=>x.Id== 3).FirstOrDefault()},
                new City { Id = 5, Name = "Варшава", RegionId = 4, Region = regions.Where(x=>x.Id== 4).FirstOrDefault()}
            };
            cmbCity.DataSource = cities.Where(x=>x.Region == (Region)cmbRegion.SelectedItem).ToList();
            cmbCity.ValueMember = "Id";
            cmbCity.DisplayMember = "Name";
        }

      

        private void btnApply_Click(object sender, EventArgs e)
        {

        }

        private void cmbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(regions != null)
            cmbRegion.DataSource = regions.Where(x => x.Country == (Country)cmbCountry.SelectedItem).ToList();
        }

        private void cmbRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cities != null)
                cmbCity.DataSource = cities.Where(x => x.Region == (Region)cmbRegion.SelectedItem).ToList();
        }

        private void cmbCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedCity = (City)cmbCity.SelectedItem;
        }

        public City GetCity
        {
            get
            {
                return selectedCity;
            }
        }
    }

    public class Country
    {
        public int Id { get; set; }
        public string  Name { get; set; }
    }

    public class Region
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }
    }

    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int RegionId { get; set; }
        public Region Region { get; set; }
    }
}
