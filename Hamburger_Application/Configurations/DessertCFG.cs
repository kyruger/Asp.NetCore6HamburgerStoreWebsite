using Hamburger_Application.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hamburger_Application.Configurations
{
    public class DessertCfg : IEntityTypeConfiguration<Dessert>
    {
        public void Configure(EntityTypeBuilder<Dessert> builder)
        {
            builder.Property(b => b.Name).HasMaxLength(30);
            builder.HasIndex(b => b.Name).IsUnique();
            builder.Property(b => b.Piece).HasDefaultValue(1);
            builder.Property(b => b.IsActive).HasDefaultValue(true);

            builder.HasData
                (
                new Dessert
                {
                    Id = 1,
                    Name = "Brownie",
                    Price = 50
                },
                new Dessert
                {
                    Id = 2,
                    Name = "Milkshake",
                    Price = 40
                },
                new Dessert
                {
                    Id = 3,
                    Name = "Cheesecake",
                    Price = 60
                },
                new Dessert
                {
                    Id = 4,
                    Name = "Ice Cream",
                    Price = 30
                },
                new Dessert
                {
                    Id = 5,
                    Name = "Puding",
                    Price = 40
                }
                );
        }
    }
}
