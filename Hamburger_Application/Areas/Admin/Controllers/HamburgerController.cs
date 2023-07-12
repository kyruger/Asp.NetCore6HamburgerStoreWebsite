using Microsoft.AspNetCore.Mvc;

namespace Hamburger_Application.Areas.Admin.Controllers
{
	public class HamburgerController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
