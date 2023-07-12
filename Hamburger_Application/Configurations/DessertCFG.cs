using Hamburger_Application.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hamburger_Application.Configurations
{
    public class DessertCFG : IEntityTypeConfiguration<Dessert>
    {
        public void Configure(EntityTypeBuilder<Dessert> builder)
        {
            builder.Property(a => a.isActive).HasDefaultValue(true);

            builder.HasData(
                new Dessert
                {
                    Id = 1,
                    Name = "Brownie",
                    Price = 50,
                    Piece = 1
                },
                new Dessert
                {
                    Id = 2,
                    Name = "Milkshake",
                    Price = 40,
                    Piece = 1
                },
                new Dessert
                {
                    Id = 3,
                    Name = "Cheesecake",
                    Price = 60,
                    Piece = 1
                },
                new Dessert
                {
                    Id = 4,
                    Name = "Ice Cream",
                    Price = 30,
                    Piece = 1
                },
                new Dessert
                {
                    Id = 5,
                    Name = "Puding",
                    Price = 40,
                    Piece = 1
                }
                );
        }
    }
}
