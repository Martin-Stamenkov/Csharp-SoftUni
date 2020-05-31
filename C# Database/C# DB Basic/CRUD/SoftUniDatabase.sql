USE SoftUni

SELECT * FROM Departments

SELECT [Name] FROM Departments

SELECT FirstName,LastName,Salary FROM Employees

SELECT FirstName,MiddleName,LastName FROM Employees

SELECT FirstName + '.' + LastName  + '@softuni.bg' AS [Full Email Addres] FROM Employees

SELECT DISTINCT Salary FROM Employees

SELECT * FROM Employees
	WHERE JobTitle LIKE 'Sales Representative';

SELECT FirstName,LastName,JobTitle FROM Employees
	WHERE Salary >=20000 AND Salary<=30000

SELECT FirstName + ' ' +  MiddleName + ' ' + LastName AS FullName FROM Employees
		WHERE Salary IN (25000, 14000, 12500 , 23600)

SELECT FirstName, LastName FROM Employees
WHERE ManagerID IS NULL

SELECT FirstName, LastName, Salary FROM Employees
WHERE Salary > 50000
ORDER BY Salary DESC

SELECT TOP(5) FirstName, LastName FROM Employees
WHERE Salary > 50000
ORDER BY Salary DESC

SELECT FirstName , LastName FROM Employees
WHERE DepartmentID != 4

SELECT * FROM Employees
ORDER BY Salary DESC , FirstName ASC, LastName DESC, MiddleName ASC

GO

CREATE VIEW [V_EmployeesSalaries] 
	AS SELECT FirstName, LastName, Salary 
		FROM Employees
		
GO

CREATE VIEW [V_EmployeeNameJobTitle] 
	AS SELECT FirstName + ' ' + ISNULL(MiddleName,'') + ' ' + LastName AS FullName, JobTitle
		FROM Employees

SELECT * FROM V_EmployeeNameJobTitle

SELECT DISTINCT JobTitle FROM Employees

SELECT TOP(10)* FROM Projects
	ORDER BY StartDate ASC , [Name] ASC

SELECT TOP(7) FirstName,LastName, HireDate FROM Employees
ORDER BY HireDate DESC

SELECT * FROM Employees

SELECT * FROM Departments

UPDATE Employees
SET Salary += Salary * 0.12
WHERE DepartmentID IN (4,11,1,2)

SELECT Salary FROM Employees

