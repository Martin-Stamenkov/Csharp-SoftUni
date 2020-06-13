USE SoftUni

SELECT TOP(5) e.EmployeeID,e.JobTitle,e.AddressID, a.AddressText FROM Employees AS e
JOIN Addresses AS a ON e.AddressID= a.AddressID
ORDER BY e.AddressID

SELECT TOP(50) e.FirstName,e.LastName,t.[Name],a.AddressText FROM Employees AS e
JOIN Addresses AS a ON e.AddressID=a.AddressID
JOIN Towns AS t ON t.TownID = a.TownID
ORDER BY e.FirstName , e.LastName

SELECT e.EmployeeID,e.FirstName,e.LastName,d.[Name] FROM Employees AS e
JOIN Departments AS d ON d.DepartmentID=e.DepartmentID
WHERE d.[Name] = 'Sales'
ORDER BY e.EmployeeID

SELECT TOP (5) e.EmployeeID,e.FirstName,e.Salary,d.[Name] FROM Employees AS e
JOIN Departments AS d ON d.DepartmentID=e.DepartmentID
WHERE e.Salary > 15000
ORDER BY e.DepartmentID


SELECT TOP(3) e.EmployeeID,e.FirstName FROM Employees AS e
LEFT JOIN EmployeesProjects AS ep ON e.EmployeeID = ep.EmployeeID
WHERE ep.ProjectID IS NULL
ORDER BY e.EmployeeID

SELECT e.FirstName,e.LastName,e.HireDate,d.[Name] FROM Employees AS e
JOIN Departments AS d ON d.DepartmentID=e.DepartmentID
WHERE e.HireDate > '1.1.1999' AND d.[Name] IN ('Sales','Finance')
ORDER BY e.HireDate

SELECT TOP(5) e.EmployeeID,e.FirstName,p.[Name]  FROM Employees AS e
JOIN EmployeesProjects AS ep ON e.EmployeeID = ep.EmployeeID
JOIN Projects AS p ON p.ProjectID = ep.ProjectID
WHERE p.StartDate > '2002.08.13' AND p.EndDate IS NULL
ORDER BY e.EmployeeID

SELECT e.EmployeeID,e.FirstName,
	CASE 
		WHEN DATEPART(YEAR, p.StartDate) >= 2005 THEN NULL
		ELSE p.[Name]
	END AS [ProjectName]
FROM Employees AS e
JOIN EmployeesProjects AS ep ON e.EmployeeID = ep.EmployeeID
JOIN Projects AS p ON p.ProjectID = ep.ProjectID
WHERE e.EmployeeID = 24 

SELECT e.EmployeeID,e.FirstName,m.EmployeeID AS [ManagerID], m.FirstName AS [ManagerName] FROM Employees AS e 
JOIN Employees AS m ON e.ManagerID = m.EmployeeID
WHERE m.EmployeeID IN (3,7)
ORDER BY e.EmployeeID

SELECT TOP(50) e.EmployeeID,CONCAT(e.FirstName ,' ', e.LastName) AS EmployeeName, 
 CONCAT(m.FirstName ,' ', m.LastName) AS [ManagerName],
	d.[Name]
FROM Employees AS e 
JOIN Employees AS m ON e.ManagerID = m.EmployeeID
JOIN Departments AS d ON d.DepartmentID = e.DepartmentID
ORDER BY e.EmployeeID

select * from Employees
ORDER BY DepartmentID

select * from Departments

SELECT MIN([Avarage Salary]) AS MinAverageSalary
 FROM (
 SELECT DepartmentID ,AVG(Salary) AS [Avarage Salary]
 FROM Employees 
 GROUP BY DepartmentID
) AS MinAverageQuery

