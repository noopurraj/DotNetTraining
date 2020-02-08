using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

namespace multithredappperform
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("main thread has started");
            Stopwatch s1 = new Stopwatch();

            s1.Start();
            Incrementcount1();
            Incrementcount2();
            s1.Stop();

            Stopwatch s2 = new Stopwatch();
            Thread T1 = new Thread(Incrementcount1);
            Thread T2 = new Thread(Incrementcount2);

           
            s2.Start();
            T1.Start();
            T2.Start();
            s2.Start();

            T1.Join();
            T2.Join();

            Console.WriteLine("total time elapsed for single threaded application: {0}", s1.ElapsedMilliseconds);
            Console.WriteLine("total time elapsed for Multi threaded application: {0}", s2.ElapsedMilliseconds);
            Console.WriteLine("main thread has exited");

        }

        public static void Incrementcount1()
        {
            long count1 = 0;
            for (int i = 0; i < 1000000; i++)
                count1++;
            Console.WriteLine("count1: {0}", count1);
        }
        public static void Incrementcount2()
        {
            long count2 = 0;
            for (int i = 0; i < 1000000; i++)
                count2++;
            Console.WriteLine("count1: {0}", count2);
        }
    }
}
