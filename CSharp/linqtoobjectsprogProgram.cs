using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linqtoobjectsprog
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] employees = new string[6] { "andrew", "andy", "jacob", "weber", "janes", "jack" };

            // using qwery syntax
            var knownEmpls = from emp in employees
                             where emp.StartsWith("j")
                             select emp;

            foreach (string emp in knownEmpls)
            {
                Console.WriteLine("EmpName starts with j: {0}", emp);
            }

            //using method syntax
            // => is known as lambda operator, and is read as "goes to"
            var someEmpls = employees.Where(s => s.Contains("a"));
            foreach (string emp in someEmpls)
            {
                Console.WriteLine("EmpName starts with a: {0}", emp);
            }


            Console.WriteLine("*********************************************************");
            List<string> fruits = new List<string>() { "Apple",
                                                      "orange",
                                                       "pineapple",
                                                       "grapes",
                                                        "banana",
                                                         "litchi",};

            var fruitswithP = from fruit in fruits
                              where fruit.Contains("p")
                              select fruit;
            foreach (string fruit in fruitswithP)
            {
                Console.WriteLine("Fruit with letter p: {0}", fruit);
            }
            var largerNameFruits = from fruit in fruits
                                   where fruit.Length > 6
                                   select fruit;
            Console.WriteLine("*********************************************************");
            foreach (string fruit in largerNameFruits)
            {
                Console.WriteLine("larger name Fruit: {0}", fruit);
            }
            Console.WriteLine("*********************************************************");

            var smallerNameFruits = fruits.Where(fruit => fruit.Length <= 6);

            foreach (string fruit in smallerNameFruits)
            {
                Console.WriteLine("smaller name Fruit: {0}", fruit);
            }
            Console.WriteLine("*********************************************************");

            int[] marks = new int[6] { 96, 97, 98, 45, 48, 44 };
            var highMarks = from m in marks
                            where m > 90
                            select m;

            foreach (var m in highMarks)
            {
                Console.WriteLine("high marks: {0}", m);
            }
            Console.WriteLine("***********************************************************");
            var marksInorder = from m in marks
                               orderby m descending
                               select m;
            foreach (var m in marksInorder)
            {
                Console.WriteLine("marks in order: {0}", m);
            }
            Console.WriteLine("***********************************************************");
            var marksInorder1 = from m in marks
                                orderby m
                                select m;
            foreach (var m in marksInorder1)
            {
                Console.WriteLine("marks in order: {0}", m);
            }
            Console.WriteLine("***********************************************************");

            List<Employee> Employees = new List<Employee>();
            Employees.Add(new Employee() { EmpID = 11, Empname = "andrews " });
            Employees.Add(new Employee() { EmpID = 212, Empname = "anders trolesan " });
            Employees.Add(new Employee() { EmpID = 311, Empname = "john " });

            var proEmpls = from emp in Employees
                           where emp.Empname.Contains("a")
                           select new { ename = emp.Empname };
            foreach (var emp in proEmpls)
            {
                Console.WriteLine("Employee starts with A: {0}", emp.ename);
            }
            
            Console.WriteLine("***********************************************************");
            //Console.ReadLine();
        }


        public class Employee
        {
            public int EmpID { get; set; }
            public string Empname { get; set; }

        }


        List<Product> Products = new List<Product>();
        Products.Add(new Product() { ProductID = 11, Productname = "frooti" });
            Products.Add(new Product () { ProductD = 212, Productname = "mazza " });
            Products.Add(new Product () { ProductD = 311, Productname = "coke" });

            var proPrds = from prd in Products
                           where prd.Productsname.Contains("a")
                           select new { pname = prd.Productname };
            foreach (var prd in proPrds)
            {
                Console.WriteLine("Products starts with A: {0}", prd.ename);
            }

    Console.WriteLine("***********************************************************");
            Console.ReadLine();
        }
    }
}

