using System;
using System.Collections.Generic;

// Entity
public class Student
{
    public int StudentId { get; set; }
    public string StudentName { get; set; }
    public int Marks { get; set; }
}

// Repository (Data Handling)
public class StudentRepository
{
    private List<Student> students = new List<Student>();

    public void AddStudent(Student student)
    {
        students.Add(student);
    }

    public List<Student> GetStudents()
    {
        return students;
    }
}

// Report Generator (Separate Responsibility)
public class ReportGenerator
{
    public void GenerateReport(List<Student> students)
    {
        foreach (var s in students)
        {
            Console.WriteLine($"ID: {s.StudentId}, Name: {s.StudentName}, Marks: {s.Marks}");
        }
    }
}