create Database EmployeeEFDB;

use EmployeeEFDB;

create Table Employee
(EmpID int Primary Key,
Name varchar(30) not null,
SSN bigint not null,
Salary float not null,
DepID int not null);

create Table Department
(DepID int Primary Key,
Name varchar(30) not null);

Alter Table Employee
Add constraint FK_DepID FOREIGN KEY(DepID) references Department(DepID);

Insert Into Department values(1,'Admin');
Insert Into Department values(2,'CoAdmin');

Insert Into Department values(3,'Manager');

select * from Department;
select * from Employee;

insert into Employee values(4, 'someEmployee',1111,10000,1);
