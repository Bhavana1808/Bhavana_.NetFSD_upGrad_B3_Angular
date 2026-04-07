public interface IStudentRepository
{
    IEnumerable<Student> GetStudentsWithCourse();
    IEnumerable<Course> GetCoursesWithStudents();

    IEnumerable<Course> GetCourses();
    void AddStudent(Student student);
    Student GetStudentById(int id);
    void UpdateStudent(Student student);
    void DeleteStudent(int id);
}