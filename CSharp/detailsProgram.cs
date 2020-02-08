using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace details
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> Employees = new List<Employee>();

            Employees.Add(new Employee() { EmployeeID = 1, EmpName = "sam", dept = "admin" });
            Employees.Add(new Employee() { EmployeeID = 2, EmpName = "san", dept = "hr" });
            Employees.Add(new Employee() { EmployeeID = 3, EmpName = "mac", dept = "bde" });
            foreach (var emp in Employees)
            {
                Console.WriteLine("empId={0}, empname={1}, dept={2}", emp.EmployeeID, emp.EmpName, emp.dept);

            }

            //stack and queue data structures
            //stack is last in first out(lifo) where queue is (fifo) data structures

            Stack<float> fnumbers = new Stack<float>();
            fnumbers.Push(10.90f);
            fnumbers.Push(12.53f);
            fnumbers.Push(13.85f);
            fnumbers.Push(15.98f);
            Console.WriteLine("\n before calling the pop method \n");

            foreach (var fn in fnumbers)
                Console.WriteLine(fn);

            fnumbers.Pop();
            Console.WriteLine("\n after calling \n");
            foreach (var fn in fnumbers)
                Console.WriteLine(fn);

            Queue<double> qnumbers = new Queue<double>();
            qnumbers.Enqueue(10.98);
            qnumbers.Enqueue(13.85);
            qnumbers.Enqueue(12.69);
            qnumbers.Enqueue(15.98);
            Console.WriteLine("\n before calling the dequeue method \n");
            foreach (var qn in qnumbers)
                Console.WriteLine(qn);
            qnumbers.Dequeue();
            Console.WriteLine("\n before calling the dequeue method \n");
            foreach (var qn in qnumbers)
                Console.WriteLine(qn);


            int a, b;
            a = 50; b = 30;
            Console.WriteLine("before swap: a={0}, b={1}", a, b);
            Swap<int>(ref a, ref b);
            Console.WriteLine(" after swap: a={0}, b={1}", a, b);

            string s1, s2;
            s1 = "hello";
            s2 = "world";
            Console.WriteLine("before swap: s1={0}, s2={1}", s1, s2);
            Swap<string>(ref s1, ref s2);
            Console.WriteLine(" after swap: s1={0}, s2={1}", s1, s2);
            Console.ReadKey();


        }

        public static void Swap<T>(ref T a, ref T b)  //generic method used to swap 
        {
            T c;
            c = a;
            a = b;
            b = c;
        }
    }
        
    public class Employee
    {
        public int EmployeeID
        {
            get;
            set;
        }

        public string EmpName
        {
            get;
            set;

        }
        public string dept
        {
            get;
            set;
        }
        public string ShowData()
        {
            return string.Format("empId={0}, empname={1}, dept={2}", EmployeeID,EmpName,dept);
        }

    }
}


       
    

