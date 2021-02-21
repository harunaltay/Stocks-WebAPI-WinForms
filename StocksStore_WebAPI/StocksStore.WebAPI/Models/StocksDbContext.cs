using System.Data.Entity;

namespace StocksStore.WebAPI.Models
{
    public class StocksDbContext : DbContext
    {
        public StocksDbContext() : base("StocksDBContext")
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}