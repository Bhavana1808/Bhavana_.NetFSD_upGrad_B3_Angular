namespace ContactService.API.Data
{
    using Microsoft.EntityFrameworkCore;
    using ContactService.API.Models;

    public class ContactDbContext : DbContext
    {
        public ContactDbContext(DbContextOptions<ContactDbContext> options)
            : base(options) { }

        public DbSet<Contact> Contacts { get; set; }
    }
}
