CREATE TABLE [dbo].[Vehicle]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
	[OwnerId] INT NOT NULL,
	[Brand] NVARCHAR(50) NOT NULL, 
	[Model] NVARCHAR(50) NOT NULL, 
	[Year] DATETIME NOT NULL,
    [Mileage] INT NOT NULL,
    [AverageMileage] INT NOT NULL,
	[Color] NVARCHAR(50) NOT NULL,
	[EngineDisplacement] DECIMAL(18, 0) NOT NULL,
    [HorsePower] INT NOT NULL, 
	[Torque] INT NOT NULL, 
    [FuelType] INT NOT NULL,
	[Description] NVARCHAR(50) NOT NULL,  
    [VehicleType] INT NOT NULL, 
    CONSTRAINT [FK_Owner_Vehicle] FOREIGN KEY (OwnerId) REFERENCES [User]([UKey]) 
)