CREATE DATABASE EntityRelations

USE EntityRelations


CREATE TABLE Passports
(
	 Id INT PRIMARY KEY IDENTITY(101,1),
	 PassportNumber CHAR(8) NOT NULL
)

CREATE TABLE Persons
(
	 Id INT PRIMARY KEY IDENTITY,
	 FirstName NVARCHAR(8) NOT NULL,
	 Salary DECIMAL(7,2) NOT NULL,
	 PassportID INT NOT NULL FOREIGN KEY  REFERENCES Passports(Id) UNIQUE
)

INSERT INTO Passports(PassportNumber)
	VALUES
	('N34FG21B'),
	('K65LO4R7'),
	('ZE657QP2')

INSERT INTO Persons(FirstName,Salary,PassportID)
	VALUES
	('Roberto',43300.00,102),
	('Tom',56100.00,103),
	('Yana',60200.00,101)

