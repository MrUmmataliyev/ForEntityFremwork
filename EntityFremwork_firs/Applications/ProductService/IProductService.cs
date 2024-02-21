using EntityFremwork_firs.Models;

namespace EntityFremwork_firs.Applications.ProductService
{
    public interface IProductService
    {
        public Task<string> CreateProductAsync(Product product);
        public Task<List<Product>> GetAllProductAsync();
        public Task<string> UpdateProductAsync(int id, Product product);
        public Task<bool> DeleteProductAsync(int id);
    }
}
