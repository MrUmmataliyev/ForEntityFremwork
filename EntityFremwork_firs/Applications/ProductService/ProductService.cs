
using EntityFremwork_firs.Infrastructure;
using EntityFremwork_firs.Models;

namespace EntityFremwork_firs.Applications.ProductService
{
    public class ProductService : IProductService
    {
        private readonly ApplicationDbContext _context;

        public ProductService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<string> CreateProductAsync(Product product)
        {

            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();
            return "Malumot yaratildi";
        }
    }
}
