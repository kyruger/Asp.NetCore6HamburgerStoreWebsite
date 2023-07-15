using Microsoft.AspNetCore.Mvc;

namespace Hamburger_Application.Areas.User.Controllers
{
    public class AccountLayoutController : Controller
    {
        public async Task<IActionResult> Index()
        {
            return View();
        }
    }
}
