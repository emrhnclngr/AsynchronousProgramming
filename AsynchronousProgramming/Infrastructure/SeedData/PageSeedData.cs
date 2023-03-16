using AsynchronousProgramming.Models.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AsynchronousProgramming.Infrastructure.SeedData
{
    public class PageSeedData : IEntityTypeConfiguration<Page>
    {
        public void Configure(EntityTypeBuilder<Page> builder)
        {
            builder.HasData(
                new Page { Id = 1, Title = "Favoriler", Slug = "favoriler", Content = "Favoriler" },
                new Page { Id = 2, Title = "Sepet", Slug = "sepet" , Content = "Sepet" },
                new Page { Id = 3, Title = "Home", Slug = "home" , Content = "Home" });
        }
    }
}
