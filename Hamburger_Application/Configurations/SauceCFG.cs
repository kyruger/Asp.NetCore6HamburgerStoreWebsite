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
            builder.Property(b => b.Piece).HasDefaultValue(1);
            builder.Property(b => b.IsActive).HasDefaultValue(true);

            builder.HasData
                (
                new Sauce
                {
                    Id = 1,
                    Name = "Ranch",
                    Price = 15,
                    Photo = "7b5e0551-d08d-4092-8c72-ff370ea64c57_RanchSauce.jpg"
                },
                new Sauce
                {
                    Id = 2,
                    Name = "Ketchup",
                    Price = 10,
                    Photo = "f8b55022-2756-43dd-823d-6b94e43d9807_KetchupSauce.jpg"
                },
                new Sauce
                {
                    Id = 3,
                    Name = "Mayonnaise",
                    Price = 10,
                    Photo = "7821c0f8-2b4b-4b46-b958-6fe2dec26bd7_MayonaisseSauce.jpg"
                },
                new Sauce
                {
                    Id = 4,
                    Name = "Barbeque",
                    Price = 15,
                    Photo = "cad13c53-f4c9-4b94-aaa7-cb20855cd41e_BarbequeSauce.jpg"
                }
                );
        }
    }
}
