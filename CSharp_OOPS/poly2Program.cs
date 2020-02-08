using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poly2
{
    class Program
    {
        static void Main(string[] args)
        {
            student std = new student();
            var x = std.getmark(20, 5);
            Console.WriteLine("marks of student before adding: {0}", x);
            teacher tch = new teacher();
            var y = tch.getmark(22, 10);
            Console.WriteLine("marks of student after adding: {0}", y);
            Console.ReadKey();
        }
    }

    public class student
    {
        public virtual int getmark(int correct, int extra)
        {
            int mark = correct * extra;
            return mark;
        }
    }
        public class teacher : student
        {
            public override int getmark(int correct, int extra)
            {
                return base.getmark(correct, extra) + 10; 
            }
        }
    
           
}
