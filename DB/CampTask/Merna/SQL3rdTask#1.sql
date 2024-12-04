CREATE TABLE EmployeeDetails
(
EmpId Int Primary Key Identity (121,100),
FullName NVARCHAR (50) not null,
ManagerId INT not null,
DateOfJoinging DATETIME not null,
City NVARCHAR (50) not null,
IsDeleted bit 
)

Insert INTO [dbo].[EmployeeDetails]
VALUES
('John Snow', 321, '2019/01/31', 'Toronto', 0),
('Tom Anderson', 876, '2020/02/05', 'Michigan', 0),
('Walter White', 986, '2020/01/30','California', 0),
('Kuldeep Rana', 876, '2021/11/27', 'New Delhi', 0),
('Abdlrahman Soud', 321, '2022/10/21', 'Saudi Arabia', 0),
('Taleb Abdlrahman', 321, '2020/11/19', 'Saudi Arabia', 0),
('Michel Scott', 986, '2021/01/04', 'Aiwa', 0),
('Benjamiin Bernard', 876, '2018/07/10', 'Austria', 0),
('Kate Smith', 986, '2020/12/16', 'California', 0),
('Lamis khoury', 986, '2023/03/23', 'Lebanon', 0)



