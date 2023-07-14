using AutoMapper;
using Hamburger_Application.Areas.Admin.Models.ViewModels.Menu;
using Hamburger_Application.Entities.Concrete;
using Hamburger_Application.Repositories.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Org.BouncyCastle.Math;

namespace Hamburger_Application.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class MenuController : Controller
	{
		private readonly IMenuRepository menuRepository;
		private readonly IRepository<Hamburger> hamburgerRepository;
		private readonly IRepository<Drink> drinkRepository;
		private readonly IRepository<Fries> friesRepository;
		private readonly IRepository<Dessert> dessertRepository;
		private readonly IMapper mapper;

		public MenuController(IMenuRepository menuRepository, IRepository<Hamburger> hamburgerRepository, IRepository<Drink> drinkRepository, IRepository<Fries> friesRepository, IRepository<Dessert> dessertRepository, IMapper mapper)
		{
			this.menuRepository = menuRepository;
			this.hamburgerRepository = hamburgerRepository;
			this.drinkRepository = drinkRepository;
			this.friesRepository = friesRepository;
			this.dessertRepository = dessertRepository;
			this.mapper = mapper;
		}
		public IActionResult List()
		{
			MenuListVM menuListVM = new MenuListVM();
			menuListVM.Menus = menuRepository.GetAllIncludeFriesIncludeDrinkIncludeHamburger().ToList();
			List<Menu> menuList = new List<Menu>();
			foreach (Menu menu in menuListVM.Menus)
			{
				Drink drink = drinkRepository.GetById((int)menu.DrinkId);
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
		public IActionResult Create()
		{
			CreateMenuVM menuVM = new CreateMenuVM();
			menuVM.Menu = new();
			menuVM.Fries = new SelectList(friesRepository.GetAll(), "Id", "Name");
			menuVM.Drinks = new SelectList(drinkRepository.GetAll(), "Id", "Name");
			menuVM.Hamburgers = new SelectList(hamburgerRepository.GetAll(), "Id", "Name");
			menuVM.Desserts = new SelectList(dessertRepository.GetAll(), "Id", "Name");

			return View(menuVM);
		}
		[HttpPost]
		public async Task<IActionResult> Create(Menu menu, IFormFile imageName)
		{
			if (ModelState.IsValid)
			{
				bool isAdded = menuRepository.Add(menu);
				menu.Photo = GenerateUniqueFileName(imageName);

				FileStream file = new FileStream("wwwroot/ProductImages/Menu/" + menu.Photo, FileMode.Create);
				await imageName.CopyToAsync(file);
				if (isAdded)
				{
					TempData["Info"] = "Menu succesfully added";
					return RedirectToAction("List");
				}
				else
				{
					ViewBag.Info = "Failed to Add Menu";
				}
			}
			return View(menu);
		}
		public IActionResult Edit(int id)
		{
			CreateMenuVM createMenuVM = new();
			createMenuVM.Menu = menuRepository.GetById(id);
			if (createMenuVM.Menu is not null)
			{
				createMenuVM.Drinks = new SelectList(drinkRepository.GetAllTrue(true), "Id", "Name");
				createMenuVM.Hamburgers = new SelectList(hamburgerRepository.GetAllTrue(true), "Id", "Name");
				createMenuVM.Fries = new SelectList(friesRepository.GetAllTrue(true), "Id", "Name");
				createMenuVM.Desserts = new SelectList(dessertRepository.GetAllTrue(true), "Id", "Name");
				return View(createMenuVM);
			}
			else
			{
				TempData["Info"] = "Menu cannot be found";
			}
			return RedirectToAction("List");
		}


		[HttpPost]
		public async Task<IActionResult> Edit(Menu menu, IFormFile imageName)
		{
			if (ModelState.IsValid)
			{
				bool isAdded = menuRepository.Add(menu);
				menu.Photo = GenerateUniqueFileName(imageName);

				FileStream file = new FileStream("wwwroot/ProductImages/Menu/" + menu.Photo, FileMode.Create);
				await imageName.CopyToAsync(file);
				if (isAdded)
				{
					TempData["Info"] = "Menu succesfully added";
					return RedirectToAction("List");
				}
				else
				{
					ViewBag.Info = "Failed to Add Menu";
				}
			}
			return View(menu);
		}
        public IActionResult Delete(int id)
        {
            Menu menu = menuRepository.GetById(id);
            if (menu is not null)
            {
                bool isDeleted = menuRepository.Delete(menu);
                if (isDeleted)
                {
                    TempData["Info"] = "Menu is deleted";
                    return RedirectToAction("List");
                }
                else
                {
                    ViewBag.IsDeleted = "Menu is not deleted";
                }
            }
            return View(menu);
        }

        [NonAction]
		private string GenerateUniqueFileName(IFormFile file)
		{
			Guid guid = Guid.NewGuid();
			string newFileName = guid.ToString() + "_" + file.FileName;
			return newFileName;
		}
	}
}
