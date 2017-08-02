CREATE TABLE [dbo].[Author]
(
	[Id_Author] INT NOT NULL PRIMARY KEY,
	[FirstName] NVARCHAR(50) NOT NULL,
	[SecondName] NVARCHAR(50) NOT NULL,
	[DateOfBirth] DATE NOT NULL,
	[DateOfDeath] DATE,
	[Bibiliography] NVARCHAR,
	[NoOfBooks] INT
)
