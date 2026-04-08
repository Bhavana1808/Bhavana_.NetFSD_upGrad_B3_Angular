using ContactManagement.API.DataAccess;
using ContactManagement.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace ContactManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private readonly IContactRepository _repo;

        public ContactsController(IContactRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_repo.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var contact = _repo.GetById(id);

            if (contact == null)
                return NotFound();

            return Ok(contact);
        }

        [HttpPost]
        public IActionResult Create(ContactInfo contact)
        {
            if (string.IsNullOrEmpty(contact.FirstName))
                return BadRequest("First Name required");

            var created = _repo.Create(contact);

            return CreatedAtAction(nameof(GetById), new { id = created.ContactId }, created);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, ContactInfo contact)
        {
            var updated = _repo.Update(id, contact);

            if (!updated)
                return NotFound();

            return Ok("Updated Successfully");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var deleted = _repo.Delete(id);

            if (!deleted)
                return NotFound();

            return Ok("Deleted Successfully");
        }
    }
}