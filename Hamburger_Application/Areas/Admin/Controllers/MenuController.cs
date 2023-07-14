using Hamburger_Application.Areas.Admin.Models.ViewModels.Menu;
using Hamburger_Application.Entities.Concrete;
using Hamburger_Application.Repositories.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Hamburger_Application.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class MenuController : Controller
	{
        private readonly IMenuRepository menuRepository;
        private readonly IRepository<Hamburger> hamburgerRepository;
        private readonly IRepository<Drink> drinkRepository;
        private readonly IRepository<Fries> friesRepository;

        public MenuController(IMenuRepository menuRepository,IRepository<Hamburger> hamburgerRepository,IRepository<Drink> drinkRepository,IRepository<Fries> friesRepository) 
		{
            this.menuRepository = menuRepository;
            this.hamburgerRepository = hamburgerRepository;
            this.drinkRepository = drinkRepository;
            this.friesRepository = friesRepository;
        }
		public IActionResult List()
		{
			MenuListVM menuListVM = new MenuListVM();
			menuListVM.Menus = menuRepository.GetAllIncludeFriesIncludeDrinkIncludeHamburger().ToList();
			List<Menu> menuList = new List<Menu>();
			foreach(Menu menu in  menuListVM.Menus) 
			{
				Drink drink= drinkRepository.GetById((int)menu.DrinkId);
                Fries fries = friesRepository.GetById((int)menu.FriesId);
                Hamburger hamburger = hamburgerRepository.GetById((int)menu.HamburgerId);
				menu.Fries = fries;
				menu.Drink = drink;
				menu.Hamburger = hamburger;
				menuList.Add(menu);	
            }
			menuListVM.Menus = menuList;
			return View(menuListVM);
		}
	}
}
