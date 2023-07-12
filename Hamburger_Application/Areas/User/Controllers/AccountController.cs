using Microsoft.AspNetCore.Mvc;

namespace Hamburger_Application.Areas.User.Controllers
{
	[Area("User")]
	public class AccountController : Controller
	{
		public IActionResult SignUp()
		{
			return View();
		}
		public IActionResult LogIn()
		{
			return View();
		}
		public IActionResult LogOut()
		{
			return View();
		}
	}
}
