namespace Hamburger_Application.Areas.Admin.Models.ViewModels.Hamburger
{
	public class CreateHamburgerVM
	{
		public string Name { get; set; }
		public decimal? Price { get; set; }
		public int Piece { get; set; }
		public IFormFile imgCover { get; set; }
	}
}
