using Microsoft.AspNetCore.Mvc;

namespace Hamburger_Application.Areas.Admin.Controllers
{
	public class DessertController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
