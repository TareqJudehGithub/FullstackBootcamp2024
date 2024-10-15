USE CoderZ

-- student table
-- id studentName Gender DoB Degree Address City
--      varchar
CREATE TABLE Student
(
    Id INT PRIMARY KEY IDENTITY (1, 1) NOT NULL,
    StudentName VARCHAR(50) NOT NULL, 
    Gender CHAR(1) NOT NULL,
    DOB DATETIME NOT NULL,
    Degree VARCHAR(20) NOT NULL,
    Address VARCHAR(50),
    City VARCHAR(20)
);
-- courses table
-- Id CourseName CourseCategory Price StartDate EndDate Description
--      varchar
CREATE TABLE Courses
(
    id INT PRIMARY KEY NOT NULL,
    CourseName VARCHAR(50) NOT NULL, 
    Category VARCHAR(20) NOT NULL,
    Price DECIMAL(18,3) NOT NULL,
    StartDate DATETIME NOT NULL,
    EndDate DATETIME NOT NULL,
    Description VARCHAR(50)
);

SELECT DB_NAME();

-- Student Data
INSERT INTO Student
VALUES
-- ( 'John Smith', 'M', '2000-05-27', 'BA', 'Springfield Gardens, Brooklyn', 'New York'),
( 
    'Dareen Saed', 'F', '2004-03-29', 'BA', 'Olives Tree Suburb', 'Paris'
);

-- Courses
INSERT INTO Courses
VALUES
(
    'MS SQL 2022', 'Database', 19.99, '2023-06-15', '2023-07-15', 'MS SQL Server 2022 Query and Administration'
),
(
    'Cyber Security 2024', 'Security', 49.99, '2022-02-01', '2022-05-31', 'Security of Local and Global networks.'
),
(
    'ICDL', 'Office', 14.99, '2021-01-20', '2021-02-17', 'MS Office 2024.'
);


-- Adding new column 'IsDeleted' to table: Student and Courses
ALTER TABLE Student
ADD IsDeleted BIT;

UPDATE Student
SET IsDeleted = 'false';

ALTER TABLE Courses
ADD IsDeleted BIT;

UPDATE Student
SET IsDeleted = 'true'
WHERE Id in (4, 8, 15, 19);

-- Query statements:
SELECT *
FROM Student;

SELECT *
FROM Courses;


