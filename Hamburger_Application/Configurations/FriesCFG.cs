using Hamburger_Application.Entities.Concrete;
using Hamburger_Application.Entities.Enum;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hamburger_Application.Configurations
{
    public class FriesCfg : IEntityTypeConfiguration<Fries>
    {
        public void Configure(EntityTypeBuilder<Fries> builder)
        {
            builder.Property(b => b.Name).HasMaxLength(30);
            builder.HasIndex(b => b.Name).IsUnique();
            builder.Property(b => b.Piece).HasDefaultValue(1);
            builder.Property(b => b.Size).HasDefaultValue(Size.Small);
            builder.Property(b => b.IsActive).HasDefaultValue(true);

            builder.HasData
                (
                new Fries
                {
                    Id = 1,
                    Name = "Potato",
                    Price = 20
                },
                new Fries
                {
                    Id = 2,
                    Name = "Onion Ring",
                    Price = 22
                },
                new Drink
                {
                    Id = 3,
                    Name = "Nugget",
                    Price = 25
                },
                new Drink
                {
                    Id = 4,
                    Name = "Chicken Tenders",
                    Price = 25
                }
                );
        }
    }
}
