CREATE DATABASE Minions

USE Minions

CREATE TABLE Minions(
	Id INT PRIMARY KEY NOT NULL,
	[Name] NVARCHAR(50) NOT NULL,
	Age INT

)

CREATE TABLE Towns(
	Id INT PRIMARY KEY NOT NULL,
	[Name] NVARCHAR(20) NOT NULL,
)

ALTER TABLE Minions
	ADD TownId INT FOREIGN KEY REFERENCES Towns(Id)

INSERT INTO Towns 
	VALUES
		(1,'Sofia'),
		(2,'Plovdiv'),
		(3,'Varna')


INSERT INTO Minions
	VALUES 
		(1,'Kevin',22,1),
		(2,'Bob',15,3),
		(3,'Steward',NULL,2)

	SELECT * FROM Minions

	SELECT * FROM Towns