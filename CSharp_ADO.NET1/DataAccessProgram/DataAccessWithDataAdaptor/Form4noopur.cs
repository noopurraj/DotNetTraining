using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DataAccessWithDataAdaptor
{
    public partial class Form4noopur : Form
    {
        string conString, qryString;
        SqlConnection sqlCon;
        SqlCommand sqlCmd;
        SqlDataAdapter da;
        SqlDataReader dr;
        DataSet ds;
        public Form4noopur()
        {
            InitializeComponent();
        }

        private void Form4noopur_Load(object sender, EventArgs e)
        {
            conString = "data source =BLT10132\\SQLEXPRESS2014;Initial" +
                           " Catalog=NorthWind;Integrated Security = True; ";
            sqlCon = new SqlConnection(conString);
            ds = new DataSet();
            using (sqlCon = new SqlConnection(conString))
            {
                sqlCon.Open();
                qryString = "select distinct Country from Customers";
                sqlCmd = new SqlCommand(qryString, sqlCon);

                dr = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dr.Read())
                {
                    cmbCountries.Items.Add(dr["country"]);
                }
                dr.Close();
                sqlCon.Close();
            }
        }
    }
}

