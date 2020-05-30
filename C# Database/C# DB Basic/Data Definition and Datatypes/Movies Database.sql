CREATE DATABASE Movies

USE Movies

CREATE TABLE Directors(
	Id BIGINT PRIMARY KEY IDENTITY NOT NULL,
	DirectorName NVARCHAR(20) NOT NULL,
	Notes TEXT 
)
CREATE TABLE Genres(
	Id BIGINT PRIMARY KEY IDENTITY NOT NULL,
	GenreName NVARCHAR(20) NOT NULL,
	Notes TEXT 
)
CREATE TABLE Categories(
	Id BIGINT PRIMARY KEY IDENTITY NOT NULL,
	CategoryName NVARCHAR(20) NOT NULL,
	Notes TEXT 
)
CREATE TABLE Movies(
	Id BIGINT PRIMARY KEY IDENTITY NOT NULL,
	DirectorId BIGINT FOREIGN KEY REFERENCES Directors(Id) NOT NULL,
	GenreId BIGINT FOREIGN KEY REFERENCES Genres(Id) NOT NULL,
	CategoryId BIGINT FOREIGN KEY REFERENCES Categories(Id) NOT NULL,
	Title NVARCHAR(30) NOT NULL,
	Rating INT,
	CopyrightYear INT NOT NULL,
	[Length] TIME,
	Notes TEXT 
)

INSERT INTO Directors(DirectorName)
			VALUES
			('George Lucas'),
			('Kevin Nolan'),
			('Martin Skorseze'),
			('Stephen Spelberg'),
			('Marian Vulev')

			SELECT * FROM Directors

INSERT INTO Genres(GenreName)
			VALUES
			('Fantastic'),
			('Thriller'),
			('Fantastic'),
			('Fantastic'),
			('Drama')

			SELECT * FROM Genres


INSERT INTO Categories(CategoryName)
			VALUES
			('Fantastic movies'),
			('Thriller movie'),
			('Fantastic movie'),
			('Fantastic movie'),
			('Drama movie')

			SELECT * FROM Categories

INSERT INTO Movies(DirectorId,CopyrightYear,GenreId,CategoryId,Title)
			VALUES
			(1,1976,1,1,'Star Wars'),
			(2,2010,2,2,'Genesis'),
			(3,2012,3,3,'Jango without chain'),
			(4,2009,4,4,'Avatar'),
			(5,2020,5,5,'Qtagan')

			SELECT * FROM Movies



    --• Directors (Id, DirectorName, Notes)
    --• Genres (Id, GenreName, Notes)
    --• Categories (Id, CategoryName, Notes)
    --• Movies (Id, Title, DirectorId, CopyrightYear, Length, GenreId, CategoryId, Rating, Notes)