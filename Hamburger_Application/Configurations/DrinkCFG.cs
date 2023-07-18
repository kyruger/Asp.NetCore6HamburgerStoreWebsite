using Hamburger_Application.Entities.Concrete;
using Hamburger_Application.Entities.Enum;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hamburger_Application.Configurations
{
    public class DrinkCfg : IEntityTypeConfiguration<Drink>
    {
        public void Configure(EntityTypeBuilder<Drink> builder)
        {
            builder.Property(a => a.Name).HasMaxLength(30);
            builder.Property(b => b.Piece).HasDefaultValue(1);
            builder.Property(b => b.Size).HasDefaultValue(Size.Small);
            builder.Property(b => b.IsActive).HasDefaultValue(true);

            builder.HasData
                (
                new Drink
                {
                    Id = 1,
                    Name = "Coke",
                    Price = 40,
                    Photo = "6240f4b6-c927-4898-9c76-6968b54c1e39_Coke.jpg"
                },
                new Drink
                {
                    Id = 2,
                    Name = "Ayran",
                    Price = 25,
                    Photo = "a7e28042-2e4a-443e-860d-0f0cbd0d640c_Ayran.jpg"
                },
                new Drink
                {
                    Id = 3,
                    Name = "Coke Zero",
                    Price = 45,
                    Photo = "1117576e-e2a3-42a5-8dc0-9f5d90fd0e80_CokeZero.jpg"
                },
                new Drink
                {
                    Id = 4,
                    Name = "Cold Tea",
                    Price = 35,
                    Photo = "914e854b-f076-455c-aeab-49f8d8f4ca8e_ColdTea.jpg"
                },
                new Drink
                {
                    Id = 5,
                    Name = "Mineral Water",
                    Price = 15,
                    Photo = "d2ffceeb-e929-43e1-9fc6-df7838fa6aa2_MineralWater.jpg",
                },
                new Drink
                {
                    Id = 6,
                    Name = "Coke",
                    Price = 45,
                    Photo = "6240f4b6-c927-4898-9c76-6968b54c1e39_Coke.jpg",
                    Size = Size.Medium
                },
                new Drink
                {
                    Id = 7,
                    Name = "Ayran",
                    Price = 30,
                    Photo = "a7e28042-2e4a-443e-860d-0f0cbd0d640c_Ayran.jpg",
                    Size = Size.Medium
                },
                new Drink
                {
                    Id = 8,
                    Name = "Coke Zero",
                    Price = 50,
                    Photo = "1117576e-e2a3-42a5-8dc0-9f5d90fd0e80_CokeZero.jpg",
                    Size = Size.Medium
                },
                new Drink
                {
                    Id = 9,
                    Name = "Cold Tea",
                    Price = 40,
                    Photo = "914e854b-f076-455c-aeab-49f8d8f4ca8e_ColdTea.jpg",
                    Size = Size.Medium
                },
                new Drink
                {
                    Id = 10,
                    Name = "Mineral Water",
                    Price = 20,
                    Photo = "d2ffceeb-e929-43e1-9fc6-df7838fa6aa2_MineralWater.jpg",
                    Size = Size.Medium
                },
                new Drink
                {
                    Id = 11,
                    Name = "Coke",
                    Price = 50,
                    Photo = "6240f4b6-c927-4898-9c76-6968b54c1e39_Coke.jpg",
                    Size = Size.Large
                },
                new Drink
                {
                    Id = 12,
                    Name = "Ayran",
                    Price = 35,
                    Photo = "a7e28042-2e4a-443e-860d-0f0cbd0d640c_Ayran.jpg",
                    Size = Size.Large
                },
                new Drink
                {
                    Id = 13,
                    Name = "Coke Zero",
                    Price = 55,
                    Photo = "1117576e-e2a3-42a5-8dc0-9f5d90fd0e80_CokeZero.jpg",
                    Size = Size.Large
                },
                new Drink
                {
                    Id = 14,
                    Name = "Cold Tea",
                    Price = 45,
                    Photo = "914e854b-f076-455c-aeab-49f8d8f4ca8e_ColdTea.jpg",
                    Size = Size.Large
                },
                new Drink
                {
                    Id = 15,
                    Name = "Mineral Water",
                    Price = 25,
                    Photo = "d2ffceeb-e929-43e1-9fc6-df7838fa6aa2_MineralWater.jpg",
                    Size = Size.Large
                }
                );
        }
    }
}
