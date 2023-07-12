using Microsoft.AspNetCore.Mvc;

namespace Hamburger_Application.Areas.Admin.Controllers
{
	public class SauceController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
