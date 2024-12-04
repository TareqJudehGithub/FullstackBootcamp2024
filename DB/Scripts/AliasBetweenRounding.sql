-- Alias
USE campdb;

-- Combine both first and last name and output the result as FullName

SELECT 
CONCAT(FirstName, ' ', LastName) AS FullName, 
DOB,
Salary,
CONVERT(DOUBLE PRECISION, Salary - (Salary * SSC)) AS NetSalary,   -- Double Precision
CAST (Salary - (Salary * SSC) as DECIMAL(18, 2)) AS NetSalary     -- CAST()
FROM Employees
WHERE Salary BETWEEN 500 and 2000 and DOB >= '2000-01-01';

