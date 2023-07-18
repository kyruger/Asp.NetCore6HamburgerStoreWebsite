using AutoMapper;
using Hamburger_Application.Areas.Admin.Models;
using Hamburger_Application.Areas.User.Utilities;
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
			ViewData["WebSiteTitle"] = "Drinks";
			return View(drinkListVM);
		}

		public IActionResult Create()
		{
			var enumList = Enum.GetValues(typeof(Size)).Cast<Size>().ToList();
			SelectList selectList = new SelectList(enumList);
			ViewBag.size = selectList;
			ViewData["WebSiteTitle"] = "Create New Drink";
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> Create(DrinkCreatVM createVM, IFormFile imgCover)
		{
			if (ModelState.IsValid)
			{
				Drink drink = mapper.Map<Drink>(createVM);
				drink.Photo = PhotoFile.GenerateUniqueFileName(imgCover);
				bool isAdded = drinkRepository.Add(drink);
				if (imgCover is not null)
				{
					FileStream stream = new FileStream("wwwroot/ProductImages/Drink/" + drink.Photo, FileMode.Create);
					await imgCover.CopyToAsync(stream);
				}
				if (isAdded)
				{
					TempData["Info"] = "Drink is added";
					ViewData["WebSiteTitle"] = "Drinks";
					return RedirectToAction("DrinkList");
				}
				else ViewBag.Info = "Failed to add drink";
			}
			ViewData["WebSiteTitle"] = "Create New Drink";
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
			ViewData["WebSiteTitle"] = "Update";
			return View(updateVM);
		}

		[HttpPost]
		public async Task<IActionResult> Update(DrinkUpdateVM updateVM, IFormFile imgCover)
		{
			if (ModelState.IsValid)
			{
				Drink drink = mapper.Map<Drink>(updateVM);

				drink.Photo = PhotoFile.GenerateUniqueFileName(imgCover);
				bool isUpdated = drinkRepository.Update(drink);
				if (imgCover is not null)
				{
					FileStream stream = new FileStream("wwwroot/ProductImages/Drink/" + drink.Photo, FileMode.Create);
					await imgCover.CopyToAsync(stream);
				}
				if (isUpdated)
				{
					TempData["Info"] = "Drink Updated";
					ViewData["WebSiteTitle"] = "Drinks";
					return RedirectToAction("DrinkList");
				}
				else ViewBag.Info = "Failed to Update drink";
			}
			ViewData["WebSiteTitle"] = "Update";
			return View(updateVM);
		}
		public IActionResult Delete(int id)
		{
			Drink drink = drinkRepository.GetById(id);
			bool isDeleted = drinkRepository.Delete(drink);
			if (isDeleted)
			{
				TempData["Info"] = "Drink activity became false";
				ViewData["WebSiteTitle"] = "Drinks";
				return RedirectToAction("DrinkList");
			}
			ViewBag.Info = "Failed to change drink activity";
			return View(drink);
		}
	}
}
