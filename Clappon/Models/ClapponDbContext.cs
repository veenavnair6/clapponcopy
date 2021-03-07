using Microsoft.EntityFrameworkCore;

namespace Clappon.Models
{
    public class ClapponDbContext : DbContext
    {
        /// <summary>
        /// Db Context Constructor
        /// </summary>
        /// <param name="options"></param>
        public ClapponDbContext(DbContextOptions<ClapponDbContext> options) : base(options)
        {

        }

        /// <summary>
        /// Product Table
        /// </summary>
        public DbSet<Product> Products { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DbSet<Category> Categories { get; set; }

        /// <summary>
        /// OnModelCreating
        /// </summary>
        /// <param name="modelbuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            modelbuilder.Seed();
            var product = modelbuilder.Entity<Product>();
            product.Property(item => item.ProductName).HasMaxLength(200);

            var category = modelbuilder.Entity<Category>();
            category.HasMany(item => item.Products).WithOne(p => p.ProductCategory).HasForeignKey(p=>p.CategoryId);
            category.Property(item => item.Name).HasMaxLength(200);
            
        }

    }
}
