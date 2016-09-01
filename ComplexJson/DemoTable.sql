CREATE TABLE [dbo].[Demo]
(
    [EmployeeId] INT NOT NULL PRIMARY KEY,
    [EmployeeCode] NVARCHAR(50) NOT NULL,
    [ManagerId] INT NOT NULL,
    [FirstName] NVARCHAR(50) NOT NULL,
    [LastName] NVARCHAR(50) NOT NULL,
    [AverageSalePerDay] INT NOT NULL,
    [TotalSales] INT NOT NULL
)

INSERT INTO [dbo].[Demo] ([EmployeeId] ,[EmployeeCode] ,[ManagerId] ,[FirstName] ,[LastName] ,[AverageSalePerDay] ,[TotalSales])
VALUES (1 ,'ABC' ,10 ,'Alex' ,'Shrute' ,12 ,100);

INSERT INTO [dbo].[Demo] ([EmployeeId] ,[EmployeeCode] ,[ManagerId] ,[FirstName] ,[LastName] ,[AverageSalePerDay] ,[TotalSales])
VALUES (2 ,'COD' ,10 ,'Jasmine' ,'Roal' ,35 ,150);

INSERT INTO [dbo].[Demo] ([EmployeeId] ,[EmployeeCode] ,[ManagerId] ,[FirstName] ,[LastName] ,[AverageSalePerDay] ,[TotalSales])
VALUES (3 ,'JAS' ,10 ,'Jsinh' ,'Chauhan' ,25 ,500);

INSERT INTO [dbo].[Demo] ([EmployeeId] ,[EmployeeCode] ,[ManagerId] ,[FirstName] ,[LastName] ,[AverageSalePerDay] ,[TotalSales])
VALUES (4 ,'PAR' ,10 ,'Rex' ,'Maul' ,14 ,233);

INSERT INTO [dbo].[Demo] ([EmployeeId] ,[EmployeeCode] ,[ManagerId] ,[FirstName] ,[LastName] ,[AverageSalePerDay] ,[TotalSales])
VALUES (5 ,'SUR' ,10 ,'Sam' ,'Paulo' ,21 ,200);

INSERT INTO [dbo].[Demo] ([EmployeeId] ,[EmployeeCode] ,[ManagerId] ,[FirstName] ,[LastName] ,[AverageSalePerDay] ,[TotalSales])
VALUES (6 ,'RAM' ,10 ,'Remo' ,'Fernd' ,18 ,321);