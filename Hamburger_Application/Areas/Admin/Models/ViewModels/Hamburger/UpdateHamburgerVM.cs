using Hamburger_Application.Entities.Enum;

namespace Hamburger_Application.Areas.Admin.Models.ViewModels.Hamburger
{
	public class UpdateHamburgerVM
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public decimal? Price { get; set; }
		public int Piece { get; set; }
		public bool IsActive { get; set; } = true;
		public IFormFile imgCover { get; set; }
	}
}
