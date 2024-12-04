-- Switch to your DB:
--USE <DB_name>;


-- 1. Write a query to fetch EmpId and FullName of aLl employees working under manager - Id986
SELECT EmpID, FullName
FROM EmployeeDetails
WHERE ManagerId = 986
ORDER BY EmpID
GO

-- 2. Write a query to fetch the different projects available from EmployeeSalary table.
SELECT DISTINCT Project
FROM EmployeeSalary
ORDER BY Project
GO

-- 3. Write a query to fetch the count of employees working under project 'P1'.
SELECT 
    Project,
    COUNT(Project) AS P1EmployeesTotal
FROM EmployeeSalary
GROUP BY Project 
HAVING Project = 'P1'
GO

-- Write a query to find the employee Id whose salary is between the range of 9000 and 15000
SELECT EmpId
FROM EmployeeSalary
WHERE Salary BETWEEN 9000 AND 15000
ORDER BY EmpID
GO

-- Write a query to fetch employees working under projects other than 'P1'
SELECT 
    ED.EmpId,
    ED.FullName,
    ES.Project
FROM EmployeeSalary ES
JOIN EmployeeDetails ED ON ED.EmpID = ES.EmpID
WHERE NOT ES.Project = 'P1'
ORDER BY ED.EmpID
GO

-- Write a query to fetch total salary for each project
SELECT 
    Project,
    SUM(Salary + Variable) AS TotalSalaries
FROM EmployeeSalary
GROUP BY Project
ORDER BY Project
GO

USE campdb;

