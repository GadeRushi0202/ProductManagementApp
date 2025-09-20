using Microsoft.EntityFrameworkCore;
using ProductManagementApp.Data;
using ProductManagementApp.Models;

namespace ProductManagementApp.Reposirty
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext db;
        public ProductRepository(ApplicationDbContext db)
        {
            this.db = db;
        }
        public int AddProduct(Product product)
        {
            db.Products.Add(product);
            int res = db.SaveChanges();
            return res;
        }

        public int DeleteProduct(int id)
        {
            int res = 0;
            var result = db.Products.Where(p => p.ProductId == id).FirstOrDefault();
            if (result != null)
            {
                db.Products.Remove(result);
                res = db.SaveChanges();
            }
            return res;
        }

        public IEnumerable<Product> GetAllProduct()
        {
            return db.Products.ToList();
        }

        public Product GetProductById(int id)
        {
            var result = db.Products.Where(p => p.ProductId == id).FirstOrDefault();
            return result;
        }

        public int UpdateProduct(Product product)
        {
            int res = 0;
            var result = db.Products.Where(p => p.ProductId == product.ProductId).FirstOrDefault();
            if (result != null)
            {
                result.ProductName = product.ProductName;
                result.CategoryId = product.CategoryId;
                res = db.SaveChanges();
            }
            return res;
        }
        public IEnumerable<ProductListVm> GetPagedProducts(int page, int pageSize, out int totalRecords)
        {
            var query = db.Products
                          .Include(p => p.Category)
                          .OrderBy(p => p.ProductId);

            totalRecords = query.Count();

            var products = query.Skip((page - 1) * pageSize)
                                .Take(pageSize)
                                .Select(p => new ProductListVm
                                {
                                    ProductId = p.ProductId,
                                    ProductName = p.ProductName,
                                    CategoryId = p.CategoryId,
                                    CategoryName = p.Category.CategoryName
                                })
                                .ToList();

            return products;
        }

    }
}
