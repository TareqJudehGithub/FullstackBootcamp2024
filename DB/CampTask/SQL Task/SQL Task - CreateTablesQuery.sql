-- Switch to database
-- USE <db_name>;

-- Create EmployeeDetails
CREATE TABLE EmployeeDetails
(
    EmpID INT PRIMARY KEY IDENTITY(121, 100) NOT NULL,
    FullName VARCHAR(50) NOT NULL,
    ManagerId INT NOT NULL,
    DateOfJoining DATE NOT NULL,
    City VARCHAR(50) NOT NULL
)
GO

-- Create EmployeeSalary
CREATE TABLE EmployeeSalary
(
    Id INT PRIMARY KEY IDENTITY(1, 1) NOT NULL,
    EmpId INT NOT NULL,
    Project CHAR(2) NOT NULL,
    Salary DECIMAL(18, 3) NOT NULL,
    Variable DECIMAL(18, 3) NOT NULL
)
GO

