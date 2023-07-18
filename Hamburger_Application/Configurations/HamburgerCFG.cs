using Hamburger_Application.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hamburger_Application.Configurations
{
    public class HamburgerCfg : IEntityTypeConfiguration<Hamburger>
    {
        public void Configure(EntityTypeBuilder<Hamburger> builder)
        {
            builder.Property(b => b.Name).HasMaxLength(50);
            builder.Property(b => b.Piece).HasDefaultValue(1);
            builder.Property(b => b.IsActive).HasDefaultValue(true);
            
            builder.HasData
                (
                new Hamburger
                {
                    Id = 1,
                    Name = "Whopper",
                    Price = 120,
                    Photo = "27c952d4-c958-4bce-87ad-6cb40a743067_Whopper.jpg"
                },
                new Hamburger
                {
                    Id = 2,
                    Name = "Texas SmokeHouse",
                    Price = 140,
                    Photo = "43773966-353c-4741-9a0e-9d3642aea7e3_TexasSmokeHouse.jpg"
                },
                new Hamburger
                {
                    Id = 3,
                    Name = "Fish Royale",
                    Price = 110,
                    Photo = "074e56a6-ab87-48b1-b948-8ddc5ff84c97_FishRoyale.jpg"
                },
                new Hamburger
                {
                    Id = 4,
                    Name = "Big King",
                    Price = 150,
                    Photo = "e7bcba7f-5e1f-4b11-81fe-8f423b4bb26f_BigKing.jpg"
                },
                new Hamburger
                {
                    Id = 5,
                    Name = "Chicken Royale",
                    Price = 95,
                    Photo = "0c8d85ff-19e8-4550-b079-f83d1e8b863a_ChickenRoyale.jpg"
                }
                );
        }
    }
}
