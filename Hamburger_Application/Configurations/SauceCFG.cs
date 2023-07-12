using Hamburger_Application.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hamburger_Application.Configurations
{
    public class SauceCFG : IEntityTypeConfiguration<Sauce>
    {
        public void Configure(EntityTypeBuilder<Sauce> builder)
        {
            builder.Property(a => a.isActive).HasDefaultValue(true);

            builder.HasData(
                new Sauce
                {
                    Id = 1,
                    Name = "Ranch",
                    Price = 15,
                    Piece = 1
                },
                new Sauce
                {
                    Id = 2,
                    Name = "Ketchup",
                    Price = 10,
                    Piece = 1
                },
                new Sauce
                {
                    Id = 3,
                    Name = "Mayonnaise",
                    Price = 10,
                    Piece = 1
                },
                new Sauce
                {
                    Id = 4,
                    Name = "Barbeque",
                    Price = 15,
                    Piece = 1
                }
                );
        }
    }
}
