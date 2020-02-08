using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops2
{
    class Program
    {
        static void Main(string[] args)
        {
            customer cst = new customer() { customerID = 1, customerName = "sam", country = "USA" };
            cst.ShowData();
        }
        public class customer
        {
            int cid;
            public int customerID
            {
                get { return cid; }
                set { cid = value; }

            }

            //automatic properties , compiler does the implementation here
            public string customerName
            {
                get;
                set;
            }





            public string country
            {
                get;
                set;
            }
            public void ShowData()
            {
                Console.WriteLine("customerID = {0}", customerID);
                Console.WriteLine("customerName = {0}", customerName);

                Console.WriteLine("country = {0}", country);
            }
        }
    }
}
