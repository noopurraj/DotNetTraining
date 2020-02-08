using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace customercomponents
{
    public class Customer
    {




        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string Address { get; set; }
        
        public string ShowData()
        {
            return string.Format("CustomerID = {0} ,CustomerName= {1}, Address={2}", CustomerID, CustomerName, Address);
        }
    }


   
}



