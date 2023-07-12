using Hamburger_Application.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hamburger_Application.Configurations
{
	public class HamburgerCFG : IEntityTypeConfiguration<Hamburger>
	{
		public void Configure(EntityTypeBuilder<Hamburger> builder)
		{
			builder.HasData(
				new Hamburger
				{
					Id = 1,
					CreationTime = DateTime.UtcNow,
					isActive = true,
					Name = "Whopper",
					Price = 120,
					Piece = 1
				},
				new Hamburger
				{
					Id = 2,
					CreationTime = DateTime.UtcNow,
					isActive = true,
					Name = "Texas SmokeHouse",
					Price = 140,
					Piece = 1
				},
				new Hamburger
				{
					Id = 3,
					CreationTime = DateTime.UtcNow,
					isActive = true,
					Name = "Fish Royale",
					Price = 110,
					Piece = 1
				},
				new Hamburger
				{
					Id = 4,
					CreationTime = DateTime.UtcNow,
					isActive = true,
					Name = "Big King",
					Price = 150,
					Piece = 1
				},
				new Hamburger
				{
					Id = 5,
					CreationTime = DateTime.UtcNow,
					isActive = true,
					Name = "Chicken Royale",
					Price = 95,
					Piece = 1
				}
				);
		}
	}
}
