USE campdb;
-- Update row/field value
UPDATE Employees
SET JobTitle = 'Accountant'
WHERE Id = 3;

-- UPdate SSC value for all records from 1 to 0.075
UPDATE Employees
SET SSC = 0.075;