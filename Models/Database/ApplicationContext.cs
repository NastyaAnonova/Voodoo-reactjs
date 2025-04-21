using Microsoft.EntityFrameworkCore;
using Shop.Models.Database.Models;

namespace Shop.Models.Database
{
    public class ApplicationContext : DbContext
    {
        public DbSet<AccountModel> Accounts { get; set; }
        public DbSet<CategoryModel> Categories { get; set; }
        public DbSet<ProductModel> Products { get; set; }
        public DbSet<DiscountModel> Discounts { get; set; }
        public DbSet<OrderModel> Orders { get; set; }
        public DbSet<PurchasedProductModel> PurchasedProducts { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            Database.Migrate();
        }
    }
}
