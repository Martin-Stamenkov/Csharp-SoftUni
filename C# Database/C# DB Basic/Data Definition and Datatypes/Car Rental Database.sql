CREATE DATABASE CarRental

USE CarRental

CREATE TABLE Categories(
	Id BIGINT PRIMARY KEY IDENTITY NOT NULL,
	CategoryName NVARCHAR(20) NOT NULL,
	DailyRate INT,
	WeeklyRate INT,
	MonthlyRate INT,
	WeekendRate INT
)

CREATE TABLE Cars(
	Id BIGINT PRIMARY KEY IDENTITY NOT NULL,
	PlateNumber INT NOT NULL,
	Manufacturer NVARCHAR(20) NOT NULL, 
	Model NVARCHAR(20) NOT NULL,
	CarYear INT NOT NULL,
	CategoryId BIGINT FOREIGN KEY REFERENCES Categories(Id) NOT NULL,
	Doors INT NOT NULL,
	Picture VARBINARY(MAX),
	Condition BIT,
	Available BIT NOT NULL,
)

CREATE TABLE Employees( 
	Id BIGINT PRIMARY KEY IDENTITY NOT NULL,
	FirstName NVARCHAR(20) NOT NULL,
	LastName NVARCHAR(20) NOT NULL,
	Title NVARCHAR(20),
	Notes NVARCHAR(20),
)

CREATE TABLE Customers( 
	Id BIGINT PRIMARY KEY IDENTITY NOT NULL,
	DriverLicenceNumber BIGINT NOT NULL,
	FullName NVARCHAR(20) NOT NULL,
	[Address] NVARCHAR(20) NOT NULL,
	City NVARCHAR(20)  NOT NULL,
	ZIPCode INT,
	Notes INT,
)
CREATE TABLE RentalOrders(
	Id BIGINT PRIMARY KEY IDENTITY NOT NULL,
	EmployeeId BIGINT FOREIGN KEY REFERENCES Employees(Id) NOT NULL,
	CustomerId BIGINT FOREIGN KEY REFERENCES Customers(Id) NOT NULL,
	CarId BIGINT FOREIGN KEY REFERENCES Cars(Id) NOT NULL,
	TankLevel INT NOT NULL,
	KilometrageStart INT NOT NULL, 
	KilometrageEnd INT,
	TotalKilometrage INT, 
	StartDate DATE NOT NULL,
	EndDate DATE NOT NULL,
	TotalDays INT ,
	RateApplied INT,
	TaxRate INT,
	OrderStatus BIT NOT NULL,
	Notes NVARCHAR(30)
)
 
INSERT INTO Categories(CategoryName)
		VALUES
		('Coupe'),
		('Sedan'),
		('Bus')

INSERT INTO Cars(PlateNumber,Manufacturer,Model,Doors,CarYear,CategoryId,Available)
		VALUES
		(12546,'Seat','Ibiza',4,2015,1,1 ),
		(21547,'Audi','A6',5,2016,2,0),
		(15412,'Mercedez','Tourizmo',6,2019,3,1)

INSERT INTO Employees(FirstName,LastName)
		VALUES
		('Petyr','Petrov'),
		('Georgi','Georgiev'),
		('Ivan','Ivanov')

INSERT INTO Customers(DriverLicenceNumber,FullName,[Address],City)
		VALUES
		(12546436,'Martin Stamenkov','ul, tsar Osvoboditel','Sofia'),
		(21547455,'Ivan Petrov','ul. Skopie','Sofiq'),
		(15412223,'Mariq Ivanova','ul. Stefan Stambolov','Sofia')

INSERT INTO RentalOrders(EmployeeId,CustomerId,CarId,TankLevel,KilometrageStart,StartDate,EndDate,OrderStatus)
		VALUES
		(1,1,1,5,50000,'05.15.2020','05.21.2020',1),
		(1,2,2,7,50000,'05.15.2020','05.21.2020',1),
		(2,1,1,5,50000,'05.15.2020','05.21.2020',0)