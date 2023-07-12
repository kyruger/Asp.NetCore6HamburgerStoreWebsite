using Microsoft.AspNetCore.Mvc;

namespace Hamburger_Application.Areas.Admin.Controllers
{
	public class MenuController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
