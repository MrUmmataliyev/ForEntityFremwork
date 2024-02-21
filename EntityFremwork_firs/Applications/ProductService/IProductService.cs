using EntityFremwork_firs.Models;

namespace EntityFremwork_firs.Applications.ProductService
{
    public interface IProductService
    {
        public Task<string> CreateProductAsync(Product product);
    }
}
