using ProductManagementApp.Models;
using ProductManagementApp.Reposirty;

namespace ProductManagementApp.Reposirty
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetAllCategory();
        Category GetCategoryById(int id);
        int AddCategory(Category category);
        int UpdateCategory(Category category);
        int DeleteCategory(int id);
    }
}
