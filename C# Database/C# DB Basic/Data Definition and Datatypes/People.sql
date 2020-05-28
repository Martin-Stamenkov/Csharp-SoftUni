USE Minions

CREATE TABLE People(
	Id INT PRIMARY KEY IDENTITY NOT NULL,
	[Name] NVARCHAR(200) NOT NULL,
	Picture VARBINARY(MAX) 
	CHECK(DATALENGTH(Picture) <= 2000 * 1024),
    Height NUMERIC(3,2),
	[Weight] NUMERIC(5,2),
	Gender CHAR(1) NOT NULL,
	Birthdate DATE NOT NULL,
	Biography TEXT
)

INSERT INTO People([Name],Height,[Weight],Gender,Birthdate,Biography)
	VALUES
		('Pesho Peshev',1.50,90,'m','05.15.1964','My Biography'),
		('Yordanka Fandukova',1.80,50,'f','03.11.1969','My Biography'),
		('Nasko Sirakov',1.75,80,'m','07.17.1969','My Biography'),
		('Vasil Bojkov',1.72,75,'m','03.13.1955','My Biography'),
		('Georgi Kuzmanov',1.19,100,'m','03.02.1959','My Biography')


		SELECT * FROM People 
