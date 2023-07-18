using Hamburger_Application.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hamburger_Application.Configurations
{
    public class DessertCfg : IEntityTypeConfiguration<Dessert>
    {
        public void Configure(EntityTypeBuilder<Dessert> builder)
        {
            builder.Property(b => b.Name).HasMaxLength(30);
            builder.Property(b => b.Piece).HasDefaultValue(1);
            builder.Property(b => b.IsActive).HasDefaultValue(true);

            builder.HasData
                (
                new Dessert
                {
                    Id = 1,
                    Name = "Brownie",
                    Price = 50,
                    Photo = "cafddece-875e-4d0c-830c-72b3e194666c_Brownie.jpg"
                },
                new Dessert
                {
                    Id = 2,
                    Name = "Milkshake",
                    Price = 40,
                    Photo = "fb998a43-9809-4ebc-a546-ce63ca896be8_MilkShake.jpg"
                },
                new Dessert
                {
                    Id = 3,
                    Name = "Cheesecake",
                    Price = 60,
                    Photo = "ee446133-2bb0-46af-b257-3d1a8930432f_CheeseCake.jpg"
                },
                new Dessert
                {
                    Id = 4,
                    Name = "Ice Cream",
                    Price = 30,
                    Photo = "1d5c1238-10f9-49e6-a388-a541d1d64e4c_IcaCream.jpg"
                },
                new Dessert
                {
                    Id = 5,
                    Name = "Puding",
                    Price = 40,
                    Photo = "a01529c3-70cf-4b43-af5c-db1f8f9a921d_Puding.jpg"
                }
                );
        }
    }
}
