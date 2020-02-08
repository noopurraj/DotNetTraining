CREATE DATABASE EmployeeDB;
Use EmployeeDB;

CREATE TABLE Employee
(EmpID int not null,
EmpName varchar(50) not null,
SSN bigint not null,
salary float not null,
DepID int not null);
INSERT INTO Employee values(1,'Jeffrey',23456,35000.00,1);
INSERT INTO Employee values(2,'Robert',13456,25000.00,2);
INSERT INTO Employee values(3,'Andrew',53456,35000.00,3);

Select * from Employee;
drop 

