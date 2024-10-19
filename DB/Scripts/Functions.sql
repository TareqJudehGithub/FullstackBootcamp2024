-- Switch to your DB
USE CoderZ;

-- INLINE function
CREATE FUNCTION fn_ILTVF_GetEmployees()                                     -- Function head
RETURNS TABLE                                                                -- Return Type
AS                                                                          -- function body
RETURN 
(
    SELECT Id, FirstName, CAST(HireDate as Date) AS HireDate
    FROM Employees
)
GO
-- Function Call
SELECT * 
FROM fn_ILTVF_GetEmployees()

-- Multistatement table valued function (MSTVF)
CREATE FUNCTION fn_MSTVF_GetEmployees()
RETURNS @EmpTable TABLE 
(Id int, FullName NVARCHAR(50), HireDate Date)
AS
BEGIN
    INSERT INTO @EmpTable
    SELECT Id, FirstName + ' ' + ISNULL(LastName, ''), CAST(HireDate as Date)
    FROM Employees
    RETURN
END


-- SQL Functions - Calculate Age - Scalar Functions
CREATE FUNCTION fn_FindAge(@DOB Date)   -- function head
RETURNS INT                                 -- Function return type
AS                                         -- Function Body
BEGIN
    DECLARE @Age INT
    SET @Age = DATEDIFF(YEAR, @DOB, GETDATE()) -
    CASE WHEN (MONTH(@DOB) > MONTH(GETDATE())) OR
    (MONTH(@DOB) = MONTH(GETDATE()) AND 
    DAY(@DOB) > DAY(GETDATE()))
    THEN 1 ELSE 0 END
    RETURN @Age
END

-- Call function
SELECT fn_computeAge(CAST(DOB AS Date)) AS Age
FROM fn_computeAge
GO

