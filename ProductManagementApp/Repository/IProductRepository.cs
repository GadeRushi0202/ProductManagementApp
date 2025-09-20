using ProductManagementApp.Models;

namespace ProductManagementApp.Reposirty
{
    public interface IProductRepository
    {
        IEnumerable<ProductListVm> GetPagedProducts(int page, int pageSize, out int totalRecords);
        IEnumerable<Product> GetAllProduct();
        Product GetProductById(int id);
        int AddProduct(Product product);
        int UpdateProduct(Product product);
        int DeleteProduct(int id);
    }
}
