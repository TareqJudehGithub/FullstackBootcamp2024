SELECT DB_NAME();
-- Insert rows into table 'TableName' in schema '[dbo]'
INSERT INTO Employees
VALUES
( -- First row: values for the columns in the list above
 1, 'John', 'Smith', 'M', '2000-12-27', 'Spring Fields Gardens, New York, USA', 750, 0.75, 'IT'
);

-- ADD rows (data to columns)
INSERT INTO Employees
VALUES
(
    2, 'Sarah', 'Adams', 'F', '1997-9-13', 'Berlin, Germany', 1500, 0.75, 'HR'
);


INSERT INTO Employees
VALUES
(
    3, 'Ali', 'Mustafa', 'M', '1987-05-17', 'Amman, Jordan', 987.5, 0.75, 'ACC'
);


INSERT INTO Employees
VALUES
(
    4, 'Reem', 'Mohsen', 'M', '1979-12-16', 'Damascus, Syria', 1250, 0.75, 'IT', 'Web Developer'
);

INSERT INTO Employees
VALUES
(
    5, 'Eman', 'Basheer', 'F', '1995-10-07', 'Irbid, Jordan', 785.5, 0.75, 'HR', 'Receptionist'
);

USE campdb;

SELECT *
FROM Employees;

ALTER TABLE Employees
DROP COLUMN RemoveMe;




