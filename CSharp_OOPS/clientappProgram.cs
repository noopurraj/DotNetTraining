using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bankcomponent;

namespace clientapp
{
    class Program
    {
        static void Main(string[] args)
        {
            SavingsBank sav = new SavingsBank();

            
            var Interest = sav.GetInterest(1000, 5, 6);
            Console.WriteLine("Interest is: {0}", Interest);
            Console.ReadKey();
        }
    }
}
