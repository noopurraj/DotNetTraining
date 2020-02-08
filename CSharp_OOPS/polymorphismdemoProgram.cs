using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphismdemo
{
    class Program
    {
        static void Main(string[] args)  //entry point if cSharp console application
        {
            employee emp = new employee();
            var salary = emp.getsalary(30, 800);
            Console.WriteLine("salary without incentives: rs {0}", salary);

            salary = emp.getsalary(30, 800, 5000);
            Console.WriteLine("salary with incentives:rs {0}", salary);

            manager objM = new manager();
            var ts = objM.Getperks(30000, 5000);
            Console.WriteLine("salary of manager rs {0}", ts);
            Console.ReadKey();
        }
    }
    public class employee
    {
        public double getsalary(int nds, float spd)
        {
            double salary = nds * spd;
            return salary;
        }
        public double getsalary(int nds, float spd, float incent)  //grtsalary method is overloaded
        {
            double salary = (nds * spd) + incent;
            return salary;
        }




        //this method will be overridden in some other derived class
        public virtual double Getperks(float salary, float perks)
        {
            double ts = salary + perks;
            return ts;
        }

    }
    public class manager : employee
    {
        public override double Getperks(float salary, float perks) //signature remains same while overriding
        {
             return base.Getperks(salary, perks) * 1.10;  //"base" keyword reders to the base class

            //double ts = 1.10 * (salary + perks);
           // return ts;
        }

    }
}


