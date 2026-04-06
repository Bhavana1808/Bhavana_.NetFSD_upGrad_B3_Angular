CREATE DATABASE ContactDb;
USE ContactDb;

CREATE TABLE Company (
    CompanyId INT IDENTITY PRIMARY KEY,
    CompanyName NVARCHAR(100)
);

CREATE TABLE Department (
    DepartmentId INT IDENTITY PRIMARY KEY,
    DepartmentName NVARCHAR(100)
);

CREATE TABLE ContactInfo (
    ContactId INT IDENTITY PRIMARY KEY,
    FirstName NVARCHAR(50),
    LastName NVARCHAR(50),
    EmailId NVARCHAR(100),
    MobileNo BIGINT,
    Designation NVARCHAR(50),
    CompanyId INT,
    DepartmentId INT,
    FOREIGN KEY (CompanyId) REFERENCES Company(CompanyId),
    FOREIGN KEY (DepartmentId) REFERENCES Department(DepartmentId)
);

INSERT INTO Company VALUES ('TCS'), ('Infosys');
INSERT INTO Department VALUES ('HR'), ('IT');


INSERT INTO ContactInfo 
(FirstName, LastName, EmailId, MobileNo, Designation, CompanyId, DepartmentId)
VALUES 
('Bhavana', 'Yanala', 'bhavana@gmail.com', 9876543210, 'Developer', 1, 1),
('Ravi', 'Kumar', 'ravi@gmail.com', 9123456780, 'Tester', 2, 2);