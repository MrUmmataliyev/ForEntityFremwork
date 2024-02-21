
using EntityFremwork_firs.Infrastructure;
using EntityFremwork_firs.Models;
using Microsoft.EntityFrameworkCore;

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

        public async Task<bool> DeleteProductAsync(int id)
        {
            var product= await _context.Products.FirstOrDefaultAsync(p=> p.Id == id);
            if (product != null)
            {
                _context.Products.Remove(product);
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<List<Product>> GetAllProductAsync()
        {
            var products = _context.Products.ToList();
            return products;
        }

        public async Task<string> UpdateProductAsync(int id, Product product)
        {
            var oldproduct = _context.Products.FirstOrDefaultAsync(p => p.Id == id);
            if (oldproduct != null)
            {
                oldproduct.Result.Name = product.Name;
                oldproduct.Result.Description = product.Description;
                oldproduct.Result.Category = product.Category;

                await _context.SaveChangesAsync();
                return "Updated";
            }
            return "Such product not found";
        }
    }
}
