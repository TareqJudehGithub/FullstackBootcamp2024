USE SAMPLEDB;

-- Return first name and  last name from employees table.
SELECT first_name, last_name
FROM hcm.employees emp;

-- Return last_name and city for all customers. Alias last name to customer_last_name
SELECT last_name AS customr_last_name, city
FROM hcm.employees
GO

-- Return all columns from the oes.order_items table
SELECT *
FROM oes.order_items
GO
