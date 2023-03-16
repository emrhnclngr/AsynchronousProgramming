using AsynchronousProgramming.Models.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AsynchronousProgramming.Infrastructure.SeedData
{
    public class ProductSeedData : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product { Id = 1, Name = "Laptop", Description = "Monster-Laptop", Slug = "laptop", CategoryId = 1 },
                new Product { Id = 2, Name = "Buzdolabı", Description = "Buzdolabı", Slug = "buzdolabı", CategoryId = 2 },
                new Product { Id = 3, Name = "Masa", Description = "Yemek masası", Slug = "masa", CategoryId = 3 });
        }
    }
}
