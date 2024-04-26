using Microsoft.EntityFrameworkCore;

namespace API.Entites
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Products> Products { get; set; }
    }
}
