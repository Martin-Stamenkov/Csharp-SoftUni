USE SoftUni

SELECT DepartmentID, SUM(Salary) AS TotalSalary FROM Employees
GROUP BY DepartmentID

SELECT DepartmentID, MIN(Salary) AS MinimumSalary FROM Employees
WHERE DepartmentID IN(2,5,7) AND HireDate> '01/01/2000'
GROUP BY DepartmentID

SELECT * INTO EmployeesWithHighestSalary FROM Employees
WHERE Salary > 30000

DELETE FROM EmployeesWithHighestSalary
WHERE ManagerID = 42

UPDATE EmployeesWithHighestSalary
SET Salary += 5000
WHERE DepartmentID = 1

SELECT DepartmentID,AVG(Salary) FROM EmployeesWithHighestSalary
GROUP BY DepartmentID

SELECT DepartmentID,MAX(Salary) AS MaxSalary FROM Employees
GROUP BY DepartmentID
HAVING MAX(Salary) < 30000 OR MAX(Salary) > 70000

SELECT COUNT(Salary) FROM Employees
WHERE ManagerID IS NULL

SELECT DepartmentID,Salary FROM  ( SELECT DepartmentID ,
		Salary,
		DENSE_RANK() OVER (PARTITION BY DepartmentID ORDER BY Salary DESC) AS SalaryRank  
		FROM Employees
		GROUP BY DepartmentID,Salary) AS Salaries
	WHERE SalaryRank=3


SELECT TOP(10) e.FirstName,e.LastName,e.DepartmentID FROM Employees AS e
WHERE e.Salary > (
					SELECT AVG(Salary) AS AverageSalary 
					FROM Employees as eAvgSalary
					WHERE eAvgSalary.DepartmentID = e.DepartmentID
					GROUP BY DepartmentID 
					)

