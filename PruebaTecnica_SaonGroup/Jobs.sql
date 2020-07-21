CREATE TABLE [dbo].[Table]
(
    [Job] VARCHAR(50) NOT NULL, 
    [JobTitle] VARCHAR(128) NOT NULL, 
    [Description] VARCHAR(255) NOT NULL, 
    [CreatedAt] DATETIME NOT NULL, 
    [ExpiresAt] DATETIME NOT NULL, 
    CONSTRAINT [PK_Jobs] PRIMARY KEY ([Column])
)
