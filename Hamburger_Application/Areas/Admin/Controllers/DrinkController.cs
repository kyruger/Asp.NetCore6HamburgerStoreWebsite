using AutoMapper;
using Hamburger_Application.Areas.Admin.Models;
using Hamburger_Application.Entities.Concrete;
using Hamburger_Application.Entities.Enum;
using Hamburger_Application.Repositories.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Data;

namespace Hamburger_Application.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class DrinkController : Controller
    {
        private readonly IRepository<Drink> drinkRepository;
        private readonly IMapper mapper;

        public DrinkController(IRepository<Drink> drinkRepository, IMapper mapper)
        {
            this.drinkRepository = drinkRepository;
            this.mapper = mapper;
        }

        [AllowAnonymous]
        public IActionResult DrinkList()
        {
            DrinkListVM drinkListVM = new DrinkListVM();
            drinkListVM.Drinks = drinkRepository.GetAllTrue(true).ToList();
            return View(drinkListVM);
        }

        public IActionResult Create()
        {
            var enumList = Enum.GetValues(typeof(Size)).Cast<Size>().ToList();
            SelectList selectList = new SelectList(enumList);
            ViewBag.size = selectList;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(DrinkCreatVM createVM, IFormFile imgCover)
        {
            if (ModelState.IsValid)
            {
                Drink drink = mapper.Map<Drink>(createVM);
                drink.Photo = GenerateUniqueFileName(imgCover);
                bool isAdded = drinkRepository.Add(drink);
                FileStream stream = new FileStream("wwwroot/ProductImages/Drink/" + drink.Photo, FileMode.Create);
                await imgCover.CopyToAsync(stream);
                if (isAdded)
                {
                    TempData["Info"] = "Drink is added";
                    return RedirectToAction("DrinkList");
                }
                else
                    ViewBag.Info = "Failed to add drink";
            }
            return View(createVM);


        }

        public IActionResult Update(int id)
        {
            Drink drink = new Drink();
            drink = drinkRepository.GetById(id);
            DrinkUpdateVM updateVM = mapper.Map<DrinkUpdateVM>(drink);
            var enumList = Enum.GetValues(typeof(Size)).Cast<Size>().ToList();
            SelectList selectList = new SelectList(enumList);
            ViewBag.size = selectList;
            return View(updateVM);
        }

        [HttpPost]
        public async Task<IActionResult> Update(DrinkUpdateVM updateVM, IFormFile imgCover)
        {
            if (ModelState.IsValid)
            {
                Drink drink = mapper.Map<Drink>(updateVM);

                drink.Photo = GenerateUniqueFileName(imgCover);
                bool isUpdated = drinkRepository.Update(drink);
                FileStream stream = new FileStream("wwwroot/ProductImages/Drink/" + drink.Photo, FileMode.Create);
                await imgCover.CopyToAsync(stream);

                if (isUpdated)
                {
                    TempData["Info"] = "Drink Updated";
                    return RedirectToAction("DrinkList");
                }
                else
                    ViewBag.Info = "Failed to Update drink";
            }
            return View(updateVM);
        }
        public IActionResult Delete(int id)
        {
            Drink drink = drinkRepository.GetById(id);
            bool isDeleted = drinkRepository.Delete(drink);
            if (isDeleted)
            {
                TempData["Info"] = "Drink activity became false";
                return RedirectToAction("DrinkList");
            }
            ViewBag.Info = "Failed to change drink activity";
            return View(drink);
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
