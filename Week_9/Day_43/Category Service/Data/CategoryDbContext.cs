using CategoryService.API.Models;
using Microsoft.EntityFrameworkCore;

namespace CategoryService.API.Data
{
   
    public class CategoryDbContext : DbContext
    {
        public CategoryDbContext(DbContextOptions<CategoryDbContext> options)
            : base(options) { }

        public DbSet<Category> Category { get; set; }
    }
}
