USE campdb;
-- Add new column to Table
ALTER TABLE Employees
ADD JobTitle VARCHAR(20);

-- Drop column from Table
ALTER TABLE Employees
ADD DelMe INT;

-- DROP/DELETE a column
ALTER TABLE Employees
DROP COLUMN DelMe;


 -- EDIT column name
 EXEC sp_rename 'dbo.Employees.DelMe', 'RemoveMe', 'COLUMN';
 
 -- EDIT Column data type
 ALTER TABLE Employees 
 ALTER COLUMN JobTitle VARCHAR(20);

 ALTER TABLE Employees
 ALTER COLUMN SSC DECIMAL(18, 3);

 ALTER TABLE Employees
 ALTER COLUMN Salary DECIMAL (18, 3);
 
SELECT *
FROM Employees;


