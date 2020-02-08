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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        SqlConnection sqlCon;
        SqlCommand sqlCmd;
        SqlDataReader dr;
        string conString, qryString;

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            qryString = "select ContactName from Customers where Country='" +
               comboBox1.Text + " ' ";
            sqlCmd = new SqlCommand(qryString, sqlCon);
            sqlCon.Open();
            dr = sqlCmd.ExecuteReader();
            while (dr.Read())
            {
                listBox1.Items.Add(dr["ContactName"]);
            }

            listBox1.Text = sqlCmd.ToString();
            dr.Close();
            sqlCon.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            conString = "data source =BLT10132\\SQLEXPRESS2014;Initial" +
                " Catalog=NorthWind;Integrated Security = True; ";
            sqlCon = new SqlConnection(conString);
            sqlCon.Open();
            qryString = "Select distinct Country from Customers";
            sqlCmd = new SqlCommand(qryString, sqlCon);
            dr = sqlCmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["Country"]);
            }
            dr.Close();
            sqlCon.Close();
        }
    }
}
