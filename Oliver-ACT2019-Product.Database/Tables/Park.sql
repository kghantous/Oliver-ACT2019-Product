CREATE TABLE [dbo].[Park]
(
	[Id] INT NOT NULL PRIMARY KEY Identity,
	[Name] varchar(50) NOT NULL, 
    [State_Id] INT NOT NULL, 
    [Location] VARCHAR(50) NULL
)
