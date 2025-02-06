using Microsoft.EntityFrameworkCore;
using ICMPC_Test.Models;

namespace ICMPC_Test.Data
{
    public class UserProductsContext : DbContext
    {
        public UserProductsContext(DbContextOptions<UserProductsContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var adminId = 1;

            modelBuilder.Entity<User>().HasData(new User
            {
                UserId = adminId,
                UserName = "Admin",
                Email = "admin@example.com",
                PasswordHash = "$2a$11$7Qy5wIxiPIuokfKhFwKAMOIRY8N5p9N40XNDX4wLopzAdprdiBeRm" // Precomputed hash of "Admin123"
            });

            // Generate 30 products
            var products = new List<Product>();
            for (int i = 1; i <= 30; i++)
            {
                products.Add(new Product
                {
                    ProductId = i,
                    UserId = adminId,
                    ProductName = $"Product {i}",
                    Description = $"Description for product {i}",
                    Price = i * 10
                });
            }
            modelBuilder.Entity<Product>().HasData(products);
        }
    }
}
