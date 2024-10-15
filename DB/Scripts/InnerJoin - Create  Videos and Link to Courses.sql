-- USE Database
USE campdb;
-- USE CoderZ;

-- Add new column to Students table: CourseID
ALTER TABLE Students
ADD CourseId INT;

-- Update Students CourseID column with data for all records
UPDATE Students
SET CourseId = 101
WHERE Id IN (1, 7, 11, 16, 20, 25, 29);

UPDATE Students
SET CourseId = 201
WHERE Id IN (2, 5, 9, 14, 19, 22, 30);

UPDATE Students
SET CourseId = 301
WHERE Id IN (3, 6, 10, 15, 18, 24, 28);

UPDATE Students
SET CourseId = 401
WHERE Id IN (4, 8, 12, 17, 21, 23, 26);

UPDATE Students
SET CourseId = 501
WHERE Id = 13

UPDATE Students
SET CourseId = 501
WHERE Id = 32;
-- Create Videos table Videos
CREATE TABLE Videos
(
    Id INT PRIMARY KEY IDENTITY (1, 1) NOT NULL,
    VideoTitle VARCHAR(50) NOT NULL,
    CourseID INT NOT NULL
);

-- Inserting data into Videos
-- HTML
INSERT INTO Videos
VALUES
(
    'HTML Fundamentals', 101
),
(
    'HTML Deep Dive', 101
);

-- CSS
INSERT INTO Videos
VALUES
(
    'CSS Basics', 101
),
(
    'CSS Advanced Topics', 101
),
(
    'CSS Responsive Design', 101
);

-- JS
INSERT INTO Videos
VALUES
(
    'JavaScript Fundamentals', 101
),
(
    'JavaScript OOP', 101
),
(
    'JavaScript More Advanced Topics', 101
)

-- C#
INSERT INTO Videos
VALUES
(
    'C# Language and History', 201
),
(
    'C# Intermediate', 201
),
(
    'C# Language OOP', 201
)

-- ASP.NET#
INSERT INTO Videos
VALUES
(
    'ASP.NET Core MVC First stepps', 201
),
(
    'ASP.NET Core MVC Deep Dive', 201
),
(
    'ASP.NET Core MVC Advanced Topics', 201
)

-- ASP.NET#
INSERT INTO Videos
VALUES
(
    'MS SQL Server 2002: Installation and Config', 301
),
(
    'MS SQL Server 2002: Query Statements', 301
),
(
    'MS SQL Server 2002: Administration', 301
)

-- ICDL#
INSERT INTO Videos
VALUES
(
    'ICDL: The Complete Course', 501
)

-- Tables quries
SELECT *
FROM Students;

SELECT *
FROM Videos;

SELECT *
FROM Courses;

