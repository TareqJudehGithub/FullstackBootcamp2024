USE campdb;

-- Combine both first and last name and output the result as FullName

SELECT CONCAT(FirstName, ' ', LastName) AS FullName
FROM Employees;