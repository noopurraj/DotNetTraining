using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops3
{
    class Program
    {
        static void Main(string[] args)
        {
            SBAccount objSB = new SBAccount();
            CCAccount objCC = new CCAccount();
            double siSB = objSB.getsimpleinterest(95000.00, 5, 8);
            double tamt = objSB.gettotalamount(50000.00, siSB);
            Console.WriteLine("simple interest: rs {0}", siSB);
            Console.WriteLine("total amount: rs{0}", tamt);
            var siCC = objCC.getsimpleinterest(95000.00, 5, 8);
            tamt = objCC.gettotalamount(50000.00, siCC);
            Console.WriteLine("simple interest(current account): rs {0}", siCC);
            Console.WriteLine("total amount: rs {0}", tamt);
           
            objSB.Show(); //calling the concrete method defined within the banking base class
        }
    }
    public abstract class Banking
    {
        public abstract double getsimpleinterest(double pr, int td, short rt);
        public abstract double gettotalamount(double bal, double si);
        public void Show()
        {
            Console.WriteLine("this is a concrete method defined within an abstract class ");

        }
    }
        public class SBAccount : Banking
        {
            public override double getsimpleinterest(double pr, int td, short rt)
            {
                double si = (pr * td * rt) / 100;
                return si;
            }

            public override double gettotalamount(double bal, double si)
            {
                double tamount = bal + si;
                return tamount;
            }
        }
    public class CCAccount : Banking
    {
        public override double getsimpleinterest(double pr, int td, short rt)
        {
            double si = 0.25 * ((pr * td * rt) / 100);
            return si;
        }

        public override double gettotalamount(double bal, double si)
        {
            double tamount = bal + si;
            return tamount;
        }
    }
}

