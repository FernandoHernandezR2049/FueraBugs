CREATE TABLE [dbo].[Ticket]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Title] NVARCHAR(50) NOT NULL, 
    [Description] NVARCHAR(200) NULL, 
    [Priority] INT NOT NULL, 
    [Status] INT NOT NULL DEFAULT 1, 
    [CreationDate] DATETIME2 NOT NULL DEFAULT getutcdate(), 
    [CompletitionDate] DATETIME2 NULL 
)
