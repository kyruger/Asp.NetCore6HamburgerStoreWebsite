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
            builder.Property(b => b.Piece).HasDefaultValue(1);
            builder.Property(b => b.Size).HasDefaultValue(Size.Small);
            builder.Property(b => b.IsActive).HasDefaultValue(true);

            builder.HasData
                (
                new Fries
                {
                    Id = 1,
                    Name = "Potatoes",
                    Price = 20,
                    Photo = "301422bb-3c9f-4670-87ec-52f6bb49510e_Potatoes.jpg"
                },
                new Fries
                {
                    Id = 2,
                    Name = "Onion Ring",
                    Price = 22,
                    Photo = "40149d5b-324f-40d3-802c-0866bc9edac8_OnionRings.jpg"
                },
                new Fries
                {
                    Id = 3,
                    Name = "Nugget",
                    Price = 25,
                    Photo = "f012288d-4cb5-4546-a5a1-82a2e34457ce_Nuggets.jpg"
                },
                new Fries
                {
                    Id = 4,
                    Name = "Chicken Tenders",
                    Price = 25,
                    Photo = "1e165d0c-cdad-4956-a803-a291756320b1_ChickenTenders.jpg"
                },
                new Fries
                {
                    Id = 5,
                    Name = "Potatoes",
                    Price = 24,
                    Photo = "301422bb-3c9f-4670-87ec-52f6bb49510e_Potatoes.jpg",
                    Size = Size.Medium
                },
                new Fries
                {
                    Id = 6,
                    Name = "Onion Ring",
                    Price = 26,
                    Photo = "40149d5b-324f-40d3-802c-0866bc9edac8_OnionRings.jpg",
                    Size = Size.Medium
                },
                new Fries
                {
                    Id = 7,
                    Name = "Nugget",
                    Price = 29,
                    Photo = "f012288d-4cb5-4546-a5a1-82a2e34457ce_Nuggets.jpg",
                    Size = Size.Medium
                },
                new Fries
                {
                    Id = 8,
                    Name = "Chicken Tenders",
                    Price = 29,
                    Photo = "1e165d0c-cdad-4956-a803-a291756320b1_ChickenTenders.jpg",
                    Size = Size.Medium
                },
                new Fries
                {
                    Id = 9,
                    Name = "Potatoes",
                    Price = 28,
                    Photo = "301422bb-3c9f-4670-87ec-52f6bb49510e_Potatoes.jpg",
                    Size = Size.Large
                },
                new Fries
                {
                    Id = 10,
                    Name = "Onion Ring",
                    Price = 30,
                    Photo = "40149d5b-324f-40d3-802c-0866bc9edac8_OnionRings.jpg",
                    Size = Size.Large
                },
                new Fries
                {
                    Id = 11,
                    Name = "Nugget",
                    Price = 33,
                    Photo = "f012288d-4cb5-4546-a5a1-82a2e34457ce_Nuggets.jpg",
                    Size = Size.Large
                },
                new Fries
                {
                    Id = 12,
                    Name = "Chicken Tenders",
                    Price = 33,
                    Photo = "1e165d0c-cdad-4956-a803-a291756320b1_ChickenTenders.jpg",
                    Size = Size.Large
                }
                );
        }
    }
}
