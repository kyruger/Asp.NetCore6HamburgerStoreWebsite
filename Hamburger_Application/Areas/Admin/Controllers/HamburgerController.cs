using AutoMapper;
using Hamburger_Application.Areas.Admin.Models.ViewModels.Hamburger;
using Hamburger_Application.Entities.Concrete;
using Hamburger_Application.Repositories.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Hamburger_Application.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class HamburgerController : Controller
	{
		private readonly IRepository<Hamburger> hamburgerRepository;
		private readonly IMapper mapper;

		public HamburgerController(IRepository<Hamburger> hamburgerRepository, IMapper mapper)
		{
			this.hamburgerRepository = hamburgerRepository;
			this.mapper = mapper;
		}
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
		public async Task<IActionResult> Create(CreateHamburgerVM hamburgerVM, IFormFile imageName)
		{
			if (ModelState.IsValid)
			{
				Hamburger hamburger = mapper.Map<Hamburger>(hamburgerVM);
				bool isAdded = hamburgerRepository.Add(hamburger);

				hamburger.Photo = GenerateUniqueFileName(imageName);

				FileStream file = new FileStream("wwwroot/ProductImages/Hamburger/" + hamburger.Photo, FileMode.Create);
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
		public async Task<IActionResult> Edit(UpdateHamburgerVM updateHamburgerVM, IFormFile ImageName)
		{
			if (ModelState.IsValid)
			{
				Hamburger hamburger = hamburgerRepository.GetById(updateHamburgerVM.Id);
				if (hamburger is not null)
				{
					hamburger = mapper.Map<Hamburger>(updateHamburgerVM);
					bool isAdded = hamburgerRepository.Update(hamburger);

					hamburger.Photo = GenerateUniqueFileName(ImageName);

					FileStream file = new FileStream("wwwroot/ProductImages/Hamburger/" + hamburger.Photo, FileMode.Create);
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
					return RedirectToAction("List");
				}
				else
				{
					ViewBag.IsDeleted = "Hamburger is not deleted";
				}
			}
			return View(hamburger);
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
