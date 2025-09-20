using ProductManagementApp.Models;
using ProductManagementApp.Reposirty;

namespace ProductManagementApp.Services
{
    public class CategoryServices : ICategoryServices
    {
        private readonly ICategoryRepository repo;
        public CategoryServices(ICategoryRepository repo)
        {
            this.repo = repo;
        }
        public int AddCategory(Category category)
        {
            return repo.AddCategory(category);
        }

        public int DeleteCategory(int id)
        {
            return repo.DeleteCategory(id);
        }

        public IEnumerable<Category> GetAllCategory()
        {
            return repo.GetAllCategory();
        }

        public Category GetCategoryById(int id)
        {
            return repo.GetCategoryById(id);
        }

        public int UpdateCategory(Category category)
        {
            return repo.UpdateCategory(category);
        }
    }
}
