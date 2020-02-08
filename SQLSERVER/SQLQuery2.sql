CREATE DATABASE EmployeeDB;
 Use EmployeeDB;
  CREATE TABLE Department
  (DeptID int not null primary key,
  DeptName varchar(50) not null);
  Insert Into Department values(1,'Admin');
  Insert Into Department values(2,'Techanical');
  select * from Department;
  alter table Department
  add description varchar(70);
 update Department Set Description='this is my first company'where DeptID=1;
  update Department Set Description='this is my second company'where DeptID=2;
  alter table Department
  ADD Constraints FK_DeptID FOREIGN KEY(DeptID)References Department(DeptID);
  alter table Department
  Add DOB date
  update Department SET DOB='10.08.1995';
  alter table Department
  Add Constraint chk_DOB CHECK (DOB BETWEEN '01/01/1990' AND '12/31/1999');
  alter table Department
  Insert Into Department values(2,'techanical','19/05/1991');

   
