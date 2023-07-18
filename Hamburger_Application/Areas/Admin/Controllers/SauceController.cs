using AutoMapper;
using Hamburger_Application.Areas.Admin.Models.ViewModels.Hamburger;
using Hamburger_Application.Areas.Admin.Models.ViewModels.Sauce;
using Hamburger_Application.Entities.Concrete;
using Hamburger_Application.Repositories.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace Hamburger_Application.Areas.Admin.Controllers
{
    [Area("Admin")]
    //[Authorize(Roles = "Admin")]
    public class SauceController : Controller
    {
        private readonly IRepository<Sauce> sauceRepository;
        private readonly IMapper mapper;
        public SauceController(IRepository<Sauce> sauceRepository, IMapper mapper)
        {
            this.sauceRepository = sauceRepository;
            this.mapper = mapper;
        }

        [AllowAnonymous]
        public IActionResult List()
        {
            IEnumerable<Sauce> sauces = sauceRepository.GetAllTrue(true);
            return View(sauces);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateSauceVM sauceVM, IFormFile imgCover)
        {
            if (ModelState.IsValid)
            {
                Sauce sauce = mapper.Map<Sauce>(sauceVM);
                sauce.Photo = GenerateUniqueFileName(imgCover);
                bool isAdded = sauceRepository.Add(sauce);

                FileStream file = new FileStream("wwwroot/ProductImages/Sauce1/" + sauce.Photo, FileMode.Create);
                await imgCover.CopyToAsync(file);
                if (isAdded)
                {
                    TempData["Info"] = "Sauces succesfully added";
                    return RedirectToAction("List");
                }
                else
                {
                    ViewBag.Info = "Failed to Add Sauces";
                }
            }
            return View(sauceVM);
        }

        public IActionResult Edit(int id)
        {
            UpdateSauceVM sauceVM = new();
            Sauce sauce = sauceRepository.GetById(id);
            sauceVM = mapper.Map<UpdateSauceVM>(sauce);
            return View(sauceVM);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(UpdateSauceVM updateSauceVM, IFormFile imgCover)
        {
            if (ModelState.IsValid)
            {
                Sauce sauce = mapper.Map<Sauce>(updateSauceVM);

                sauce.Photo = GenerateUniqueFileName(imgCover);
                bool isAdded = sauceRepository.Update(sauce);

                FileStream file = new FileStream("wwwroot/ProductImages/Sauce1/" + sauce.Photo, FileMode.Create);
                await imgCover.CopyToAsync(file);
                if (isAdded)
                {
                    TempData["Info"] = "Sauce is updated";
                    return RedirectToAction("List");
                }
                else
                {
                    ViewBag.Info = "Sauce cannot be updated";
                }
            }
            return View(updateSauceVM);
        }

        public IActionResult Delete(int id)
        {
            Sauce sauce = sauceRepository.GetById(id);
            if (sauce is not null)
            {
                bool isDeleted = sauceRepository.Delete(sauce);
                if (isDeleted)
                {
                    TempData["Info"] = "Sauce is deleted";
                }
                else
                {
                    TempData["info"] = "Sauce is not deleted";
                }
            }
            else
            {
                TempData["Info"] = "Sauce could not be founded.";
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
