using ProductManagementApp.Models;

namespace ProductManagementApp.Services
{
    public interface IProductServices
    {
        IEnumerable<Product> GetAllProduct();
        Product GetProductById(int id);
        int AddProduct(Product product);
        int UpdateProduct(Product product);
        int DeleteProduct(int id);

        IEnumerable<ProductListVm> GetPagedProducts(int page, int pageSize, out int totalRecords);
    }
}
