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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection sqlCon;
        SqlCommand sqlCmd;
        SqlDataAdapter da;
        SqlDataReader dr;
        DataSet ds;
        string conString, qryString;

        private void cmbCountries_SelectedIndexChanged(object sender, EventArgs e)
        {
            qryString = "Select * from Customers Where Country = '" + cmbCountries.Text + " ' ";
            sqlCmd = new SqlCommand(qryString, sqlCon);

            ds = new DataSet();

            da = new SqlDataAdapter(sqlCmd);
            //ds.Clear();
            da.Fill(ds, "CustomersInfo");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "CustomersInfo";

        }

        private void btnCustomersAndOrders_Click(object sender, EventArgs e)
        {
            qryString = "Select c.CustomerID,c.CompanyName,c.ContactName,c.Address,c.Country,o.OrderID,o.OrderDate,o.ShippedDate from Customers c Join Orders o ON o.CustomerID= c.CustomerID";
            sqlCmd = new SqlCommand(qryString, sqlCon);

            da = new SqlDataAdapter(sqlCmd);
            da.Fill(ds, "customersordersInfo");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "CustomersOrdersInfo";
        }

        private void btnProdCatagories_Click(object sender, EventArgs e)
        {
            qryString = "Select p.ProductID,p.ProductName,p.UnitPrice,p.QuantityPerUnit,c.CategoryID ,c.CategoryName from Products p JOIN Categories c ON p.ProductID=c.CategoryID";
            sqlCmd = new SqlCommand(qryString, sqlCon);

            da = new SqlDataAdapter(sqlCmd);
            // ds = new DataSet();

            da.Fill(ds, "ProductsCategoriesInfo");

            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "ProductsCategoriesInfo";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            qryString = "Select Count(OrderID) from Orders";
            //sqlCon.Open();
            //sqlCmd = new SqlCommand(qryString, sqlCon);
            //MessageBox.Show("Total orders placed:"+ sqlCmd.ExecuteScalar().ToString(),"Total Orders");
            //sqlCon.Close();

            using (sqlCon = new SqlConnection(conString))
            {
                sqlCon.Open();
                sqlCmd = new SqlCommand(qryString, sqlCon);
                MessageBox.Show("Total orders placed:" + sqlCmd.ExecuteScalar().ToString(), "Total Orders");
                sqlCon.Close();
            }
        }

        private void btnLINQDS_Click(object sender, EventArgs e)
        {
            qryString = "Select ProductID,ProductName,UnitPrice,QuantityPerUnit,CategoryID from Products";
            sqlCmd = new SqlCommand(qryString, sqlCon);
            sqlCon.Open();
            da = new SqlDataAdapter(sqlCmd);
            ds.Clear();
            da.Fill(ds, "ProductInfo");
            DataTable dt = ds.Tables["ProductInfo"];
            var Products = from product in dt.AsEnumerable()
                           where product.Field<decimal>("UnitPrice") >= 50
                           select new
                           {
                               ProdID = product["ProductID"],
                               ProdName = product["ProductName"],
                               Price = product["UnitPrice"],
                               Quantity = product["QuantityPerUnit"]
                           };
            foreach (var product in Products)
            {
                MessageBox.Show("ProductID = " + product.ProdID + "Name=" + product.ProdName + "Price = " + product.Price + "Quantity = " + product.Quantity, "Products with Price < 50.00");

              }
        }
    

        private void Form2_Load(object sender, EventArgs e)
        {
            conString = "data source =BLT10132\\SQLEXPRESS2014;Initial" +
                  " Catalog=NorthWind;Integrated Security = True; ";
            sqlCon = new SqlConnection(conString);
            sqlCon.Open();
            qryString = "Select Country from Customers";
            sqlCmd = new SqlCommand(qryString, sqlCon);
            dr = sqlCmd.ExecuteReader();
            while (dr.Read())
            {
                cmbCountries.Items.Add(dr["Country"]);
            }
            dr.Close();
            sqlCon.Close();
         
        }
    }
}
