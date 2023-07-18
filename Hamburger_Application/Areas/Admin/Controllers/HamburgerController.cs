using AutoMapper;
using Hamburger_Application.Areas.Admin.Models.ViewModels.Hamburger;
using Hamburger_Application.Areas.User.Utilities;
using Hamburger_Application.Entities.Concrete;
using Hamburger_Application.Repositories.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

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
			ViewData["WebSiteTitle"] = "Hamburgers";
			return View(hamburgers);
		}

		public IActionResult Create()
		{
			ViewData["WebSiteTitle"] = "Create New Hamburger";
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> Create(CreateHamburgerVM hamburgerVM, IFormFile imgCover)
		{
			if (ModelState.IsValid)
			{
				Hamburger hamburger = mapper.Map<Hamburger>(hamburgerVM);
				hamburger.Photo = PhotoFile.GenerateUniqueFileName(imgCover);
				bool isAdded = hamburgerRepository.Add(hamburger);
				if (imgCover is not null)
				{
					FileStream file = new FileStream("wwwroot/ProductImages/Hamburger1/" + hamburger.Photo, FileMode.Create);
					await imgCover.CopyToAsync(file);
				}
				if (isAdded)
				{
					TempData["Info"] = "Hamburger is added";
					ViewData["WebSiteTitle"] = "Hamburgers";
					return RedirectToAction("List");
				}
				else
				{
					ViewBag.Info = "Failed to add hamburger";
				}
			}
			ViewData["WebSiteTitle"] = "Create New Hamburger";
			return View(hamburgerVM);
		}

		public IActionResult Edit(int id)
		{
			UpdateHamburgerVM hamburgerVM = new();
			Hamburger hamburger = hamburgerRepository.GetById(id);
			hamburgerVM = mapper.Map<UpdateHamburgerVM>(hamburger);
			ViewData["WebSiteTitle"] = "Update";
			return View(hamburgerVM);
		}

		[HttpPost]
		public async Task<IActionResult> Edit(UpdateHamburgerVM updateHamburgerVM, IFormFile imgCover)
		{
			if (ModelState.IsValid)
			{
				Hamburger hamburger = mapper.Map<Hamburger>(updateHamburgerVM);

				hamburger.Photo = PhotoFile.GenerateUniqueFileName(imgCover);
				bool isAdded = hamburgerRepository.Update(hamburger);
				if (imgCover is not null)
				{
					FileStream file = new FileStream("wwwroot/ProductImages/Hamburger1/" + hamburger.Photo, FileMode.Create);
					await imgCover.CopyToAsync(file);
				}
				if (isAdded)
				{
					TempData["Info"] = "Hamburger is updated";
					ViewData["WebSiteTitle"] = "Hamburgers";
					return RedirectToAction("List");
				}
				else
				{
					ViewBag.Info = "Hamburger is failed updated";
				}
			}
			ViewData["WebSiteTitle"] = "Update";
			return View(updateHamburgerVM);
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
			else
			{
				TempData["Info"] = "Hamburger could not be founded.";
			}
			ViewData["WebSiteTitle"] = "Hamburgers";
			return RedirectToAction("List");
		}
	}
}
