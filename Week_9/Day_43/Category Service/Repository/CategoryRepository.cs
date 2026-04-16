using CategoryService.API.Models;
using CategoryService.API.Data;
using CategoryService.API.Repository;
using Microsoft.EntityFrameworkCore;

namespace CategoryService.API.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly CategoryDbContext _context;

        public CategoryRepository(CategoryDbContext context)
        {
            _context = context;
        }

        public async Task<List<Category>> GetAll()
        {
            return await _context.Category.ToListAsync();
        }

        public async Task<Category> GetCategoryById(int id)
        {
            var contact = await _context.Category.FirstOrDefaultAsync(c => c.CategoryId == id);
            if (contact == null)
            {
                return null;
            }

            return contact;
        }

        public async Task<Category> CreateCategory(Category category)
        {
            await _context.Category.AddAsync(category);
            await _context.SaveChangesAsync();

            return category;
        }

        public async Task<Category> UpdateCategory(int id, Category category)
        {
            var oldCategory = await _context.Category.FirstOrDefaultAsync(c => c.CategoryId == id);
            if (oldCategory == null)
                return null;
            oldCategory.CategoryName = category.CategoryName;
            oldCategory.Description = category.Description;

            await _context.SaveChangesAsync();

            return oldCategory;
        }

        public async Task<bool> DeleteCategory(int id)
        {
            var category = await _context.Category.FirstOrDefaultAsync(c => c.CategoryId == id);

            if (category == null)
                return false;

            _context.Category.Remove(category);
            await _context.SaveChangesAsync();

            return true;

        }

    }
}
