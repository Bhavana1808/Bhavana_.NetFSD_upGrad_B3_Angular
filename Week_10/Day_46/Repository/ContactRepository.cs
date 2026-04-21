using ContactService.API.Data;
using ContactService.API.Models;
using Microsoft.EntityFrameworkCore;

namespace ContactService.API.Repository
{
    public class ContactRepository : IContactRepository
    {
        private readonly ContactDbContext _context;

        public ContactRepository(ContactDbContext context)
        {
            _context = context;
        }

        public async Task<List<Contact>> GetAll()
        {
            return await _context.Contacts.ToListAsync();
        }

        public async Task<Contact> GetContactById(int id)
        {
            var contact = await _context.Contacts.FirstOrDefaultAsync(c => c.ContactId == id);
            if (contact == null)
            {
                throw new Exception("Contact not found");
            }

            return contact;
        }

        public async Task<Contact> Createcontact(Contact contact)
        {
            await _context.Contacts.AddAsync(contact);
            await _context.SaveChangesAsync();

            return contact;
        }

        public async Task<Contact> UpdateContact(int id, Contact contact)
        {
            var oldContact = await _context.Contacts.FirstOrDefaultAsync(c => c.ContactId == id);
            if (oldContact == null)
            {
                throw new Exception("Contact not found");
            }
                ;
            oldContact.Name = contact.Name;
            oldContact.Email = contact.Email;
            oldContact.Phone = contact.Phone;
            oldContact.CategoryId = contact.CategoryId;

            await _context.SaveChangesAsync();

            return oldContact;
        }

        public async Task<bool> DeleteContact(int id)
        {
            var contact = await _context.Contacts.FirstOrDefaultAsync(c => c.ContactId == id);

            if (contact == null)
                return false;

            _context.Contacts.Remove(contact);
            await _context.SaveChangesAsync();

            return true;

        }

    }
}

