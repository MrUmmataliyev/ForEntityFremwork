using EntityFremwork_firs.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityFremwork_firs.Infrastructure
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            :base(options)
        {
            
        }
        public DbSet<Product> Products { get; set; }
    }
}
