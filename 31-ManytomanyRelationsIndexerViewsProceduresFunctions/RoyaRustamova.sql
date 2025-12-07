CREATE DATABASE CompanyMM;

USE CompanyMM;

CREATE TABLE Employees (
    EmployeeID INT IDENTITY(1,1) PRIMARY KEY,
    FirstName VARCHAR(50),
    LastName  VARCHAR(50),
    BirthDate DATE,
    Email     VARCHAR(100) UNIQUE,
    CHECK (BirthDate < '2010-01-01')
);

CREATE TABLE Projects (
    ProjectID INT IDENTITY(1,1) PRIMARY KEY,
    ProjectName VARCHAR(100),
    StartDate DATE,
    EndDate   DATE,
    CHECK (EndDate >= StartDate)
);

CREATE TABLE EmployeeProjects (
    EmployeeID INT NOT NULL,
    ProjectID  INT NOT NULL,
    AssignedDate DATE DEFAULT GETDATE(),

    PRIMARY KEY(EmployeeID, ProjectID),

    FOREIGN KEY(EmployeeID) REFERENCES Employees(EmployeeID),
    FOREIGN KEY(ProjectID)  REFERENCES Projects(ProjectID)
);

INSERT INTO Employees (FirstName, LastName, BirthDate, Email) VALUES
('Aysel', 'Quliyeva', '1995-04-12', 'aysel@mail.com'),
('Ramin', 'Huseynov', '1990-09-25', 'ramin@mail.com'),
('Murad', 'Aliyev',   '1998-02-17', 'murad@mail.com'),
('Kamal', 'Rustamov', '1992-12-03', 'kamal@mail.com'),
('Nigar', 'Ismayilova','1996-07-11','nigar@mail.com');

INSERT INTO Projects (ProjectName, StartDate, EndDate) VALUES
('CRM System Development', '2024-01-01', '2024-12-31'),
('Mobile App Launch',      '2024-03-10', '2024-09-30'),
('Data Migration Project', '2024-02-05', '2024-11-20');

INSERT INTO EmployeeProjects (EmployeeID, ProjectID) VALUES
(1,1),
(1,2),
(2,1),
(3,2),
(3,3),
(4,1),
(5,3);

SELECT * FROM Employees;

SELECT * FROM Projects;

SELECT e.EmployeeID, e.FirstName, e.LastName, p.ProjectName
FROM Employees e
JOIN EmployeeProjects ep ON e.EmployeeID = ep.EmployeeID
JOIN Projects p ON p.ProjectID = ep.ProjectID;

SELECT p.ProjectID, p.ProjectName, COUNT(ep.EmployeeID) AS EmployeeCount
FROM Projects p
LEFT JOIN EmployeeProjects ep ON p.ProjectID = ep.ProjectID
GROUP BY p.ProjectID, p.ProjectName;

SELECT e.EmployeeID, e.FirstName, e.LastName, COUNT(ep.ProjectID) AS ProjectCount
FROM Employees e
JOIN EmployeeProjects ep ON e.EmployeeID = ep.EmployeeID
GROUP BY e.EmployeeID, e.FirstName, e.LastName
HAVING COUNT(ep.ProjectID) > 2;


CREATE VIEW EmployeeProjectView AS
SELECT 
    e.EmployeeID,
    e.FirstName + ' ' + e.LastName AS FullName,
    p.ProjectID,
    p.ProjectName,
    ep.AssignedDate
FROM Employees e
JOIN EmployeeProjects ep ON e.EmployeeID = ep.EmployeeID
JOIN Projects p ON p.ProjectID = ep.ProjectID;


SELECT * FROM EmployeeProjectView WHERE EmployeeID = 1;


GO
CREATE PROCEDURE sp_AssignEmployeeToProject
    @empId INT,
    @projId INT
AS
BEGIN
    IF NOT EXISTS (
        SELECT 1 
        FROM EmployeeProjects
        WHERE EmployeeID = @empId AND ProjectID = @projId
    )
    BEGIN
        INSERT INTO EmployeeProjects (EmployeeID, ProjectID, AssignedDate)
        VALUES (@empId, @projId, GETDATE());
    END
END
GO


GO
CREATE FUNCTION fn_GetProjectCount(@empId INT)
RETURNS INT
AS
BEGIN
    DECLARE @count INT;

    SELECT @count = COUNT(*)
    FROM EmployeeProjects
    WHERE EmployeeID = @empId;

    RETURN @count;
END
GO


SELECT dbo.fn_GetProjectCount(1) AS ProjectCount;


EXEC sp_AssignEmployeeToProject 2, 3;


SELECT * FROM EmployeeProjects WHERE EmployeeID = 2;


DELETE FROM EmployeeProjects WHERE EmployeeID = 3;
