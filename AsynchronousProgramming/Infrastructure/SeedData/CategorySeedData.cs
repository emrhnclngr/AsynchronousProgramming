using AsynchronousProgramming.Models.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AsynchronousProgramming.Infrastructure.SeedData
{
    public class CategorySeedData : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
                new Category { Id = 1, Name = "Elektronik",  Slug = "elektronik" },
                new Category { Id = 2, Name = "Beyaz Eşya",  Slug = "beyaz eşya"},
                new Category { Id = 3, Name = "Mobilya", Slug = "mobilya"});
        }
    }
}
