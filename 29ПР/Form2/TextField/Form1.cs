using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextField
{
    public partial class Form1 : Form
    {
        string login = "test";
        string password = "qwerty";
        SqlConnection connection;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text == login && txtPassw.Text == password)
            {
                using (connection = new SqlConnection())
                {
                    connection.ConnectionString = ConfigurationManager.ConnectionStrings["MyConnStr"].ConnectionString;
                    try
                    {
                        connection.Open();
                        lblCon.Text = "Conected";
                    }
                    catch {
                        lblCon.Text = "Failed";
                    }
                    
                }
            }
            else
            {
                lblCon.Text = "No such user";

            }
        }
    }
}
