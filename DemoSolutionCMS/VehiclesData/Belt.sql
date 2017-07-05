CREATE TABLE [dbo].[Belt]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [Range] INT NOT NULL, 
    [MonthsToChange] INT NOT NULL, 
    [ChangedDate] DATETIME NOT NULL, 
    [Brand] NVARCHAR(50) NOT NULL, 
    [Model] NVARCHAR(50) NOT NULL, 
    [Description] NVARCHAR(50) NOT NULL, 
    [VehicleId] INT NOT NULL
	CONSTRAINT [FK_Belt_Vehicle] FOREIGN KEY ([VehicleId]) REFERENCES [Vehicle]([Id]) 
)
