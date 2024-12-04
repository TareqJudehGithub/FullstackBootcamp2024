-- SELECT statement Task

-- Switch to your DB
-- USE <DB name>;

-- Return all students from Amman city
SELECT *
FROM Students
WHERE City = 'Amman';

-- Return all students from Zarqa, or Irbid, or Aqaba
-- Solution No#1 - using OR keyword
SELECT *
FROM Students
WHERE City = 'Zarqa' OR City = 'Irbid' OR City = 'Aqaba';

-- Solution No#2  - using IN keyword
SELECT *
FROM Students
WHERE City IN ('Zarqa', 'Irbid', 'Aqaba');

-- Return all male students
SELECT *
FROM Students
WHERE Gender = 'M';

-- Return Student Name and Gender as Male/Female
SELECT 
    StudentName, 
CASE 
    WHEN Gender = 'M' THEN 'Male'
    ELSE 'Female'
END AS Gender
FROM Students;

-- Return all students with Degree (Masters or PhD), and live outside Amman city
SELECT *
FROM Students
WHERE Degree IN ('Masters', 'PhD') AND NOT City = 'Amman';

-- Return all students above age 30
-- Here, we should first convert both Current Year and Year of Birth to INT, and then 
-- subtract the difference.
SELECT 
    *, 
    CAST(YEAR(GETDATE()) AS INT) - CAST(YEAR(DOB) AS INT) AS Age 
FROM Students
WHERE CAST(YEAR(GETDATE()) AS INT) - CAST(YEAR(DOB) AS INT) > 30;

-- Return all students sorted by name, gender, and city
SELECT *
FROM Students
ORDER BY StudentName, Gender, City;

-- Return total students in each city
SELECT 
    COUNT(City) AS StudentCount,
    City
FROM Students
GROUP BY City;





