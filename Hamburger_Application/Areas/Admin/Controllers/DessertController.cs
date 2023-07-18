using AutoMapper;
using Hamburger_Application.Areas.Admin.Models;
using Hamburger_Application.Areas.User.Utilities;
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
			ViewData["WebSiteTitle"] = "Desserts";
			return View(dessertListVM);
		}

		public IActionResult Create()
		{
			ViewData["WebSiteTitle"] = "Create New Dessert";
			return View();
		}


		[HttpPost]
		public async Task<IActionResult> Create(DessertCreateVM createVM, IFormFile imgCover)
		{
			if (ModelState.IsValid)
			{
				Dessert dessert = mapper.Map<Dessert>(createVM);
				dessert.Photo = PhotoFile.GenerateUniqueFileName(imgCover);
				bool isAdded = dessertRepository.Add(dessert);
				if (imgCover is not null)
				{
					FileStream stream = new FileStream("wwwroot/ProductImages/Dessert1/" + dessert.Photo, FileMode.Create);
					await imgCover.CopyToAsync(stream);
				}
				if (isAdded)
				{
					TempData["Info"] = "Dessert Created";
					ViewData["WebSiteTitle"] = "Desserts";
					return RedirectToAction("DessertList");
				}
				ViewBag.Info = "Failed to Create dessert";
			}
			ViewData["WebSiteTitle"] = "Create New Dessert";
			return View(createVM);
		}

		public IActionResult Update(int id)
		{
			Dessert dessert = new Dessert();
			dessert = dessertRepository.GetById(id);
			DessertUpdateVM updateVM = mapper.Map<DessertUpdateVM>(dessert);
			ViewData["WebSiteTitle"] = "Update";
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

					dessert.Photo = PhotoFile.GenerateUniqueFileName(imgCover);
					bool isUpdated = dessertRepository.Update(dessert);
					if (imgCover is not null)
					{
						FileStream stream = new FileStream("wwwroot/ProductImages/Dessert1/" + dessert.Photo, FileMode.Create);
						await imgCover.CopyToAsync(stream);
					}
					if (isUpdated)
					{
						TempData["Info"] = "Dessert Updated";
						ViewData["WebSiteTitle"] = "Desserts";
						return RedirectToAction("DessertList");
					}
					else
						ViewBag.Info = "Failed to Update dessert";
				}
			}
			ViewData["WebSiteTitle"] = "Update";
			return View(updateVM);
		}

		public IActionResult Delete(int id)
		{
			Dessert dessert = dessertRepository.GetById(id);
			bool isDeleted = dessertRepository.Delete(dessert);
			if (isDeleted)
			{
				TempData["Info"] = "Dessert activity became false";
			}
			else TempData["Info"] = "Failed to change dessert activity";

			ViewData["WebSiteTitle"] = "Desserts";
			return RedirectToAction("DessertList");
		}
	}
}
