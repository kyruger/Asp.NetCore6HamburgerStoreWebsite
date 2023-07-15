using AutoMapper;
using Hamburger_Application.Areas.Admin.Models.ViewModels.Fries;
using Hamburger_Application.Entities.Concrete;
using Hamburger_Application.Repositories.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Hamburger_Application.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class FriesController : Controller
	{
		private readonly IRepository<Fries> friesRepository;
		private readonly IMapper mapper;

		public FriesController(IRepository<Fries> friesRepository, IMapper mapper)
		{
			this.friesRepository = friesRepository;
			this.mapper = mapper;
		}
		public IActionResult List()
		{
			IEnumerable<Fries> fries = friesRepository.GetAllTrue(true);
			return View(fries);
		}
		public IActionResult Create()
		{
			return View();
		}
		[HttpPost]
		public async Task<IActionResult> Create(CreateFriesVM friesVM, IFormFile imageName)
		{
			if (ModelState.IsValid)
			{
				Fries fries = mapper.Map<Fries>(friesVM);
				bool isAdded = friesRepository.Add(fries);

				fries.Photo = GenerateUniqueFileName(imageName);

				FileStream file = new FileStream("wwwroot/ProductImages/Fries1/" + fries.Photo, FileMode.Create);
				await imageName.CopyToAsync(file);
				if (isAdded)
				{
					TempData["Info"] = "Fries is added";
					return View("List");
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
			return View(friesVM);
		}
		[HttpPost]
		public async Task<IActionResult> Edit(UpdateFriesVM updateFriesVM, IFormFile ImageName)
		{
			if (ModelState.IsValid)
			{
				Fries fries = friesRepository.GetById(updateFriesVM.Id);
				if (fries is not null)
				{
					fries = mapper.Map<Fries>(updateFriesVM);
					bool isAdded = friesRepository.Update(fries);

					fries.Photo = GenerateUniqueFileName(ImageName);

					FileStream file = new FileStream("wwwroot/ProductImages/Fries1/" + fries.Photo, FileMode.Create);
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
