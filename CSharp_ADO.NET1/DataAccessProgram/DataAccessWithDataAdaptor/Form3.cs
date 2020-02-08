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
    public partial class Form3 : Form
    {

        public Form3()
        {
            InitializeComponent();
        }
        string conString, qryString;
        SqlConnection sqlCon;
        SqlCommand sqlCmd;
        SqlDataAdapter da;
        SqlDataReader dr;
        DataSet ds;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            conString = "data source =BLT10132\\SQLEXPRESS2014;Initial" +
                            " Catalog=NorthWind;Integrated Security = True; ";

            using (sqlCon = new SqlConnection(conString))
            {
                sqlCmd = new SqlCommand();
                sqlCmd.CommandText = "getcustomerbycountry";
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Connection = sqlCon;

                SqlParameter param = new SqlParameter();
                param.ParameterName = "@country";
                param.DbType = DbType.String;
                param.Value = cmbCountries.Text;

                sqlCmd.Parameters.Add(param);
                da = new SqlDataAdapter(sqlCmd);
                ds.Clear();
                da.Fill(ds, "CustomersByCountry");
                gvCustomers.DataSource = ds;
                gvCustomers.DataMember = "CustomerByCountry";


            }

            private void Form3_Load(object sender, EventArgs e)
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
                    dr.close();







                }
            }
        }
    }
}