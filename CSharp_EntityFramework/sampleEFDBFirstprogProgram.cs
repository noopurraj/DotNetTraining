using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace sampleEFDBFirstprog
{
    class Program
    {
        static void Main(string[] args)
        {
            LinqtoEntity();
            //ModifyEmployee();
            //DeleteEmployee();
            //EmployeeEFDBEntities context = new EmployeeEFDBEntities();
            //var employee = new Employee()
            //{
            //    EmpID = 1,
            //    Name = "sam",
            //    Salary = 35000,
            //    SSN = 23456,
            //    DepID = 3
            //};

            //context.Employees.Add(employee);
            //context.SaveChanges();

            //    var employee2 = new Employee()
            //    {
            //        EmpID = 2,
            // Name = "sammy",
            //    Salary = 35000,
            //    SSN = 23456,
            //    DepID = 3
            //};

            //context.Employees.Add(employee);
            //context.SaveChanges();




        }
        public static void LinqtoEntity()
        {
            EmployeeEFDBEntities context = new EmployeeEFDBEntities();
            var employees = context.Employees;

            var empList = from emp in employees
                          orderby emp.Salary
                          select emp;
            foreach (var emp in empList)
            {
                Console.WriteLine("EmpID: {0}, Name: {1}, salary: {2}, SSN: {3}", emp.EmpID, emp.Name, emp.Salary, emp.SSN);
            }
        }
        public static void ModifyEmployee()
        {
            EmployeeEFDBEntities context = new EmployeeEFDBEntities();
            var employees = context.Employees;

            var emplist = from emp in employees
                          orderby emp.Salary
                          select emp;
            foreach (var emp in emplist)
            {
                if (emp.EmpID == 1)
                    emp.Name = "Matthew  Mcdonald";
            }
            context.SaveChanges();
        }
        public static void DeleteEmployee()
        {
            EmployeeEFDBEntities context = new EmployeeEFDBEntities();
            var employees = context.Employees;
            var employee = new Employee { EmpID = 4 };
            employees.Attach(employee);
            employees.Remove(employee);
            context.SaveChanges();


        }
    }
}
