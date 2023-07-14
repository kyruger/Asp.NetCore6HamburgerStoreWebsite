using AutoMapper;
using Hamburger_Application.Areas.Admin.Models;
using Hamburger_Application.Entities.Concrete;
using Hamburger_Application.Repositories.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Hamburger_Application.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DrinkController : Controller
    {
        private readonly IRepository<Drink> drinkRepository;
        private readonly IMapper mapper;

        public DrinkController(IRepository<Drink> drinktRepository, IMapper mapper)
        {
            drinkRepository = drinkRepository;
            this.mapper = mapper;
        }
        public IActionResult DrinkList()
        {
            DrinkListVM drinkListVM = new DrinkListVM();
            drinkListVM.Drinks = drinkRepository.GetAllTrue(true).ToList();
            return View(drinkListVM);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(DrinkCreatVM createVM, IFormFile imgCover)
        {
            Drink drink=mapper.Map<Drink>(createVM);
            bool isAdded=drinkRepository.Add(drink);
            drink.Photo=GenerateUniqueFileName(imgCover);   
            FileStream stream= new FileStream("wwwroot/ProductImages/Drink/" + drink.Photo, FileMode.Create);
            await imgCover.CopyToAsync(stream);
            if (isAdded)
            {
                TempData["info"] = "Drink Created";
                return RedirectToAction("DrinkList");
            }
            ViewBag.info = "Failed to Create drink";
            return View(drink);
   
        }

        public IActionResult Update(int id)
        {
            Drink drink = new Drink();
            drink = drinkRepository.GetById(id);
            DrinkUpdateVM updateVM = mapper.Map<DrinkUpdateVM>(drink); 
            return View(updateVM);
        }
        [HttpPost]
        public async Task<IActionResult> Update(DrinkUpdateVM updateVM,IFormFile imgCover)
        {
            Drink drink = mapper.Map<Drink>(updateVM);

            drink.Photo = GenerateUniqueFileName(imgCover);
            FileStream stream = new FileStream("wwwroot/ProductImages/Drink/" + drink.Photo, FileMode.Create);
            await imgCover.CopyToAsync(stream);

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
        private string GenerateUniqueFileName(IFormFile file)
        {
            Guid guid = Guid.NewGuid();
            string newFileName = guid.ToString() + "_" + file.FileName;
            return newFileName;
        }
    }
}
