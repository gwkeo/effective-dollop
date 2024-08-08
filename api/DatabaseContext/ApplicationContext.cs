using DatabaseModels.Models;
using Microsoft.EntityFrameworkCore;

namespace DatabaseContext
{
    public class ApplicationContext : DbContext
    {
        private readonly string _connectionString = """
                                Host=localhost;
                                Port=5438;
                                Database=postgres;
                                Username=postgres;
                                Password=8929
                                """;

        public DbSet<User> Users { get; set; }
        
        public DbSet<Product> Products { get; set; }
        
        public DbSet<Order> Orders { get; set; }
        
        public DbSet<Category> Categories { get; set; }

        public ApplicationContext()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseNpgsql(_connectionString);
    }
}
