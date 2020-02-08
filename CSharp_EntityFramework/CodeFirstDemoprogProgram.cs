using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CodeFirstDemoprog
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductDBContext context = new ProductDBContext();
            //var product = context.Products;
            //var product1 = product.Add(new Product() { ProductID = 1, Name = "Badam Drink", Price = 29.99, Quantity = "200 ml", CategoryID = 1 });
            //var product2 = product.Add(new Product() { ProductID = 2, Name = "Coffee Drink", Price = 80.89, Quantity = "240 ml", CategoryID = 1 });
            //var product3 = product.Add(new Product() { ProductID = 3, Name = "cool Drink", Price = 70.89, Quantity = "300 ml", CategoryID = 1 });
            //var categories = context.Categories;
            //var category1 = categories.Add(new Category() { CategoryID = 1, Name = "beverages" });

            //context.SaveChanges();
            LinqToEntity();
        }

        public static void LinqToEntity()
        {
            ProductDBContext context = new ProductDBContext();
            var EconProducts = from product in context.Products
                               where product.Price < 80
                               select product;
            foreach (var product in EconProducts)
            {
                Console.WriteLine("ProductID: {0}, Name: {1},Price: {2}", product.ProductID, product.Name, product.Price);
            }
        }
    }
    public class ProductDBContext : DbContext
    {
        public ProductDBContext() :
            base("name=ProductDBContext")
        { }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }


    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Quantity { get; set; }
        public int CategoryID { get; set; }
    }
    public class Category
    {
        public int CategoryID { get; set; }
        public string Name { get; set; }
    }
}

