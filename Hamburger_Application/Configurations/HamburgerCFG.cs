using Hamburger_Application.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hamburger_Application.Configurations
{
	public class HamburgerCFG : IEntityTypeConfiguration<Hamburger>
	{
		public void Configure(EntityTypeBuilder<Hamburger> builder)
		{
            builder.Property(a => a.isActive).HasDefaultValue(true);

            builder.HasData(
				new Hamburger
				{
					Id = 1,
					Name = "Whopper",
					Price = 120,
					Piece = 1
				},
				new Hamburger
				{
					Id = 2,
					Name = "Texas SmokeHouse",
					Price = 140,
					Piece = 1
				},
				new Hamburger
				{
					Id = 3,
					Name = "Fish Royale",
					Price = 110,
					Piece = 1
				},
				new Hamburger
				{
					Id = 4,
					Name = "Big King",
					Price = 150,
					Piece = 1
				},
				new Hamburger
				{
					Id = 5,
					Name = "Chicken Royale",
					Price = 95,
					Piece = 1
				}
				);
		}
	}
}
