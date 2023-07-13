using Hamburger_Application.Entities.Concrete;
using Hamburger_Application.Models;
using Hamburger_Application.Repositories.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Hamburger_Application.Areas.Admin.Controllers
{
    [Area("Admin")]
	public class DrinkController : Controller
	{
        private readonly IRepository<Drink> drinkRepository;

        public DrinkController(IRepository<Drink> drinktRepository)
        {
            this.drinkRepository = drinkRepository;
        }
        public IActionResult DrinkList()
        {
            DrinkListVM drinkListVM = new DrinkListVM();
            drinkListVM.Drinks = drinkRepository.GetAll().ToList();
            return View(drinkListVM);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(DrinkCreatVM createVM, IFormFile imgCover)
        {


            return View();
        }

        public IActionResult Update(int id)
        {
            DrinkUpdateVM updateVM = new DrinkUpdateVM();
            Drink drink = new Drink();
            drink = drinkRepository.GetById(id);
            updateVM.Name = drink.Name;
            updateVM.Price = drink.Price;
            updateVM.isActive = drink.isActive;
            updateVM.Piece = drink.Piece;
            updateVM.Photo = drink.Photo;
            return View(updateVM);
        }
        [HttpPost]
        public IActionResult Update(Drink drink)
        {
            bool isUpdated = drinkRepository.Update(drink);
            if (isUpdated)
            {
                TempData["info"] = "Drink Updated";
                return RedirectToAction("DrinkList");
            }
            ViewBag.info = "Failed to Update drink";
            return View(drink);

        }
        public IActionResult Delete(int id)
        {
            Drink drink = new Drink();
            bool isDeleted = drinkRepository.Delete(drink);
            if (isDeleted)
            {
                TempData["info"] = "Drink activity became false";
                return RedirectToAction("DrinkList");
            }
            ViewBag.info = "Failed to change drink activity";
            return View(drink);
        }
}
