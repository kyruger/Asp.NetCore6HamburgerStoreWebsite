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
                    HamburgerId = 1,
                    Photo = "085732b2-62a9-473a-9c94-198bf0b38d9c_WhopperMenu.jpg"
                },
                new Menu
                {
                    Id = 2,
                    Name = "Texas SmokeHouse Menu",
                    Price = 170,
                    FriesId = 1,
                    DrinkId = 1,
                    HamburgerId = 2,
                    Photo = "03e49b85-7d1b-4a0e-8d18-47d97756a570_TexasSmokeHouseMenu.jpg"
                },
                new Menu
                {
                    Id = 3,
                    Name = "Fish Royale Menu",
                    Price = 140,
                    FriesId = 1,
                    DrinkId = 1,
                    HamburgerId = 3,
                    Photo = "c7e2b9ad-b7b7-476f-9e1d-32c502cf5686_FishRoyaleMenu.jpg"
                },
                new Menu
                {
                    Id = 4,
                    Name = "Big King Menu",
                    Price = 150,
                    FriesId = 1,
                    DrinkId = 1,
                    HamburgerId = 4,
                    Photo = "3ae527d5-e1ca-474d-b550-9acca3afb9b8_BigKingMenu.jpg"
                },
                new Menu
                {
                    Id = 5,
                    Name = "Chicken Royale Menu",
                    Price = 120,
                    FriesId = 1,
                    DrinkId = 1,
                    HamburgerId = 5,
                    Photo = "70e64328-09a0-4e6c-90c5-23868ba18a03_ChickenRoyaleMenu.jpg"
                }
                );
        }
    }
}
