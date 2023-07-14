namespace Hamburger_Application.Areas.Admin.Models.ViewModels.Fries
{
	public class CreateFriesVM
	{
		public string Name { get; set; }
		public decimal? Price { get; set; }
		public int Piece { get; set; }
		public string? Photo { get; set; }
	}
}
