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