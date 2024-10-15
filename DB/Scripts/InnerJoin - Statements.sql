-- Switch to your DB
-- USE <Your DB Name>
USE campdb;

-- Inner Join Students and Courses
SELECT C.Id As CourseID, S.StudentName, C.CourseName
FROM Students S
JOIN Courses C on S.CourseId = C.Id;

-- Inner Join Courses and Videos
SELECT C.Id as CourseID, V.VideoTitle, C.CourseName
FROM Videos V 
JOIN Courses C ON V.CourseID = C.Id;

