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

namespace DataAccessProgram
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
        SqlDataReader dr;

        private void cmbProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            qryString = "select UnitPrice from Products Where ProductName = '" +cmbProducts.Text + " ' ";
            sqlCmd = new SqlCommand(qryString, sqlCon);
            sqlCon.Open();
            lblPrice.Text = "Price: " + sqlCmd.ExecuteScalar().ToString();
            sqlCon.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            qryString = "Update Products Set UnitPrice = " + Convert.ToDouble(txtPrice.Text) + "Where ProductName='" + cmbProducts.Text + " ' ";
            sqlCmd = new SqlCommand(qryString, sqlCon);
            sqlCon.Open();
            sqlCmd.ExecuteNonQuery();
            MessageBox.Show("Product Updated", "New Product Price:");
            sqlCon.Close();     
               
        }

        private void lblPrice_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            conString = "data source =BLT10132\\SQLEXPRESS2014;Initial" +
               " Catalog=NorthWind;Integrated Security = True; ";
            sqlCon = new SqlConnection(conString);

            sqlCon.Open();
            qryString = "select ProductName from Products";

            sqlCmd = new SqlCommand(qryString, sqlCon);
            dr = sqlCmd.ExecuteReader();
            while (dr.Read())
            {
                cmbProducts.Items.Add(dr["ProductName"]);
            }
            dr.Close();
            sqlCon.Close();
        }
    }
}
