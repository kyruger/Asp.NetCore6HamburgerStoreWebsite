using Hamburger_Application.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hamburger_Application.Configurations
{
    public class MenuCfg : IEntityTypeConfiguration<Menu>
    {
        public void Configure(EntityTypeBuilder<Menu> builder)
        {
            builder.Property(b => b.Name).HasMaxLength(100);
            builder.HasIndex(b => b.Name).IsUnique();
            builder.Property(b => b.Piece).HasDefaultValue(1);
            builder.HasOne(b => b.Fries).WithOne(b => b.Menu).HasForeignKey<Fries>(b => b.MenuId).OnDelete(DeleteBehavior.SetNull);
            builder.HasOne(b => b.Drink).WithOne(b => b.Menu).HasForeignKey<Drink>(b => b.MenuId).OnDelete(DeleteBehavior.SetNull);
            builder.HasOne(b => b.Hamburger).WithOne(b => b.Menu).HasForeignKey<Hamburger>(b => b.MenuId).OnDelete(DeleteBehavior.SetNull);
            builder.Property(b => b.IsActive).HasDefaultValue(true);

            builder.HasData
                (
                new Menu
                {
                    Id = 1,
                    Name = "Whopper Menu",
                    Price = 150,
                    FriesId = 1,
                    DrinkId = 1,
                    HamburgerId = 1
                },
                new Menu
                {
                    Id = 2,
                    Name = "Texas SmokeHouse Menu",
                    Price = 170,
                    FriesId = 1,
                    DrinkId = 1,
                    HamburgerId = 2
                },
                new Menu
                {
                    Id = 3,
                    Name = "Fish Royale Menu",
                    Price = 140,
                    FriesId = 1,
                    DrinkId = 1,
                    HamburgerId = 3
                },
                new Menu
                {
                    Id = 4,
                    Name = "Big King Menu",
                    Price = 150,
                    FriesId = 1,
                    DrinkId = 1,
                    HamburgerId = 4
                },
                new Menu
                {
                    Id = 5,
                    Name = "Chicken Royale Menu",
                    Price = 120,
                    FriesId = 1,
                    DrinkId = 1,
                    HamburgerId = 5
                }
                );
        }
    }
}
