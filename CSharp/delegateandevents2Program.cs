using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegateandevents2
{
    class Program
    {

        public delegate void calculations(double a, double b);
        static void Main(string[] args)
        {


           
            //multicast delegate
            calculations deleg = new calculations(addition);
            deleg += subtraction;
            deleg += division;
            deleg += product;
            deleg.Invoke(30, 80);
        }

        public static void addition(double a, double b)
        {
            double c = a + b;
            Console.WriteLine("addition of {0} and {1}= {2}", a, b, c);
        }
        public static void subtraction(double a, double b)
        {
            double c = a - b;
            Console.WriteLine("sum of {0} and {1}= {2}", a, b, c);

        }
        public static void division(double a, double b)
        {
            double c = a / b;
            Console.WriteLine("sum of {0} and {1}= {2}", a, b, c);
        }
        public static void product(double a, double b)
        {
            double c = a * b;
            Console.WriteLine("sum of {0} and {1}= {2}", a, b, c);
        }
    }
}

