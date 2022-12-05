using Microsoft.EntityFrameworkCore;
using ProductAPI.Model;

namespace ProductAPI.Abstractions
{
    public interface IApplicationDbContext
    {
        DbSet<Laptop> Laptops { get; }
    }
}
