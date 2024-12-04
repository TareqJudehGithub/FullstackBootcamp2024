-- SQL Case - Conditionals in SQL
SELECT 
    StudentName, 
CASE 
    WHEN Gender = 'M' THEN 'Male'
    ELSE 'Female'
END AS Gender
FROM Students;
