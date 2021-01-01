using core.Models;
using data.Configurations;
//using data.Seeds;
using Microsoft.EntityFrameworkCore;

namespace data.Contexts
{
    public class EfContext:DbContext
    {
        public EfContext(DbContextOptions<EfContext> options):base(options)
        {
            
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            //modelBuilder.ApplyConfiguration(new ProductSeed(new[]{1}));
            //modelBuilder.ApplyConfiguration(new CategorySeed(new []{1}));
        }
    }
}