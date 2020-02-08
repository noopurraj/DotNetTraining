using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace fileIOManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            //DirectoryInfo dir = new DirectoryInfo("c:\\sampledirectory");
            //dir.Create();

            //FileInfo file= new FileInfo(@"c:\sampledirectory\sample.txt");
            //file.Create();

            Console.WriteLine(" \n the directory and the text file is created ");
            FileStream fs = new FileStream(@"c:\sampledirectory\sample.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("this text has been written to the file using file I/O manipulation");
            fs = new FileStream(@"c:\sampledirectory\sample.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sw= new StreamWriter(fs);
            sw.WriteLine("the text has been appended to the existing one");
            sw.Close();
            fs.Close();
            Console.WriteLine(" \n some content is written to the file");


            fs = new FileStream(@"c:\sampledirectory\sample.txt",FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);


            string lineByLine;
            while ((lineByLine = sr.ReadLine()) !=null)
            {
                Console.WriteLine("\n the file content:{0}", lineByLine);
            }

            sr.Close();
            fs.Close();

            
                
            Console.ReadKey();

        }
    }
}
