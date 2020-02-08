use EmployeeDB;

select * from Employee;
select Max(salary) [max salary], Min(salary) 'Min Salary', AVG(salary) 'Average salary' from Employee;
 select  DepID, sum(salary) 'total salary' from employee
 group by DepID
 order by depid;
 select depid, sum(salary) 'total salary' from employee
 group by depid
 having sum(salary)>=50000
 order by depid;
 select top(5) * from employee;
 select top(3) with ties salary from employee
 order by salary;
 select top(3) salary from employee
 order by salary desc; 