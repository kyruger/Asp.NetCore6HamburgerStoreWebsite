using Microsoft.AspNetCore.Mvc;

namespace Hamburger_Application.Areas.Admin.Controllers
{
	public class DrinkController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
