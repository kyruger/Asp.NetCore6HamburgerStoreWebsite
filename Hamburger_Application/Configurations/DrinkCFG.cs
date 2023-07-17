using Hamburger_Application.Entities.Concrete;
using Hamburger_Application.Entities.Enum;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hamburger_Application.Configurations
{
    public class DrinkCfg : IEntityTypeConfiguration<Drink>
    {
        public void Configure(EntityTypeBuilder<Drink> builder)
        {
            builder.Property(a => a.Name).HasMaxLength(30);
            builder.HasIndex(b => b.Name).IsUnique();
            builder.Property(b => b.Piece).HasDefaultValue(1);
            builder.Property(b => b.Size).HasDefaultValue(Size.Small);
            builder.Property(b => b.IsActive).HasDefaultValue(true);

            builder.HasData
                (
                new Drink
                {
                    Id = 1,
                    Name = "Coke",
                    Price = 40
                },
                new Drink
                {
                    Id = 2,
                    Name = "Ayran",
                    Price = 25
                },
                new Drink
                {
                    Id = 3,
                    Name = "Coke Zero",
                    Price = 45
                },
                new Drink
                {
                    Id = 4,
                    Name = "Cold Tea",
                    Price = 35
                },
                new Drink
                {
                    Id = 5,
                    Name = "Mineral Water",
                    Price = 15
                }
                );
        }
    }
}
