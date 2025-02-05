using Microsoft.EntityFrameworkCore;
using ICMPC_Test.Models;

namespace ICMPC_Test.Data
{
    public class UserProductsContext : DbContext
    {
        public UserProductsContext( DbContextOptions<UserProductsContext> options ) : base(options)
        { }

        public DbSet<User> Users { get; set; } //Get user attributes from User model
        public DbSet<Product> Products { get; set; } //Get product attributes from Product model

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //One-to-many relationship between User and Product
            modelBuilder.Entity<User>()
                .HasMany(user => user.Products)
                .WithOne(product => product.User)
                .HasForeignKey(product => product.UserId);

            //modelBuilder.Entity<Product>().HasData(
            //    new Product { ProductId = 1, ProductName = "Nintendo Switch", Price = 1200.00 }
            //    );
            //modelBuilder.Entity<User>().HasData(
            //    new User { }
            //    );
            base.OnModelCreating(modelBuilder);
        }
    }
}
