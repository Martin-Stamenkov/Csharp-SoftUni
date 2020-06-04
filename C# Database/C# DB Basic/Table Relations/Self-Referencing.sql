
CREATE TABLE Teachers
(
	TeacherId INT PRIMARY KEY IDENTITY(101,1),
	[Name] NVARCHAR(30) NOT NULL,
	ManagerID INT FOREIGN KEY REFERENCES Teachers(TeacherId)
)

INSERT INTO Teachers([Name],ManagerID)
	VALUES
	('John',NULL),
	('Maya',106),
	('Silvia',106),
	('Ted',105),
	('Mark',101),
	('Greta',101)