using Hamburger_Application.Entities.Concrete;
using Hamburger_Application.Entities.Enum;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hamburger_Application.Configurations
{
    public class FriesCFG : IEntityTypeConfiguration<Fries>
    {
        public void Configure(EntityTypeBuilder<Fries> builder)
        {
            builder.Property(a => a.isActive).HasDefaultValue(true);
            builder.Property(a => a.Size).HasDefaultValue(Size.Small);

            builder.HasData(
                new Fries
                {
                    Id = 1,
                    Name = "Potato",
                    Price = 20,
                    Piece = 1,

                },
                new Fries
                {
                    Id = 2,
                    Name = "Onion Ring",
                    Price = 22,
                    Piece = 1
                },
                new Drink
                {
                    Id = 3,
                    Name = "Nugget",
                    Price = 25,
                    Piece = 1
                },
                new Drink
                {
                    Id = 4,
                    Name = "Chicken Tenders",
                    Price = 25,
                    Piece = 1
                }
                );
        }
    }
}
