-- CREATE TABLE statements 

-- Switch to your DB
-- USE <DB name>;

-- Students table and data
CREATE TABLE Students
(
    Id INT PRIMARY KEY IDENTITY (1, 1) NOT NULL,
    StudentName VARCHAR(50) NOT NULL, 
    Gender CHAR(1) NOT NULL,
    DOB DATETIME NOT NULL,
    Degree VARCHAR(10) NOT NULL,
    Address VARCHAR(250),
    City VARCHAR(50),
    IsDeleted BIT
);

-- Student Data
INSERT INTO Students
VALUES
( 'Murad Qassem', 'M', '2002-03-29', 'BA', 'Gardens Street', 'Amman', 'false'),
( 'Dareen Saed', 'F', '1995-07-17', 'Masters', 'Amir Hassan City', 'Irbid', 'false'),
( 'Khaled Al-Razem', 'M', '1971-11-03', 'BA', 'Al-Aashreh', 'Aqaba', 'false'),
( 'Julie AL-Rayan', 'F', '2004-03-29', 'BA',  'Hurrieh Street', 'Zarqa', 'false'),
( 'Elias Shaheen', 'M', '2006-08-27', 'BA',  'Marj Al-Hamam', 'Amman', 'true'),
( 'Faisal Taymoore', 'M', '2001-09-22', 'Masters', 'Al-Jandaweel', 'Amman', 'false'),
( 'Haya Zraiqat', 'F', '1981-01-22', 'PhD ', 'Dahiet Al-Zohoor', 'Irbid', 'false'),
( 'Noor Adnan', 'F', '1981-04-28', 'BA', 'Amir Rashid Area', 'Amman', 'false'),
( 'Sana Bonieh', 'F', '2006-03-15', 'BA',  'Al-Shaab Street', 'Zarqa', 'false'),
( 'Senan Al-Jamal', 'M', '1978-05-02', 'PhD', 'Al-Rabieh', 'Amman', 'false'),
( 'Wael Bakri', 'M', '1968-03-10', 'PhD', 'Swiefieh', 'Amman', 'false'),
( 'Muneer Abu Zaid', 'M', '1991-06-27', 'BA', 'Al-Hamrah', 'Irbid', 'false'),
( 'Salma Ali', 'F', '1985-02-10', 'Masters', 'Wadi Al-Seer', 'Amman', 'true'),
( 'Waleed Muhsen', 'M', '2000-10-01', 'Masters', 'Marka', 'Amman', 'false'),
( 'Reem Basha', 'F', '1992-11-04', 'Masters', 'Olives Trees Suburb', 'Aqaba', 'false'),
( 'Daoud Qazzaz', 'M', '1973-07-20', 'PhD', 'Al-Waibdeh', 'Amman', 'false'),
( 'Rana Salem', 'F', '2002-12-29', 'BA', 'Al-Ghosson Street', 'Irbid', 'true'),
( 'Raed Shayeb', 'M', '2004-03-29', 'BA', 'Al Bayader', 'Amman', 'false'),
( 'Salah Saleem', 'M', '1985-01-11', 'Masters', 'Jabal Al-Taaj', 'Amman', 'false'),
( 'Kamal Naseem', 'M', '1979-10-14', 'PhD', 'Abu Nsair', 'Amman', 'false'),
( 'Lina Waheed', 'F', '2005-9-02', 'BA', 'Al-Rawda', 'Irbid', 'false'),
( 'Khadijah Ahmad', 'F', '1993-03-12', 'PhD', 'Al-Nakheel Suburb', 'Aqaba', 'false'),
( 'George Hazeen', 'M', '1983-12-05', 'Masters', 'Jabal Al-Hussain', 'Amman', 'true'),
( 'William Khouri', 'M', '2003-12-07', 'BA', 'Al Rawabi', 'Aqaba', 'false'),
( 'Sarah Tamer', 'F', '2002-08-02', 'BA', 'Wadi Saqra', 'Amman', 'false'),
( 'Ghazzi Khayat', 'M', '1986-05-04', 'BA', 'Fountains Street', 'Zarqa', 'false'),
( 'Rand Saleh', 'F', '2006-10-17', 'Masters', 'Jabal Al-Yasmeen', 'Irbid', 'false'),
( 'Adnan yousef', 'M', '2000-03-11', 'BA', 'Jabal Al-Mareekh', 'Amman', 'true'),
( 'Andrea Tarazi', 'M', '1984-06-26', 'PhD', 'Sport City', 'Aqaba', 'false'),
( 'Aseel Hanah', 'F', '1999-12-31', 'BA', 'Al-Amal Suburb', 'Zarqa', 'false'),
( 'Ahmad Zaidoun', 'M', '2000-05-27', 'PhD', 'Hurrieh Street', 'Zarqa', 'false'),
( 'Zaid Ali', 'M', '1998-05-13', 'BA', 'Al-Zohor Street', 'Aqaba', 'false')


-- Courses Table and data
CREATE TABLE Courses
(
    Id INT PRIMARY KEY IDENTITY (101, 100) NOT NULL,
    CourseName VARCHAR(50) NOT NULL,
    Category VARCHAR(20),
    Price DECIMAL (18, 3) NOT NULL,
    StartDate DATETIME NOT NULL,
    EndtDate DATETIME NOT NULL,
    Description VARCHAR(250)
);

INSERT INTO Courses
VALUES
(
  'Frontend Developer', 'We Development', 29.99, '2024-09-10', '2024-12-30', 'Everything you need to become a master frontend web developer'
),
(
  'Backend Developer', 'We Development', 39.99, '2024-11-15', '2025-01-20', 'Master ASP.NET Core MVC 8.0'
),
(
    'MS SQL 2022', 'Database', 19.99, '2023-06-15', '2023-07-15', 'MS SQL Server 2022 Query and Administration'
),
(
    'Cyber Security 2024', 'Security', 49.99, '2022-02-01', '2022-05-31', 'Security of Local and Global networks.'
),
(
    'ICDL', 'Office', 14.99, '2021-01-20', '2021-02-17', 'MS Office 2024.'
);

