using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace genericcollectiondemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList items = new ArrayList(100);  //non-generic collection class

            items.Add("hello world");
            items.Add(10);
            items.Add(DateTime.Now);
            items.Add(true);

            foreach (object obj in items) 
            
            Console.WriteLine(obj.ToString());


            List<int> myInts = new List<int>();   //generic collection class

            myInts.Add(10);
            myInts.Add(80);
           // myInts.Add("hi");
            myInts.Add(90);

            foreach (var n in myInts)
                Console.WriteLine(n.ToString());


            List<string> employees = new List<string>() { "sam", "san", "robert", "pooh" };
            foreach (var emp in employees)
                Console.WriteLine(emp);

          Dictionary<int, string> fruits = new Dictionary<int, string>();

            fruits.Add(1,"apple");
            fruits.Add(2, "chiku");
            fruits.Add(3, "peach");
            fruits.Add(4,"mango");
            fruits.Add(5, "papaya");

            foreach (KeyValuePair<int, string> kv in fruits)
            {

                Console.WriteLine("key -> {0}, value -> {1}", kv.Key, kv.Value);
            }



            ////deleting an item from the collection

            fruits.Remove(4);
            fruits.Add(4, "grapes");
            foreach (KeyValuePair<int, string> kv in fruits)
            {
                Console.WriteLine("key -> {0}, value -> {1}", kv.Key, kv.Value);
            }


            SortedDictionary<int, string> gadgets = new SortedDictionary<int, string>();  //sorts all the items in ascending order and then retrieves them


            gadgets.Add(3, "thinkpad");
            gadgets.Add(1, "ipad");
            gadgets.Add(5, "iphone");
            gadgets.Add(4, "pd");
            gadgets.Add(2, "cd");
            foreach (KeyValuePair<int, string> kv in gadgets)
            {
                Console.WriteLine("key -> {0}, value -> {1}", kv.Key, kv.Value);
            }

           Console.ReadKey();
        }
    }
}
