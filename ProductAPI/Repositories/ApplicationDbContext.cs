using Microsoft.EntityFrameworkCore;
using ProductAPI.Abstractions;
using ProductAPI.Model;

namespace ProductAPI.Repositories
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> contextOptions) : base(contextOptions)
        {
        }

        public DbSet<Laptop> Laptops { get; }
    }
}
