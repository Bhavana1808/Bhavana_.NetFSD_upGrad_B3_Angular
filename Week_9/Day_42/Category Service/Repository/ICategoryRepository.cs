using CategoryService.API.Models;

namespace CategoryService.API.Repository
{
    
    public interface ICategoryRepository
    {
        Task<List<Category>> GetAll();

        Task<Category> GetCategoryById(int id);

        Task<Category> CreateCategory(Category category);

        Task<Category> UpdateCategory(int id, Category category);

        Task<bool> DeleteCategory(int id);
    }
}

