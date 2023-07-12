using Hamburger_Application.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hamburger_Application.Configurations
{
    public class MenuCFG : IEntityTypeConfiguration<Menu>
    {
        public void Configure(EntityTypeBuilder<Menu> builder)
        {
            builder.HasOne(a => a.Dessert).WithOne(a => a.Menu).HasForeignKey<Dessert>(a => a.MenuId).OnDelete(DeleteBehavior.SetNull);
            builder.HasOne(a => a.Fries).WithOne(a => a.Menu).HasForeignKey<Dessert>(a => a.MenuId).OnDelete(DeleteBehavior.SetNull);
            builder.HasOne(a => a.Drink).WithOne(a => a.Menu).HasForeignKey<Dessert>(a => a.MenuId).OnDelete(DeleteBehavior.SetNull);
            builder.HasOne(a => a.Hamburger).WithOne(a => a.Menu).HasForeignKey<Dessert>(a => a.MenuId).OnDelete(DeleteBehavior.SetNull);
            builder.Property(a => a.isActive).HasDefaultValue(true);

            builder.HasData(
                new Menu
                {
                    Id = 1,
                    Name = "Whopper Menu",
                    Price = 150,
                    Piece = 1,
                    FriesId=1,
                    DrinkId=1,
                    HamburgerId=1
                },
                new Menu
                {
                    Id = 2,
                    Name = "Texas SmokeHouse Menu",
                    Price = 170,
                    Piece = 1,
                    FriesId = 1,
                    DrinkId = 1,
                    HamburgerId = 2
                },
                new Menu
                {
                    Id = 3,
                    Name = "Fish Royale Menu",
                    Price = 140,
                    Piece = 1,
                    FriesId = 1,
                    DrinkId = 1,
                    HamburgerId = 3
                },
                new Menu
                {
                    Id = 4,
                    Name = "Big King Menu",
                    Price = 150,
                    Piece = 1,
                    FriesId = 1,
                    DrinkId = 1,
                    HamburgerId = 4
                },
                new Menu
                {
                    Id = 5,
                    Name = "Chicken Royale Menu",
                    Price = 120,
                    Piece = 1,
                    FriesId = 1,
                    DrinkId = 1,
                    HamburgerId = 5
                }
                );
        }
    }
}
