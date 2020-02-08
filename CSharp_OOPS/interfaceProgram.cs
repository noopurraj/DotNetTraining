using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @interface
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] marks = new int[6] { 89, 90, 96, 97, 98, 99 };
            Result objR = new Result();  //result class is instantiated
            var avg = objR.getaveragemarks(marks); //accessing the result class functionality
            objR.displayaverage(avg);
            objR.ShowGrade(avg);
            Console.ReadKey();

        }
    }
    //all interfaces can have only method prototypes without any concrete defination
    public interface IExam
    {
        double getaveragemarks(int[] marks);
        void displayaverage(double avg);
    }
    public interface Istudent
    {
        void ShowGrade(double avg);

    }
    public class Result: IExam, Istudent
    {
        public void displayaverage(double avg)
        {
            Console.WriteLine("the average marks={0}", avg);

        }
        public double getaveragemarks(int[] marks)
        {
            int total;
            double avg;
            total = 0;
            for (int i = 0; i < marks.Length; i++)
                total += marks[i];
            avg = total / marks.Length;
            return avg;
        }
        public void ShowGrade(double avg)
        {
            if (avg >= 70.00)
                Console.WriteLine("passed in distiction");
            else
                Console.WriteLine("not passed in distinction");
        }
    }
}
