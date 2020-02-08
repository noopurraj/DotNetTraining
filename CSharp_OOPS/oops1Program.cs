using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops1
{
    class Program
    {
        static void Main(string[] args)
        {
           // Employee emp = new Employee();
            Employee emp1 = new Employee(1, "Robert", 2, "admin");  //initializing class fields using the constructor
            Employee emp2 = new Employee(2, "sam", 3, "technical");
            emp1.ShowData();
            emp2.ShowData();
            Product prd = new Product() { ProductID = 1, ProductName = "frooti", price = 55.00, quantity = "100ml" };

            prd.ShowData();
        }
    }
    public class Employee    //access specifier for class is internal by default
    {
        int empid; //access specifier is private by default for class members
        string empname;
        short deptid;
        string deptname;

        public Employee()  //default constructor
        { }
       // public Employee(int eid, string name)    //constructer with 2 parameters
       // {
         //empid = eid;
       // empname = ename;
      //  }
        public Employee(int eid, string ename, short did, string dname)   //constructor with 4 parameters
        {
            empid = eid;
            empname = ename;
            deptid = did;
            deptname = dname;
        }
        public void ShowData()  //this is an instance method
        {
            Console.WriteLine("empid = {0}", empid);
            Console.WriteLine("empname = {0}", empname);
            Console.WriteLine("deptid = {0}", deptid);
            Console.WriteLine("deptname= {0}", deptname);
        }
    }
    //access specifiers
    //private,protected,public,internal, protected internal
    //private- can only be accessed within the class where it is defined
    //protected- can only be accessed within both 


    public class Product
    {
        int pid;
        public int ProductID
        {
            get { return pid; }
            set { pid = value; }
        
        }

        //automatic properties , compiler does the implementation here
        public string ProductName
        {
            get;
            set;
        }
        public double price
        {
            get;
            set;

        }
        public string quantity
        {
            get;
            set;
        }
        public void ShowData()
        {
            Console.WriteLine("ProductID = {0}", ProductID);
        Console.WriteLine("ProductName = {0}", ProductName);
            Console.WriteLine("price ={0}", price);
            Console.WriteLine("quantity = {0}", quantity);
        }

    }
}
    

            
          

