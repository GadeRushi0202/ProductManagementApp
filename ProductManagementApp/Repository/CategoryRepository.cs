using ProductManagementApp.Data;
using ProductManagementApp.Models;
using ProductManagementApp.Reposirty;

namespace ProductManagementApp.Reposirty
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext db;
        public CategoryRepository(ApplicationDbContext db)
        {
            this.db = db;
        }
        public int AddCategory(Category category)
        {
            db.Categories.Add(category);
            int res = db.SaveChanges();
            return res;
        }

        public int DeleteCategory(int id)
        {
            int res = 0;
            var result = db.Categories.Where(c => c.CategoryId == id).FirstOrDefault();
            if (result != null)
            {
                db.Categories.Remove(result);
                res = db.SaveChanges();
            }
            return res;
        }

        public IEnumerable<Category> GetAllCategory()
        {
            return db.Categories.ToList();
        }

        public Category GetCategoryById(int id)
        {
            var result = db.Categories.Where(c => c.CategoryId == id).FirstOrDefault();
            return result;
        }

        public int UpdateCategory(Category category)
        {
            int res = 0;
            var result = db.Categories.Where(c => c.CategoryId == category.CategoryId).FirstOrDefault();
            if (result != null)
            {
                result.CategoryName = category.CategoryName;
                res = db.SaveChanges();
            }
            return res;
        }
    }
}
