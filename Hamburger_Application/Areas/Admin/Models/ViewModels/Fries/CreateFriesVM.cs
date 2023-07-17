using Hamburger_Application.Entities.Enum;

namespace Hamburger_Application.Areas.Admin.Models.ViewModels.Fries
{
	public class CreateFriesVM
	{
		public string Name { get; set; }
		public decimal? Price { get; set; }
		public int Piece { get; set; }
		public IFormFile imgCover { get; set; }
		public Size Size { get; set; }
	}
}
