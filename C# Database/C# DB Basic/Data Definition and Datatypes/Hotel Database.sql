CREATE DATABASE HotelDatabase

USE HotelDatabase

CREATE TABLE Employees( 
	Id BIGINT PRIMARY KEY IDENTITY NOT NULL,
	FirstName NVARCHAR(20) NOT NULL,
	LastName NVARCHAR(20) NOT NULL,
	Title NVARCHAR(20),
	Notes NVARCHAR(20)
)
INSERT INTO Employees(FirstName,LastName)
		VALUES
		('Petyr','Petrov'),
		('Georgi','Georgiev'),
		('Ivan','Ivanov')

		--SELECT * FROM Employees

CREATE TABLE Customers( 
	AccountNumber BIGINT PRIMARY KEY IDENTITY NOT NULL,
	FirstName NVARCHAR(20) NOT NULL,
	LastName NVARCHAR(20) NOT NULL,
	PhoneNumber NVARCHAR(20) NOT NULL,
	EmergencyName NVARCHAR(20),
	EmergencyNumber NVARCHAR(20),
	Notes NVARCHAR(20)
)

INSERT INTO Customers(FirstName,LastName,PhoneNumber)
		VALUES
		('Georgi','Petrov','098-757-6892'),
		('Petyr','Georgiev','098-457-6892'),
		('Maria','Ivanova','098-766-8892')

		--SELECT * FROM Customers

CREATE TABLE RoomStatus( 
	RoomStatus NVARCHAR(20) PRIMARY KEY  NOT NULL,
	Notes NVARCHAR(20)
)

INSERT INTO RoomStatus(RoomStatus)
		VALUES
		('Available'),
		('Pending'),
		('Booked')

		--SELECT * FROM RoomStatus


CREATE TABLE RoomTypes( 
	RoomTypes NVARCHAR(20) PRIMARY KEY  NOT NULL,
	Notes NVARCHAR(20)
)

INSERT INTO RoomTypes(RoomTypes)
		VALUES
		('Single'),
		('Double'),
		('Studio')
		truncate table RoomTypes

	--SELECT * FROM RoomTypes

CREATE TABLE BedType( 
	BedType NVARCHAR(20) PRIMARY KEY  NOT NULL,
	Notes NVARCHAR(20)
)

INSERT INTO BedType(BedType)
		VALUES
		('Single'),
		('Double'),
		('Kid')

	--SELECT * FROM BedType

CREATE TABLE Rooms( 
	RoomNumber INT PRIMARY KEY IDENTITY  NOT NULL,
	RoomType NVARCHAR(20) FOREIGN KEY REFERENCES RoomTypes(RoomTypes) NOT NULL,
	RoomStatus NVARCHAR(20) FOREIGN KEY REFERENCES RoomStatus(RoomStatus) NOT NULL,
	BedType NVARCHAR(20) FOREIGN KEY REFERENCES BedType(BedType) NOT NULL,
	Rate INT,
	Notes NVARCHAR(20)
)

INSERT INTO Rooms(RoomType,RoomStatus,BedType)
		VALUES
		('Single','Available','Single'),
		('Double','Available','Double'),
		('Studio','Booked','Double')

	SELECT * FROM Rooms

CREATE TABLE Payments( 
	Id INT PRIMARY KEY IDENTITY  NOT NULL,
	EmployeeId BIGINT FOREIGN KEY REFERENCES Employees(Id) NOT NULL,
	PaymentDate Date,
	AccountNumber BIGINT FOREIGN KEY REFERENCES Customers(AccountNumber) NOT NULL,
	FirstDateOccupied Date NOT NULL ,
	LastDateOccupied Date NOT NULL,
	TotalDays INT,
	AmountCharged DECIMAL(6,2),
	TaxRate DECIMAL(6,2),
	TaxAmount DECIMAL(6,2),
	PaymentTotal DECIMAL(6,2) NOT NULL,
	Notes NVARCHAR(20)
)

INSERT INTO Payments(EmployeeId,AccountNumber,FirstDateOccupied,LastDateOccupied,PaymentTotal)
		VALUES
		(1,1,'06.12.2020','06.18.2020',500),
		(1,2,'06.12.2020','06.18.2020',500),
		(2,3,'06.12.2020','06.18.2020',500)

	--SELECT * FROM Payments

CREATE TABLE Occupancies( 
	Id INT PRIMARY KEY IDENTITY  NOT NULL,
	EmployeeId BIGINT FOREIGN KEY REFERENCES Employees(Id) NOT NULL,
	DateOccupied Date,
	AccountNumber BIGINT FOREIGN KEY REFERENCES Customers(AccountNumber) NOT NULL,
	RoomNumber INT FOREIGN KEY REFERENCES Rooms(RoomNumber) NOT NULL,
	RateApplied INT NOT NULL ,
	PhoneCharge DECIMAL(6,2),
	Notes NVARCHAR(20)
)

INSERT INTO Occupancies(EmployeeId,AccountNumber,RoomNumber,RateApplied)
		VALUES
		(1,1,4,10),
		(1,2,5,10),
		(2,3,6,10)

	--SELECT * FROM Occupancies
