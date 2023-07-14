using AutoMapper;
using Hamburger_Application.Areas.Admin.Models;
using Hamburger_Application.Entities.Concrete;
using Hamburger_Application.Repositories.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Hamburger_Application.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DessertController : Controller
    {
        private readonly IRepository<Dessert> dessertRepository;
        private readonly IMapper mapper;

        public DessertController(IRepository<Dessert> dessertRepository,IMapper mapper)
        {
            this.dessertRepository = dessertRepository;
            this.mapper = mapper;
        }
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
            Dessert dessert=mapper.Map<Dessert>(createVM);
            bool isAdded=dessertRepository.Add(dessert);

            dessert.Photo=GenerateUniqueFileName(imgCover);
            FileStream stream = new FileStream("wwwroot/ProductImages/Dessert/" + dessert.Photo, FileMode.Create);
            await imgCover.CopyToAsync(stream);
            if (isAdded)
            {
                TempData["info"] = "Dessert Created";
                return RedirectToAction("DessertList");
            }
            ViewBag.info = "Failed to Create dessert";
            return View(dessert);
        }

        public IActionResult Update(int id)
        {
            Dessert dessert = new Dessert();
            dessert=dessertRepository.GetById(id);
            DessertUpdateVM updateVM = mapper.Map<DessertUpdateVM>(dessert);       
            return View(updateVM);  
        }
        [HttpPost]
        public async Task<IActionResult> Update(DessertUpdateVM updateVM,IFormFile imgCover)
        {
            Dessert dessert =mapper.Map<Dessert>(updateVM);

            bool isUpdated=dessertRepository.Update(dessert);

            dessert.Photo = GenerateUniqueFileName(imgCover);
            FileStream stream = new FileStream("wwwroot/ProductImages/Dessert/" + dessert.Photo, FileMode.Create);
            await imgCover.CopyToAsync(stream);
            if (isUpdated) 
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
        [NonAction]
        private string GenerateUniqueFileName(IFormFile file)
        {
            Guid guid = Guid.NewGuid();
            string newFileName = guid.ToString() + "_" + file.FileName;
            return newFileName;
        }

    }
}
