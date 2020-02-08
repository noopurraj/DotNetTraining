using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Migrations;


namespace codefirstdemoprg
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerDBContext context = new CustomerDBContext();

            var orders = context.Orders;

            var order1 = orders.Add(new Order() { OrderID = 1, OrderDate = new DateTime(2020, 01, 01), customerID = 1, shippedDate = new DateTime(2020, 01, 15) });
            var order2 = orders.Add(new Order() { OrderID = 2, OrderDate = new DateTime(2020, 01, 01), customerID = 2, shippedDate = new DateTime(2020, 01, 25) });

            context.SaveChanges();
        }
    }

    public class CustomerDBContext : DbContext
    {
        public CustomerDBContext() : base("name=customerDBContext")
        { }

        public DbSet<customer> customers { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
    public class customer
    {
        public int customerID { get; set; }
        public string Name { get; set; }
        public string address { get; set; }
        public string country { get; set; }
        public IList<Order> Orders { get; set; }
    }

    public class Order
    {
        public int OrderID { get; set; }
        public DateTime OrderDate { get; set; }
        public int customerID { get; set; }
        public DateTime shippedDate { get; set; }
    }
}
