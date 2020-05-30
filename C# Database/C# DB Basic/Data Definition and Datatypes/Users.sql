USE Minions

CREATE TABLE Users(
	Id BIGINT PRIMARY KEY IDENTITY NOT NULL ,
	Username VARCHAR(30) UNIQUE NOT NULL,
	[Password] VARCHAR(26) NOT NULL,
	ProfilePicture VARBINARY(MAX)
	CHECK(DATALENGTH(ProfilePicture) <= 900 *1024),
	LastLoginTime DATETIME2,
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

ALTER TABLE Users
DROP CONSTRAINT [PK__Users__3214EC079C64837D]

ALTER TABLE Users
ADD CONSTRAINT PK_Users_CompositeIdUsername
PRIMARY KEY (Id,Username)

ALTER TABLE Users
ADD CONSTRAINT CK_Users_Password
CHECK(LEN([Password]) >=5
)

ALTER TABLE Users
ADD CONSTRAINT CK_Users_DefaultDateTime
DEFAULT	GETDATE() FOR LastLoginTime

INSERT INTO Users(Username,[Password],IsDeleted)		
		VALUES
			('Pesho','12356',0)

SELECT * FROM Users


ALTER TABLE Users
DROP CONSTRAINT PK_Users_CompositeIdUsername

ALTER TABLE Users
ADD CONSTRAINT PK_Users_Id
PRIMARY KEY(Id)
