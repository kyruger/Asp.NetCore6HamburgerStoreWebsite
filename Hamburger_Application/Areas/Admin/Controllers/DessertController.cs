using Hamburger_Application.Entities.Concrete;
using Hamburger_Application.Models;
using Hamburger_Application.Repositories.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Hamburger_Application.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DessertController : Controller
    {
        private readonly IRepository<Dessert> dessertRepository;

        public DessertController(IRepository<Dessert> dessertRepository)
        {
            this.dessertRepository = dessertRepository;
        }
        public IActionResult DessertList()
        {
            DessertListVM dessertListVM = new DessertListVM();
            dessertListVM.Desserts = dessertRepository.GetAll().ToList();
            return View(dessertListVM);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(DessertCreateVM createVM, IFormFile imgCover)
        {


            return View();
        }

        public IActionResult Update(int id)
        {
            DessertUpdateVM updateVM = new DessertUpdateVM();
            Dessert dessert = new Dessert();
            dessert=dessertRepository.GetById(id);
            updateVM.Name = dessert.Name;
            updateVM.Price = dessert.Price; 
            updateVM.isActive=dessert.isActive;
            updateVM.Piece= dessert.Piece;  
            updateVM.Photo=dessert.Photo;
            return View(updateVM);  
        }
        [HttpPost]
        public IActionResult Update(Dessert dessert)
        {
            bool isUpdated=dessertRepository.Update(dessert);   
            if(isUpdated) 
            {
                TempData["info"] = "Dessert Updated";
                return RedirectToAction("DessertList");
            }
            ViewBag.info = "Failed to Update dessert";
            return View(dessert);

        }
        public IActionResult Delete(int id)
        {
            Dessert dessert = new Dessert();
            bool isDeleted= dessertRepository.Delete(dessert);
            if (isDeleted)
            {
                TempData["info"] = "Dessert activity became false";
                return RedirectToAction("DessertList");
            }
            ViewBag.info = "Failed to change dessert activity";
            return View(dessert);
        }

    }
}
