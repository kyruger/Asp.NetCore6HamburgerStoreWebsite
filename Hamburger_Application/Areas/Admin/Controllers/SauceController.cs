using AutoMapper;
using Hamburger_Application.Areas.Admin.Models.ViewModels.Hamburger;
using Hamburger_Application.Areas.Admin.Models.ViewModels.Sauce;
using Hamburger_Application.Entities.Concrete;
using Hamburger_Application.Repositories.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Hamburger_Application.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class SauceController : Controller
	{
		private readonly IRepository<Sauce> sauceRepository;
		private readonly IMapper mapper;
		public SauceController(IRepository<Sauce> sauceRepository, IMapper mapper)
		{
			this.sauceRepository = sauceRepository;
			this.mapper = mapper;
		}
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
		public async Task<IActionResult> Create(CreateSauceVM sauceVM, IFormFile imageName)
		{
			if (ModelState.IsValid)
			{
				Sauce sauce = mapper.Map<Sauce>(sauceVM);
				bool isAdded = sauceRepository.Add(sauce);

				sauce.Photo = GenerateUniqueFileName(imageName);

				FileStream file = new FileStream("wwwroot/ProductImages/Sauce1/" + sauce.Photo, FileMode.Create);
				await imageName.CopyToAsync(file);
				if (isAdded)
				{
					TempData["Info"] = "The item added";
					return View("List");
				}
				else
				{
					ViewBag.Info = "The item could not be added.";
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
		public async Task<IActionResult> Edit(UpdateSauceVM updateSauceVM, IFormFile ImageName)
		{
			if (ModelState.IsValid)
			{
				Sauce sauce = sauceRepository.GetById(updateSauceVM.Id);
				if (sauce is not null)
				{
					sauce = mapper.Map<Sauce>(updateSauceVM);
					bool isAdded = sauceRepository.Update(sauce);

					sauce.Photo = GenerateUniqueFileName(ImageName);

					FileStream file = new FileStream("wwwroot/ProductImages/Sauce1/" + sauce.Photo, FileMode.Create);
					await ImageName.CopyToAsync(file);
					if (isAdded)
					{
						TempData["Info"] = "The item updated";
						return View("List");
					}
					else
					{
						ViewBag.Info = "The item could not be updated.";
					}
				}
				else
				{
					ViewBag.Info = "The item could not be founded.";
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
					return RedirectToAction("List");
				}
				else
				{
					ViewBag.IsDeleted = "Sauce is not deleted";
				}
			}
			return View(sauce);
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
