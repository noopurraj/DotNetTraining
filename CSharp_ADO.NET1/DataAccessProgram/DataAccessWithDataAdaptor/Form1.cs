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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string conString, qryString;
        SqlConnection sqlCon;
        SqlCommand sqlCmd;
        SqlDataAdapter da;
        DataSet ds;

        private void btnProducts_Click(object sender, EventArgs e)
        {
            qryString = "Select ProductID,ProductName,UnitPrice,QuantityPerUnit,CategoryID from Products";
            sqlCmd = new SqlCommand(qryString, sqlCon);

            da = new SqlDataAdapter(sqlCmd);
            // ds = new DataSet();
            ds.Clear();
            da.Fill(ds, "ProductInfo");
            gvProducts.DataSource = ds;
            gvProducts.DataMember = "ProductInfo";
        }

        private void btnCatagories_Click(object sender, EventArgs e)
        {
            qryString = "Select * from Categories";
            sqlCmd = new SqlCommand(qryString, sqlCon);
            da = new SqlDataAdapter(sqlCmd);
            da.Fill(ds, "catagoriesInfo");
            gvProducts.DataSource = ds;
            gvProducts.DataMember = "catagoriesInfo";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conString = "data source =BLT10132\\SQLEXPRESS2014;Initial" +
                  " Catalog=NorthWind;Integrated Security = True; ";
            sqlCon = new SqlConnection(conString);
            ds = new DataSet();
        }
    }
}
