 -- EDIT column name
 EXEC sp_rename 'dbo.Employees.DelMe', 'RemoveMe', 'COLUMN';
 