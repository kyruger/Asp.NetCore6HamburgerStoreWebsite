using AutoMapper;
using Hamburger_Application.Areas.Admin.Models.ViewModels.Hamburger;
using Hamburger_Application.Entities.Concrete;
using Hamburger_Application.Repositories.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace Hamburger_Application.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class HamburgerController : Controller
    {
        private readonly IRepository<Hamburger> hamburgerRepository;
        private readonly IMapper mapper;

        public HamburgerController(IRepository<Hamburger> hamburgerRepository, IMapper mapper)
        {
            this.hamburgerRepository = hamburgerRepository;
            this.mapper = mapper;
        }

        [AllowAnonymous]
        public IActionResult List()
        {
            IEnumerable<Hamburger> hamburgers = hamburgerRepository.GetAllTrue(true);
            return View(hamburgers);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateHamburgerVM hamburgerVM, IFormFile imgCover)
        {
            if (ModelState.IsValid)
            {
                Hamburger hamburger = mapper.Map<Hamburger>(hamburgerVM);
                hamburger.Photo = GenerateUniqueFileName(imgCover);
                bool isAdded = hamburgerRepository.Add(hamburger);

                FileStream file = new FileStream("wwwroot/ProductImages/Hamburger1/" + hamburger.Photo, FileMode.Create);
                await imgCover.CopyToAsync(file);
                if (isAdded)
                {
                    TempData["Info"] = "Hamburger is added";
                    return RedirectToAction("List");
                }
                else
                {
                    ViewBag.Info = "Failed to add hamburger";
                }
            }
            return View(hamburgerVM);
        }

        public IActionResult Edit(int id)
        {
            UpdateHamburgerVM hamburgerVM = new();
            Hamburger hamburger = hamburgerRepository.GetById(id);
            hamburgerVM = mapper.Map<UpdateHamburgerVM>(hamburger);
            return View(hamburgerVM);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(UpdateHamburgerVM updateHamburgerVM, IFormFile imgCover)
        {
            if (ModelState.IsValid)
            {
                Hamburger hamburger = mapper.Map<Hamburger>(updateHamburgerVM);

                if (hamburger is not null)
                {
                    hamburger.Photo = GenerateUniqueFileName(imgCover);
                    bool isAdded = hamburgerRepository.Update(hamburger);

                    FileStream file = new FileStream("wwwroot/ProductImages/Hamburger1/" + hamburger.Photo, FileMode.Create);
                    await imgCover.CopyToAsync(file);
                    if (isAdded)
                    {
                        TempData["Info"] = "Hamburger is updated";
                    }
                    else
                    {
                        ViewBag.Info = "Hamburger is failed updated";
                        return View(updateHamburgerVM);
                    }
                }
            }
            return RedirectToAction("List");
        }

        public IActionResult Delete(int id)
        {
            Hamburger hamburger = hamburgerRepository.GetById(id);
            if (hamburger is not null)
            {
                bool isDeleted = hamburgerRepository.Delete(hamburger);
                if (isDeleted)
                {
                    TempData["Info"] = "Hamburger is deleted";
                }
                else
                {
                    TempData["Info"] = "Hamburger is not deleted";
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
