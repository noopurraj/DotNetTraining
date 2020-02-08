using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace codebymyself
{
    class Program
    {
        static void Main(string[] args)
        {
            studentDBContext context = new studentDBContext();
            //var student = context.students;
            //var student1 = student.Add(new student() { studentID = 1, Name = "sam", marks = 100.00, Quality = "best", CategoryID = 1 });
            //var student2 = student.Add(new student() { studentID = 2, Name = "sammyyy", marks = 60.89, Quality = "pass", CategoryID = 1 });
            ////var studentt3 = student.Add(new student() { studentID = 3, Name = "carol", marks = 70.89, Quality = "average ", CategoryID = 1 });
            //var categories = context.Categories;
            //var category1 = categories.Add(new Category() { CategoryID = 1, Name = "details" });

            //context.SaveChanges();
            LinqToEntity();
        }

        public static void LinqToEntity()
        {
            studentDBContext context = new studentDBContext();
            var Econstudents = from student in context.students
                               where student.marks < 90
                               select student;
            foreach (var student in Econstudents)
            {
                Console.WriteLine("studentID: {0}, Name: {1},marks: {2}", student.studentID, student.Name, student.marks);
            }
        }
    }
    public class studentDBContext : DbContext
    {
        public studentDBContext() :
            base("name=studentDBContext")
           { }
        public DbSet<student> students { get; set; }
        public DbSet<Category> Categories { get; set; }
    }


    public class student
    {
        public int studentID { get; set; }
        public string Name { get; set; }
        public double marks { get; set; }
        public string Quality { get; set; }
        public int CategoryID { get; set; }
    }
    public class Category
    {
        public int CategoryID { get; set; }
        public string Name { get; set; }
    }
}
    