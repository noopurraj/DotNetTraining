using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegate2
{
    class Program
    {
        public delegate double totdelegate(int x, float y);
        static void Main(string[] args)
        {
            totdelegate deleg = new totdelegate(getadd);
            var add = deleg.Invoke(20, 5);
            Console.WriteLine("add={0}", add);
            deleg += getsubtraction;
            var subtract = deleg.Invoke(20, 5);
            Console.WriteLine("subtraction ={0}", subtract);
            deleg += getmultiplication;
            var multiply = deleg.Invoke(20, 5);
            Console.WriteLine("multiplication ={0}", multiply);
            deleg += getquotient;
            var quot = deleg.Invoke(20, 5);
            Console.WriteLine("quotient={0}", quot);
            Console.ReadKey();

        }
        public static void  getadd(int a, float b)
        {
            var add = (a + b);
                return add;
        }
        public static void  getsubtraction(int a, float b)
        {
            var subtract = (a - b);
            return subtract;
        }
        public static void getmultiplication(int a, float b)
        {
            var multiply = (a * b);
            return multiply;
        }
        public static void  getquotient(int a, float b)
        {
            var quot = (a / b);
            return quot;
        }
    }
}
