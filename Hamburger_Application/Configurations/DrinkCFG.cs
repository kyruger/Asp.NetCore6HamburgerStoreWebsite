using Hamburger_Application.Entities.Concrete;
using Hamburger_Application.Entities.Enum;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hamburger_Application.Configurations
{
    public class DrinkCFG : IEntityTypeConfiguration<Drink>
    {
        public void Configure(EntityTypeBuilder<Drink> builder)
        {
            builder.Property(a => a.isActive).HasDefaultValue(true);
            builder.Property(a => a.Size).HasDefaultValue(Size.Small);

            builder.HasData(
                new Drink
                {
                    Id = 1,
                    Name = "Coke",
                    Price = 40,
                    Piece = 1
                },
                new Drink
                {
                    Id = 2,
                    Name = "Ayran",
                    Price = 25,
                    Piece = 1
                },
                new Drink
                {
                    Id = 3,
                    Name = "Coke Zero",
                    Price = 45,
                    Piece = 1
                },
                new Drink
                {
                    Id = 4,
                    Name = "Cold Tea",
                    Price = 35,
                    Piece = 1
                },
                new Drink
                {
                    Id = 5,
                    Name = "Mineral Water",
                    Price = 15,
                    Piece = 1
                }
                );
        }
    }
}
