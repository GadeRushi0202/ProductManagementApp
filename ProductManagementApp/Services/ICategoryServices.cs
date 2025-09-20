using ProductManagementApp.Models;

namespace ProductManagementApp.Services
{
    public interface ICategoryServices
    {
        IEnumerable<Category> GetAllCategory();
        Category GetCategoryById(int id);
        int AddCategory(Category category);
        int UpdateCategory(Category category);
        int DeleteCategory(int id);
    }
}
