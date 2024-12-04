-- Add new column to Students table: CourseID
ALTER TABLE Students
ADD CourseId INT;

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