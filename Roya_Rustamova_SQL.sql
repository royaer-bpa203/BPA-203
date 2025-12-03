CREATE DATABASE Company;

USE Company;

CREATE TABLE Employees (
    EmployeeID INT PRIMARY KEY,
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    Email VARCHAR(100),
    PhoneNumber VARCHAR(20),
    HireDate DATE,
    JobTitle VARCHAR(50),
    Salary DECIMAL(10,2),
    Department VARCHAR(50)
);

INSERT INTO Employees (EmployeeID, FirstName, LastName, Email, PhoneNumber, HireDate, JobTitle, Salary, Department)
VALUES
(1, 'Leyla', 'Həsənova', 'leyla@company.az', '0501112233', '2021-05-10', 'HR Specialist', 2500, 'HR'),
(2, 'Kamal', 'Quliyev', 'kamal@company.az', '0512223344', '2019-03-15', 'IT Specialist', 3000, 'IT'),
(3, 'Aysel', 'Rzayeva', 'aysel@company.az', '0553334455', '2022-07-01', 'Accountant', 1800, 'Finance'),
(4, 'Murad', ' Əliyev', 'murad@company.az', '0704445566', '2020-11-20', 'Developer', 3200, 'IT'),
(5, 'Narmin', 'Salahova', 'narmin@company.az', '0775556677', '2018-02-12', 'Manager', 2800, 'Management');

SELECT * FROM Employees;

SELECT * FROM Employees
WHERE Salary > 2000;

SELECT * FROM Employees
WHERE Department = 'IT';

SELECT * FROM Employees
ORDER BY Salary DESC;

SELECT FirstName, Salary FROM Employees;

SELECT * FROM Employees
WHERE HireDate > '2020-01-01';

SELECT * FROM Employees
WHERE Email LIKE '%company.az%';

SELECT MAX(Salary) AS HighestSalary FROM Employees;

SELECT MIN(Salary) AS LowestSalary FROM Employees;

SELECT AVG(Salary) AS AverageSalary FROM Employees;

SELECT COUNT(*) AS TotalEmployees FROM Employees;

SELECT SUM(Salary) AS TotalSalary FROM Employees;

SELECT Department, COUNT(*) AS EmployeeCount
FROM Employees
GROUP BY Department;

SELECT Department, AVG(Salary) AS AverageSalary
FROM Employees
GROUP BY Department;

SELECT Department, MAX(Salary) AS MaxSalary
FROM Employees
GROUP BY Department;

UPDATE Employees
SET Salary = 2800
WHERE EmployeeID = 1;

UPDATE Employees
SET Salary = Salary * 1.10
WHERE Department = 'IT';

UPDATE Employees
SET JobTitle = 'HR Meneceri'
WHERE FirstName = 'Leyla' AND LastName = 'Həsənova';

DELETE FROM Employees
WHERE EmployeeID = 5;

DELETE FROM Employees
WHERE Salary < 1500;

SELECT * FROM Employees
WHERE FirstName LIKE '%a%';

SELECT * FROM Employees
WHERE Salary BETWEEN 2000 AND 2500;

SELECT * FROM Employees
WHERE Department IN ('Finance', 'IT');

