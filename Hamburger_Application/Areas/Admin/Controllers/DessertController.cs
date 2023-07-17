using AutoMapper;
using Hamburger_Application.Areas.Admin.Models;
using Hamburger_Application.Entities.Concrete;
using Hamburger_Application.Entities.Enum;
using Hamburger_Application.Repositories.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Hamburger_Application.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class DessertController : Controller
    {
        private readonly IRepository<Dessert> dessertRepository;
        private readonly IMapper mapper;

        public DessertController(IRepository<Dessert> dessertRepository, IMapper mapper)
        {
            this.dessertRepository = dessertRepository;
            this.mapper = mapper;
        }

        [AllowAnonymous]
        public IActionResult DessertList()
        {
            DessertListVM dessertListVM = new DessertListVM();
            dessertListVM.Desserts = dessertRepository.GetAllTrue(true).ToList();
            return View(dessertListVM);
        }

        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Create(DessertCreateVM createVM, IFormFile imgCover)
        {
            if (ModelState.IsValid)
            {
                Dessert dessert = mapper.Map<Dessert>(createVM);
                dessert.Photo = GenerateUniqueFileName(imgCover);
                bool isAdded = dessertRepository.Add(dessert);

                FileStream stream = new FileStream("wwwroot/ProductImages/Dessert1/" + dessert.Photo, FileMode.Create);
                await imgCover.CopyToAsync(stream);
                if (isAdded)
                {
                    TempData["info"] = "Dessert Created";
                    return RedirectToAction("DessertList");
                }
                ViewBag.info = "Failed to Create dessert";
            }
            return View(createVM);
        }

        public IActionResult Update(int id)
        {
            Dessert dessert = new Dessert();
            dessert = dessertRepository.GetById(id);
            DessertUpdateVM updateVM = mapper.Map<DessertUpdateVM>(dessert);
            return View(updateVM);
        }

        [HttpPost]
        public async Task<IActionResult> Update(DessertUpdateVM updateVM, IFormFile imgCover)
        {
            if (ModelState.IsValid)
            {
                if (updateVM is not null)
                {
                    Dessert dessert = mapper.Map<Dessert>(updateVM);

                    dessert.Photo = GenerateUniqueFileName(imgCover);
                    bool isUpdated = dessertRepository.Update(dessert);

                    FileStream stream = new FileStream("wwwroot/ProductImages/Dessert1/" + dessert.Photo, FileMode.Create);
                    await imgCover.CopyToAsync(stream);
                    if (isUpdated)
                    {
                        TempData["info"] = "Dessert Updated";
                        return RedirectToAction("DessertList");
                    }
                    else
                        ViewBag.info = "Failed to Update dessert";
                }
            }
            return View(updateVM);
        }

        public IActionResult Delete(int id)
        {
            Dessert dessert = dessertRepository.GetById(id);
            bool isDeleted = dessertRepository.Delete(dessert);
            if (isDeleted)
            {
                TempData["info"] = "Dessert activity became false";

            }
            else
                TempData["info"] = "Failed to change dessert activity";

            return RedirectToAction("DessertList");
        }

        [NonAction]
        private string GenerateUniqueFileName(IFormFile file)
        {
            if (file is not null)
            {
                Guid guid = Guid.NewGuid();
                string newFileName = guid.ToString() + "_" + file.FileName;
                return newFileName;
            }
            return null;
        }

    }
}
