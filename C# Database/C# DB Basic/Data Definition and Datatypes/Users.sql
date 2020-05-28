USE Minions

CREATE TABLE Users(
	Id BIGINT PRIMARY KEY IDENTITY NOT NULL ,
	Username VARCHAR(30) UNIQUE NOT NULL,
	[Password] VARCHAR(26) NOT NULL,
	ProfilePicture VARBINARY(MAX)
	CHECK(DATALENGTH(ProfilePicture) <= 900 *1024),
	LastLoginTime DATETIME2 NOT NULL,
	IsDeleted BIT NOT NULL
)

INSERT INTO Users(Username,[Password],LastLoginTime,IsDeleted)
	VALUES
		('Pesho0','Pesho123456','05.11.2020',0),
		('Pesho1','Pesho123456','05.11.2020',1),
		('Pesho2','Pesho123456','05.11.2020',0),
		('Pesho3','Pesho123456','05.11.2020',1),
		('Pesho4','Pesho123456','05.11.2020',0)

		SELECT * FROM Users


	