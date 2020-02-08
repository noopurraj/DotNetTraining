using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace mainthread
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("main thread is started");
            Thread t = Thread.CurrentThread;
            t.Name = "Main Thread";
            Console.WriteLine("{0} is running now with ID:{1}", t.Name, t.ManagedThreadId);
            //Method1();
            //Method2();
            //Method3();
            Thread T1 = new Thread(new ThreadStart(Method1));
            Thread T2 = new Thread(Method2); //Method2 is implicity handled by ThreadStart delegate
            Thread  T3 = new Thread(Method3);
            

            T1.Start();
            T2.Start();
            T3.Start();
            Thread tp = new Thread(new ParameterizedThreadStart(test));
            tp.Start(100);


            Thread Tarea = new Thread(new ThreadStart(FindArea));
            Tarea.Start();
            Console.WriteLine("main thread is ending");


            Console.ReadLine();

        }
        public static void Method1()
        {
            for (int i = 1; i <= 50; i++)
                Console.WriteLine("Method1: {0}", i);
        }
        public static void Method2()
        {
            for (int i = 1; i <= 50; i++)
            {
                if (i == 25)
                {
                    Thread.Sleep(5000);
                }
                Console.WriteLine("Method2: {0}", i);
            }
        }
        public static void Method3()
        {
            for (int i = 1; i <= 50; i++)
            {
                Console.WriteLine("Method3: {0}", i);
            }
        }

        public static void test(object max)
        {
            int j = Convert.ToInt32(max);
            for (int i = 1; i <= j; i++)
            {
                Console.WriteLine("test: {0}", i);
            }
        }

        public static void FindArea()
        {
            double len, brd;
            Console.WriteLine("enter length");
            len = double.Parse(Console.ReadLine());
            Console.WriteLine("enter breath");
            brd= double.Parse(Console.ReadLine());
            Console.WriteLine(" area of rectangle: {0}", (len * brd).ToString());
        }
    }
}
