using Microsoft.AspNetCore.Mvc;

namespace Hamburger_Application.Areas.User.Controllers
{
	public class OrderController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
