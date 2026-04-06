using Microsoft.AspNetCore.Mvc;

public class ContactController : Controller
{
    private readonly IContactRepository _repo;

    public ContactController(IContactRepository repo)
    {
        _repo = repo;
    }

    public IActionResult ShowContacts()
    {
        var contacts = _repo.GetAllContacts();
        return View(contacts);
    }

    public IActionResult AddContact()
    {
        ViewBag.Companies = _repo.GetCompanies();
        ViewBag.Departments = _repo.GetDepartments();

        return View();
    }

    [HttpPost]
    public IActionResult AddContact(ContactInfo contact)
    {
        _repo.AddContact(contact);
        return RedirectToAction("ShowContacts");
    }

    public IActionResult EditContact(int id)
    {
        var contact = _repo.GetContactById(id);

        ViewBag.Companies = _repo.GetCompanies();
        ViewBag.Departments = _repo.GetDepartments();

        return View(contact);
    }

    [HttpPost]
    public IActionResult EditContact(ContactInfo contact)
    {
        _repo.UpdateContact(contact);
        return RedirectToAction("ShowContacts");
    }

    public IActionResult DeleteContact(int id)
    {
        _repo.DeleteContact(id);
        return RedirectToAction("ShowContacts");
    }
}