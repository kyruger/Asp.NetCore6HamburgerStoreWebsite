using Hamburger_Application.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hamburger_Application.Configurations
{
    public class SauceCfg : IEntityTypeConfiguration<Sauce>
    {
        public void Configure(EntityTypeBuilder<Sauce> builder)
        {
            builder.Property(b => b.Name).HasMaxLength(30);
            builder.HasIndex(b => b.Name).IsUnique();
            builder.Property(b => b.Piece).HasDefaultValue(1);
            builder.Property(b => b.IsActive).HasDefaultValue(true);

            builder.HasData
                (
                new Sauce
                {
                    Id = 1,
                    Name = "Ranch",
                    Price = 15
                },
                new Sauce
                {
                    Id = 2,
                    Name = "Ketchup",
                    Price = 10
                },
                new Sauce
                {
                    Id = 3,
                    Name = "Mayonnaise",
                    Price = 10
                },
                new Sauce
                {
                    Id = 4,
                    Name = "Barbeque",
                    Price = 15
                }
                );
        }
    }
}
