CREATE DATABASE Companie;
USE Companie;


CREATE TABLE Countries (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(100)
);


CREATE TABLE Cities (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(100),
    CountryId INT FOREIGN KEY REFERENCES Countries(Id)
);


CREATE TABLE Employees (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(100),
    Surname NVARCHAR(100),
    Age INT,
    Salary DECIMAL(10,2),
    Position NVARCHAR(100),
    CityId INT FOREIGN KEY REFERENCES Cities(Id),
    IsDeleted BIT
);


INSERT INTO Countries (Name) VALUES
('Azerbaijan'),
('Turkey'),
('USA');


INSERT INTO Cities (Name, CountryId) VALUES
('Baku', 1),
('Ganja', 1),
('Istanbul', 2),
('Ankara', 2),
('New York', 3);


INSERT INTO Employees (Name, Surname, Age, Salary, Position, CityId, IsDeleted) VALUES
('Ali', 'Aliyev', 30, 1500, 'Reception', 1, 0),
('Aysel', 'Huseynova', 25, 2500, 'Manager', 3, 0),
('Rashad', 'Karimov', 40, 1800, 'Developer', 2, 1),
('Leyla', 'Mammadova', 28, 3200, 'Developer', 5, 0),
('Murad', 'Ismayilov', 35, 2100, 'Reception', 4, 1);


SELECT 
    E.Id,
    E.Name,
    E.Surname,
    E.Age,
    E.Salary,
    E.Position,
    Ci.Name AS City,
    Co.Name AS Country
FROM Employees E
JOIN Cities Ci ON E.CityId = Ci.Id
JOIN Countries Co ON Ci.CountryId = Co.Id
WHERE E.IsDeleted = 0;


SELECT
    E.Name,
    E.Surname,
    E.Salary,
    Co.Name AS Country
FROM Employees E
JOIN Cities Ci ON E.CityId = Ci.Id
JOIN Countries Co ON Ci.CountryId = Co.Id
WHERE E.Salary > 2000 AND E.IsDeleted = 0;


SELECT
    Ci.Name AS City,
    Co.Name AS Country
FROM Cities Ci
JOIN Countries Co ON Ci.CountryId = Co.Id;


SELECT 
    E.Name,
    E.Surname,
    E.Age,
    E.Salary,
    E.Position,
    Ci.Name AS City,
    Co.Name AS Country
FROM Employees E
JOIN Cities Ci ON E.CityId = Ci.Id
JOIN Countries Co ON Ci.CountryId = Co.Id
WHERE E.Position = 'Reception' AND E.IsDeleted = 0;


SELECT
    E.Name,
    E.Surname,
    Ci.Name AS City,
    Co.Name AS Country
FROM Employees E
JOIN Cities Ci ON E.CityId = Ci.Id
JOIN Countries Co ON Ci.CountryId = Co.Id
WHERE E.IsDeleted = 1;
