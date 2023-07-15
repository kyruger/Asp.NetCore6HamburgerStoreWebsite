using Hamburger_Application.Entities.Concrete;

namespace Hamburger_Application.Areas.User.Models.OrderVMs
{
	public class ProductListVM
	{
		public ProductListVM() 
		{
			Menus = new List<Menu>();
			Hamburgers = new List<Hamburger>();
			Frieses = new List<Fries>();
			Drinks = new List<Drink>();
			Sauces = new List<Sauce>();
			Desserts = new List<Dessert>();
		}
		public IEnumerable<Menu> Menus { get; set; }
		public IEnumerable<Hamburger> Hamburgers { get; set; }
		public IEnumerable<Fries> Frieses { get; set; }
		public IEnumerable<Drink> Drinks { get; set; }
		public IEnumerable<Sauce> Sauces { get; set; }
		public IEnumerable<Dessert> Desserts { get; set; }
	}
}
