using AutoMapper;
using Hamburger_Application.Areas.Admin.Models.ViewModels.Fries;
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
			return View(fries);
		}

		public IActionResult Create()
		{
			var enumList = Enum.GetValues(typeof(Size)).Cast<Size>().ToList();
			SelectList selectList = new SelectList(enumList);
			ViewBag.size = selectList;
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> Create(CreateFriesVM friesVM, IFormFile imgCover)
		{
			if (ModelState.IsValid)
			{
				Fries fries = mapper.Map<Fries>(friesVM);
				fries.Photo = GenerateUniqueFileName(imgCover);
				bool isAdded = friesRepository.Add(fries);


				FileStream file = new FileStream("wwwroot/ProductImages/Fries1/" + fries.Photo, FileMode.Create);
				await imgCover.CopyToAsync(file);
				if (isAdded)
				{
					TempData["Info"] = "Fries is added";
					return RedirectToAction("List");
				}
				else
				{
					ViewBag.Info = "Fries cannot added";
				}
			}
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
			return View(friesVM);
		}

		[HttpPost]
		public async Task<IActionResult> Edit(UpdateFriesVM updateFriesVM, IFormFile imgCover)
		{
			if (ModelState.IsValid)
			{
				Fries fries = mapper.Map<Fries>(updateFriesVM);
				fries.Photo = GenerateUniqueFileName(imgCover);
				bool isUpdated = friesRepository.Update(fries);

				FileStream file = new FileStream("wwwroot/ProductImages/Fries1/" + fries.Photo, FileMode.Create);
				await imgCover.CopyToAsync(file);
				if (isUpdated)
				{
					TempData["Info"] = "Fries Updated";
					return RedirectToAction("List");
				}
				else
				{
					ViewBag.Info = "Failed to Update fries";
				}
			}
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
