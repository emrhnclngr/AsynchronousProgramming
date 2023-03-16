using AsynchronousProgramming.Infrastructure.SeedData;
using AsynchronousProgramming.Models.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace AsynchronousProgramming.Infrastructure.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Page> Pages  { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().Property(x => x.UnitPrice).HasColumnType("decimal");
            modelBuilder.ApplyConfiguration(new CategorySeedData());
            modelBuilder.ApplyConfiguration(new ProductSeedData());
            modelBuilder.ApplyConfiguration(new PageSeedData());

            base.OnModelCreating(modelBuilder);
        }
    }
}
