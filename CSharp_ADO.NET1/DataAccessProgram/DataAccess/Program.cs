using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataAccess
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection sqlCon;
            SqlCommand sqlCmd;
            SqlDataAdapter da;
            SqlDataReader dr;

            string conString, qryString;
            conString = "data source =BLT10132\\SQLEXPRESS2014;Initial" +
                  " Catalog=NorthWind;Integrated Security = True; ";
            sqlCon = new SqlConnection(conString);
            sqlCon.Open();
            qryString = "Select ProductName from Products";
            sqlCmd = new SqlCommand(qryString, sqlCon);
            dr = sqlCmd.ExecuteReader();
            da = new SqlDataAdapter();
            while (dr.Read())
            {
                //cmbCountries.Items.Add(dr["Country"]);
                Console.WriteLine("ProductName:{0}",dr["ProductName"]);
            }
            dr.Close();
            sqlCon.Close();
        }
    }
}
