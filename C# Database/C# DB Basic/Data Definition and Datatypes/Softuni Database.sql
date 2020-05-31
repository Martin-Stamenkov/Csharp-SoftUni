CREATE DATABASE SoftUni

USE SoftUni

CREATE TABLE Towns(
	Id INT PRIMARY KEY IDENTITY,
	[Name] NVARCHAR(30) NOT NULL,
)

CREATE TABLE Addresses(
	Id INT PRIMARY KEY IDENTITY,
	AddressText TEXT NOT NULL,
	TownId INT FOREIGN KEY REFERENCES Towns(Id) NOT NULL 
)

CREATE TABLE Departments(
	Id INT PRIMARY KEY IDENTITY,
	[Name] NVARCHAR(30) NOT NULL,
)

CREATE TABLE Employees(
	Id INT PRIMARY KEY IDENTITY,
	FirstName NVARCHAR(20) NOT NULL,
	MiddleName NVARCHAR(20),
	LastName NVARCHAR(20) NOT NULL,
	JobTitle NVARCHAR(20) NOT NULL,
	DepartmentId INT FOREIGN KEY REFERENCES Departments(Id) NOT NULL,
	HireDate DATE NOT NULL,
	Salary DECIMAL(6,2) NOT NULL,
	AddressId INT FOREIGN KEY REFERENCES Addresses(Id),
)


INSERT INTO Towns 
	VALUES 
	('Sofia'),
	('Plovdiv'),
	('Varna'),
	('Burgas')

INSERT INTO Departments
	VALUES
	('Engineering'),
	('Sales'),
	('Marketing'),
	('Software Development'),
	('Quality Assurance')

INSERT INTO Employees(FirstName,MiddleName,LastName,JobTitle,DepartmentId,HireDate,Salary)
	VALUES
	('Ivan','Ivanov', 'Ivanov','NET Developer',4,'02.01.2013',3500.00),
	('Petar','Petrov', 'Petrov','Senior Engineer',1,'03.02.2004',4000.00),
	('Maria','Petrova', 'Ivanova','Intern',5,'08.28.2016',525.25),
	('Georgi','Terziev', 'Ivanov','CEO',2,'12.09.2007',3000.00),
	('Peter','Pan', 'Pan','Intern',3,'08/28/2016',599.88)

SELECT* FROM Towns

SELECT * FROM Departments

SELECT * FROM Employees

SELECT [Name] FROM Towns
ORDER BY [Name]

SELECT [Name] FROM Departments
ORDER BY [Name]

SELECT FirstName, LastName, JobTitle, Salary FROM Employees
ORDER BY Salary DESC

UPDATE Employees
SET Salary += Salary * 0.10

SELECT Salary FROM Employees

USE Hotel

UPDATE Payments
SET TaxRate -= TaxRate * 0.03

SELECT TaxRate FROM Payments

TRUNCATE TABLE Occupancies
