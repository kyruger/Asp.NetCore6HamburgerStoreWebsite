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
            builder.HasIndex(b => b.Name).IsUnique();
            builder.Property(b => b.Piece).HasDefaultValue(1);
            builder.Property(b => b.IsActive).HasDefaultValue(true);
            
            builder.HasData
                (
                new Hamburger
                {
                    Id = 1,
                    Name = "Whopper",
                    Price = 120
                },
                new Hamburger
                {
                    Id = 2,
                    Name = "Texas SmokeHouse",
                    Price = 140
                },
                new Hamburger
                {
                    Id = 3,
                    Name = "Fish Royale",
                    Price = 110
                },
                new Hamburger
                {
                    Id = 4,
                    Name = "Big King",
                    Price = 150
                },
                new Hamburger
                {
                    Id = 5,
                    Name = "Chicken Royale",
                    Price = 95
                }
                );
        }
    }
}
