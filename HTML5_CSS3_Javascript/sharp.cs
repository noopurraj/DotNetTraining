using System;


namespace csharpFundamentals
{
       public class Sample
       {
       public static void main(String args[])
       {
       int empAge;
       string empName;

       console.WriteLine("Enter employee name\n");
       empName= Console.ReadLine();
       console.WriteLine("enter employee age\n");
       empAge = int.Parse(Console.ReadLine());
     

      Console.WriteLine("congrats Mr/Miss {0} on your {1} birthday",empName,empAge);
  

     }
     }
    }