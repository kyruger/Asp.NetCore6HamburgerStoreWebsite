using AutoMapper;
using Hamburger_Application.Areas.Admin.Models.ViewModels.Menu;
using Hamburger_Application.Entities.Concrete;
using Hamburger_Application.Repositories.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Org.BouncyCastle.Math;
using System.Data;

namespace Hamburger_Application.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class MenuController : Controller
    {
        private readonly IMenuRepository menuRepository;
        private readonly IRepository<Hamburger> hamburgerRepository;
        private readonly IRepository<Drink> drinkRepository;
        private readonly IRepository<Fries> friesRepository;
        private readonly IMapper mapper;

        public MenuController(IMenuRepository menuRepository, IRepository<Hamburger> hamburgerRepository, IRepository<Drink> drinkRepository, IRepository<Fries> friesRepository, IMapper mapper)
        {
            this.menuRepository = menuRepository;
            this.hamburgerRepository = hamburgerRepository;
            this.drinkRepository = drinkRepository;
            this.friesRepository = friesRepository;
            this.mapper = mapper;
        }

        [AllowAnonymous]
        public IActionResult List()
        {
            MenuListVM menuListVM = new MenuListVM();
            menuListVM.Menus = menuRepository.GetAllIncludeFriesIncludeDrinkIncludeHamburger(true).ToList();
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

            return View(menuVM);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Menu menu, IFormFile imgCover)
        {
            if (ModelState.IsValid)
            {
                menu.Photo = GenerateUniqueFileName(imgCover);
                bool isAdded = menuRepository.Add(menu);

                FileStream file = new FileStream("wwwroot/ProductImages/Menu1/" + menu.Photo, FileMode.Create);
                await imgCover.CopyToAsync(file);
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
                return View(createMenuVM);
            }
            else
            {
                TempData["Info"] = "Menu cannot be found";
            }
            return RedirectToAction("List");
        }

        [HttpPost]
        public async Task<IActionResult> Edit(CreateMenuVM createMenuVM, IFormFile imgCover)
        {
            if (ModelState.IsValid)
            {
                createMenuVM.Menu.Photo = GenerateUniqueFileName(imgCover);
                bool isAdded = menuRepository.Update(createMenuVM.Menu);

                FileStream file = new FileStream("wwwroot/ProductImages/Menu1/" + createMenuVM.Menu.Photo, FileMode.Create);
                await imgCover.CopyToAsync(file);
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
            return View(createMenuVM);
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
                }
                else
                {
                    TempData["Info"] = "Menu is not deleted";
                }
            }
            return RedirectToAction("List");
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
