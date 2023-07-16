namespace Hamburger_Application.Areas.Admin.Models.ViewModels.Sauce
{
	public class CreateSauceVM
	{
		public string Name { get; set; }
		public decimal? Price { get; set; }
		public int Piece { get; set; }
		public IFormFile imgCover { get; set; }
	}
}
