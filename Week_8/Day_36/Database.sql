CREATE DATABASE CollegeDB;

USE CollegeDB;

CREATE TABLE Courses (
    CourseId INT PRIMARY KEY IDENTITY,
    CourseName NVARCHAR(100)
);

CREATE TABLE Students (
    StudentId INT PRIMARY KEY IDENTITY,
    StudentName NVARCHAR(100),
    CourseId INT,
    FOREIGN KEY (CourseId) REFERENCES Courses(CourseId)
);

INSERT INTO Courses VALUES ('CSE'), ('ECE'), ('MBA');

INSERT INTO Students VALUES 
('Bhavana', 1),
('Ravi', 2),
('Sneha', 1);