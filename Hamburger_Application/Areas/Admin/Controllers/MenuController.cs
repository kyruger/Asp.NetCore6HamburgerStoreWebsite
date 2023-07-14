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

        public MenuController(IMenuRepository menuRepository) 
		{
            this.menuRepository = menuRepository;
        }
		public IActionResult List()
		{
			MenuListVM menuListVM = new MenuListVM();
			menuListVM.Menus = menuRepository.GetAllIncludeFriesIncludeDrink().ToList();
			return View(menuListVM);
		}
	}
}
