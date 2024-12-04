CREATE TABLE EmployeeSalaries
(
Id INT Primary Key Identity (1,1),
EmpId INT null,
Project CHAR (2),
Salary Decimal (18,3) not null,
Variable INT not null,
IsDeleted bit 
)

Insert Into 
Values
(1, 121, 'P1', 8000, 500),
(2, 321, 'P2', 10000, 1000),
(3, 421, 'P1', 12000, 0),
(7, 1021, 'P3', 10000, 0),
(8, 521, 'P2', 13000, 300),
(9, 621, 'P1', 5000, 600)
