using Microsoft.AspNetCore.Mvc;

namespace Hamburger_Application.Areas.Admin.Controllers
{
	public class FriesController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
