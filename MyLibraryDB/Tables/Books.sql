CREATE TABLE [dbo].[Book]
(
	[Id_Book] INT NOT NULL PRIMARY KEY,
	[Title] NVARCHAR(50) NOT NULL,
	[Id_Author] INT NOT NULL,
	[NoOfPages] INT NOT NULL,
	[Id_Language] INT NOT NULL,
	[Year] INT NOT NULL,
	[Borrowed] BIT DEFAULT 0,
	[Borrowable] BIT DEFAULT 0,
	[ISBN] NVARCHAR(50) NOT NULL,
	[Id_Genre] int NOT NULL

);

/*ALTER TABLE [dbo].[Book] ADD CONSTRAINT [Id_Language] FOREIGN KEY ([ID]) REFERENCES [dbo].[Language]
*/