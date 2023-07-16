using Hamburger_Application.Entities.Enum;

namespace Hamburger_Application.Areas.Admin.Models.ViewModels.Fries
{
	public class UpdateFriesVM
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public decimal? Price { get; set; }
		public bool isActive { get; set; } = true;
		public int Piece { get; set; }
		public IFormFile imgCover { get; set; }
		public Size Size { get; set; }
	}
}
