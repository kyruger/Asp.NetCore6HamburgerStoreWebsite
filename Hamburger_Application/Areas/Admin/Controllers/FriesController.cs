using AutoMapper;
using Hamburger_Application.Areas.Admin.Models.ViewModels.Fries;
using Hamburger_Application.Areas.User.Utilities;
using Hamburger_Application.Entities.Concrete;
using Hamburger_Application.Entities.Enum;
using Hamburger_Application.Repositories.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Data;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Hamburger_Application.Areas.Admin.Controllers
{
	[Area("Admin")]
	[Authorize(Roles = "Admin")]
	public class FriesController : Controller
	{
		private readonly IRepository<Fries> friesRepository;
		private readonly IMapper mapper;

		public FriesController(IRepository<Fries> friesRepository, IMapper mapper)
		{
			this.friesRepository = friesRepository;
			this.mapper = mapper;
		}

		[AllowAnonymous]
		public IActionResult List()
		{
			IEnumerable<Fries> fries = friesRepository.GetAllTrue(true);
			ViewData["WebSiteTitle"] = "Fries";
			return View(fries);
		}

		public IActionResult Create()
		{
			var enumList = Enum.GetValues(typeof(Size)).Cast<Size>().ToList();
			SelectList selectList = new SelectList(enumList);
			ViewBag.size = selectList;
			ViewData["WebSiteTitle"] = "Create New Fries";
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> Create(CreateFriesVM friesVM, IFormFile imgCover)
		{
			if (ModelState.IsValid)
			{
				Fries fries = mapper.Map<Fries>(friesVM);
				fries.Photo = PhotoFile.GenerateUniqueFileName(imgCover);
				bool isAdded = friesRepository.Add(fries);
				if (imgCover is not null)
				{
					FileStream file = new FileStream("wwwroot/ProductImages/Fries1/" + fries.Photo, FileMode.Create);
					await imgCover.CopyToAsync(file);
				}
				if (isAdded)
				{
					TempData["Info"] = "Fries is added";
					ViewData["WebSiteTitle"] = "Fries";
					return RedirectToAction("List");
				}
				else
				{
					ViewBag.Info = "Fries cannot added";
				}
			}
			ViewData["WebSiteTitle"] = "Create New Fries";
			return View(friesVM);
		}

		public IActionResult Edit(int id)
		{
			UpdateFriesVM friesVM = new();
			Fries fries = friesRepository.GetById(id);
			friesVM = mapper.Map<UpdateFriesVM>(fries);
			var enumList = Enum.GetValues(typeof(Size)).Cast<Size>().ToList();
			SelectList selectList = new SelectList(enumList);
			ViewBag.size = selectList;
			ViewData["WebSiteTitle"] = "Update";
			return View(friesVM);
		}

		[HttpPost]
		public async Task<IActionResult> Edit(UpdateFriesVM updateFriesVM, IFormFile imgCover)
		{
			if (ModelState.IsValid)
			{
				Fries fries = mapper.Map<Fries>(updateFriesVM);
				fries.Photo = PhotoFile.GenerateUniqueFileName(imgCover);
				bool isUpdated = friesRepository.Update(fries);
				if (imgCover is not null)
				{
					FileStream file = new FileStream("wwwroot/ProductImages/Fries1/" + fries.Photo, FileMode.Create);
					await imgCover.CopyToAsync(file);
				}
				if (isUpdated)
				{
					TempData["Info"] = "Fries Updated";
					ViewData["WebSiteTitle"] = "Fries";
					return RedirectToAction("List");
				}
				else
				{
					ViewBag.Info = "Failed to Update fries";
				}
			}
			ViewData["WebSiteTitle"] = "Update";
			return View(updateFriesVM);
		}

		public IActionResult Delete(int id)
		{
			Fries fries = friesRepository.GetById(id);
			if (fries is not null)
			{
				bool isDeleted = friesRepository.Delete(fries);
				if (isDeleted)
				{
					TempData["Info"] = "Fries is deleted";
				}
				else
				{
					TempData["Info"] = "Fries is not deleted";
				}
			}
			else
			{
				TempData["Info"] = "fries could not be founded.";
			}
			ViewData["WebSiteTitle"] = "Fries";
			return RedirectToAction("List");
		}
	}
}
