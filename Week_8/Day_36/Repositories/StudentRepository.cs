using Dapper;

public class StudentRepository : IStudentRepository
{
    private readonly DapperContext _context;

    public StudentRepository(DapperContext context)
    {
        _context = context;
    }

    // Students + Course
    public IEnumerable<Student> GetStudentsWithCourse()
    {
        var sql = @"SELECT s.StudentId, s.StudentName, s.CourseId,
                           c.CourseId, c.CourseName
                    FROM Students s
                    JOIN Courses c ON s.CourseId = c.CourseId";

        using var connection = _context.CreateConnection();

        return connection.Query<Student, Course, Student>(
            sql,
            (student, course) =>
            {
                student.Course = course;
                return student;
            },
            splitOn: "CourseId"
        );
    }

    // Courses + Students
    public IEnumerable<Course> GetCoursesWithStudents()
    {
        var sql = @"SELECT c.CourseId, c.CourseName,
                           s.StudentId, s.StudentName, s.CourseId
                    FROM Courses c
                    LEFT JOIN Students s ON c.CourseId = s.CourseId";

        using var connection = _context.CreateConnection();

        var dict = new Dictionary<int, Course>();

        var result = connection.Query<Course, Student, Course>(
            sql,
            (course, student) =>
            {
                if (!dict.TryGetValue(course.CourseId, out var current))
                {
                    current = course;
                    current.Students = new List<Student>();
                    dict.Add(current.CourseId, current);
                }

                if (student != null)
                    current.Students.Add(student);

                return current;
            },
            splitOn: "StudentId"
        );

        return dict.Values;
    }

    public IEnumerable<Course> GetCourses()
    {
        var sql = "SELECT * FROM Courses";

        using var connection = _context.CreateConnection();
        return connection.Query<Course>(sql);
    }

    public void AddStudent(Student student)
    {
        var sql = "INSERT INTO Students (StudentName, CourseId) VALUES (@StudentName, @CourseId)";

        using var connection = _context.CreateConnection();
        connection.Execute(sql, student);
    }

    public Student GetStudentById(int id)
    {
        var sql = "SELECT * FROM Students WHERE StudentId = @Id";
        using var connection = _context.CreateConnection();
        return connection.QueryFirstOrDefault<Student>(sql, new { Id = id });
    }

    public void UpdateStudent(Student student)
    {
        var sql = "UPDATE Students SET StudentName=@StudentName, CourseId=@CourseId WHERE StudentId=@StudentId";
        using var connection = _context.CreateConnection();
        connection.Execute(sql, student);
    }

    public void DeleteStudent(int id)
    {
        var sql = "DELETE FROM Students WHERE StudentId = @Id";
        using var connection = _context.CreateConnection();
        connection.Execute(sql, new { Id = id });
    }
}
