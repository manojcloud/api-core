﻿CREATE TABLE [dbo].[Author]
(
	[Id] INT IDENTITY(1,1) NOT NULL,
	[FirstName] NVARCHAR(50) NOT NULL,
	[LastName] NVARCHAR(50) NOT NULL,
	[Country] NVARCHAR(100) NOT NULL,
	[DateCreated] DATETIME NOT NULL,
	[UserCreated] NVARCHAR(50) NOT NULL,
	[DateModified] DATETIME NULL,
	[UserModified] NVARCHAR(50) NULL,
	[IsDeleted] BIT NOT NULL
)
GO

ALTER TABLE [dbo].[Author] ADD
	CONSTRAINT [PK_Author] PRIMARY KEY ([Id] DESC)
GO