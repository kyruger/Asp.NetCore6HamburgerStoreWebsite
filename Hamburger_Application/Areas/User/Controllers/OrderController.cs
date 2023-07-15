using Hamburger_Application.Areas.Admin.Models.ViewModels.Menu;
using Hamburger_Application.Areas.User.Models.OrderVMs;
using Hamburger_Application.Entities.Concrete;
using Hamburger_Application.Repositories.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Hamburger_Application.Areas.User.Controllers
{
	[Area("User")]
	public class OrderController : Controller
	{
		private readonly IMenuRepository menuRepository;
		private readonly IRepository<Drink> drinkRepository;
		private readonly IRepository<Fries> friesRepository;
		private readonly IRepository<Hamburger> hamburgerRepository;
		private readonly IRepository<Sauce> sauceRepository;
		private readonly IRepository<Dessert> dessertRepository;

		public OrderController(IMenuRepository menuRepository, IRepository<Drink> drinkRepository, IRepository<Fries> friesRepository, IRepository<Hamburger> hamburgerRepository, IRepository<Sauce> sauceRepository, IRepository<Dessert> dessertRepository) 
		{
			this.menuRepository = menuRepository;
			this.drinkRepository = drinkRepository;
			this.friesRepository = friesRepository;
			this.hamburgerRepository = hamburgerRepository;
			this.sauceRepository = sauceRepository;
			this.dessertRepository = dessertRepository;
		}
		public IActionResult ProductList()
		{
			MenuListVM menuListVM = new MenuListVM();
			menuListVM.Menus = menuRepository.GetAllIncludeFriesIncludeDrinkIncludeHamburger(true);
			List<Menu> menuListTemp = new List<Menu>();
			foreach (var menu in menuListVM.Menus)
			{
				Drink drink = drinkRepository.GetById((int)menu.DrinkId);
				Fries fries = friesRepository.GetById((int)menu.FriesId);
				Hamburger hamburger = hamburgerRepository.GetById((int)menu.HamburgerId);
				menu.Drink = drink;
				menu.Fries = fries;
				menu.Hamburger = hamburger;
				menuListTemp.Add(menu);
			}
			var menuList = menuListVM.Menus;
			var hamburgerList = hamburgerRepository.GetAllTrue(true);
			var friesList = friesRepository.GetAllTrue(true);
			var drinkList = drinkRepository.GetAllTrue(true);
			var sauceList = sauceRepository.GetAllTrue(true);
			var dessertList = dessertRepository.GetAllTrue(true);
			ProductListVM productListVM = new ProductListVM();
			productListVM.Menus = menuList;
			productListVM.Hamburgers = hamburgerList;	
			productListVM.Frieses = friesList;
			productListVM.Drinks = drinkList;
			productListVM.Sauces = sauceList;
			productListVM.Desserts = dessertList;
			return View(productListVM);
		}
		//public IActionResult Cart(int id) 
		//{

		//}
	}
}
