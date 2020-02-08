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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection sqlCon;
        SqlCommand sqlCmd;
        SqlDataReader dr;
        string conString, qryString;

        private void Form1_Load(object sender, EventArgs e)
        {
            //conString = "data source =BLT10132\\SQLEXPRESS2014;Initial" +
            //    " Catalog=NorthWind;Integrated Security = True; ";
            //    sqlCon = new SqlConnection(conString);
            //sqlCon.Open();
            //qryString = "Select ProductName from Products";
            //sqlCmd = new SqlCommand(qryString, sqlCon);
            //dr = sqlCmd.ExecuteReader();
            //while (dr.Read())
            //{
            //    CmbProducts.Items.Add(dr["ProductName"]);
            //}
            //dr.Close();
            //sqlCon.Close();
            //CmbProducts.Text = "All Products";
             }

        private void CmbProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            qryString = "select unitPrice from products where ProductName='" +
                CmbProducts.Text + " ' ";
            sqlCmd = new SqlCommand(qryString, sqlCon);
            sqlCon.Open();
            button2.Text = "unit price:" + sqlCmd.ExecuteScalar().ToString();
            sqlCon.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            conString = "data source =BLT10132\\SQLEXPRESS2014;Initial" +
                " Catalog=NorthWind;Integrated Security = True; ";
            sqlCon = new SqlConnection(conString);
            sqlCon.Open();
            qryString = "Select ProductName from Products";
            sqlCmd = new SqlCommand(qryString, sqlCon);
            dr = sqlCmd.ExecuteReader();
            while (dr.Read())
            {
                CmbProducts.Items.Add(dr["ProductName"]);
            }
            dr.Close();
            sqlCon.Close();
            CmbProducts.Text = "All Products";
        }

        private void lsbProduct_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            sqlCon.Open();
            qryString = "select productname from product";
            sqlCmd = new SqlCommand(qryString, sqlCon);
            dr = sqlCmd.ExecuteReader();
            while (dr.Read())
            {
                CmbProducts.Items.Add(dr["ProductName"]);
            }
            dr.Close();
            sqlCon.Close();

        }
    }
}

        
