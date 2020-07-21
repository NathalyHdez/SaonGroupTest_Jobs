-- Script Date: 7/20/2020 9:17 PM  - ErikEJ.SqlCeScripting version 3.5.2.86
CREATE TABLE [Jobs] (
  [Job] int NOT NULL
, [JobTitle] varchar(100) NOT NULL
, [Description] varchar(255) NOT NULL
, [CreatedAt] datetime NOT NULL
, [ExpiresAt] datetime NULL
, CONSTRAINT [PK_Jobs] PRIMARY KEY ([Job])
);

