using Microsoft.AspNetCore.Mvc;

public class StudentController : Controller
{
    private readonly IStudentRepository _repo;

    public StudentController(IStudentRepository repo)
    {
        _repo = repo;
    }

    public IActionResult StudentsWithCourse()
    {
        var data = _repo.GetStudentsWithCourse();
        return View(data);
    }

    public IActionResult CoursesWithStudents()
    {
        var data = _repo.GetCoursesWithStudents();
        return View(data);
    }

    public IActionResult Create()
    {
        var courses = _repo.GetCourses();
        ViewBag.Courses = courses;
        return View();
    }

    [HttpPost]
    public IActionResult Create(Student student)
    {
        _repo.AddStudent(student);
        return RedirectToAction("StudentsWithCourse");
    }

    // EDIT (GET)
    public IActionResult Edit(int id)
    {
        var student = _repo.GetStudentById(id);
        ViewBag.Courses = _repo.GetCourses();
        return View(student);
    }

    //  EDIT (POST)
    [HttpPost]
    public IActionResult Edit(Student student)
    {
        _repo.UpdateStudent(student);
        return RedirectToAction("StudentsWithCourse");
    }

    //  DELETE
    public IActionResult Delete(int id)
    {
        _repo.DeleteStudent(id);
        return RedirectToAction("StudentsWithCourse");
    }
}