using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avg
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] marks = new int[6];
            marks[0] = 89;
            marks[1] = 90;
            marks[2] = 91;
            marks[3] = 93;
            marks[4] = 96;
            marks[5] = 99;
            for (int i = 0; i < marks.Length; i++)
            
                Console.WriteLine("marks={0}", marks[i]);
            



            var avgmarks = getaverage(marks);
            Console.WriteLine("average of marks = {0}", avgmarks);
            

        }

        

       
    }

        //define a function to return the avg of
        public static double getaverage(int[] marks)
        {
            int total = 0;
            double avg;
            for (int i = 0; i < marks.Length; i++)
                total = total + marks[i];

            avg = total / marks.Length;
            return avg;
        }
    
}
