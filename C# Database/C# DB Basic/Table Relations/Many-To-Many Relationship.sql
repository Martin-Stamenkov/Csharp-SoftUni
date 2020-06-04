
CREATE TABLE Students 
(
	Id INT PRIMARY KEY IDENTITY ,
	[Name] NVARCHAR(20) NOT NULL,
)

CREATE TABLE Exams 
(
	Id INT PRIMARY KEY IDENTITY(101,1),
	[Name] NVARCHAR(20) NOT NULL,
)

CREATE TABLE StudentsExams 
(
	StudentID INT NOT NULL FOREIGN KEY REFERENCES Students(Id),
	ExamID INT NOT NULL FOREIGN KEY REFERENCES Exams(Id),
	PRIMARY KEY(StudentID,ExamID)
)

INSERT INTO Students([Name])
	VALUES
	('Mila'),
	('Toni'),
	('Roni')

INSERT INTO Exams([Name])
	VALUES
	('SpringMVC'),
	('Neo4j'),
	('Oracle 11g')

INSERT INTO StudentsExams(StudentID,ExamID)
	VALUES
	(1,101),
	(1,102),
	(2,101),
	(3,103),
	(2,102),
	(2,103)

	


