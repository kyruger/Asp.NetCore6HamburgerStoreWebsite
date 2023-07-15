using Hamburger_Application.Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Hamburger_Application.Areas.User.Controllers
{
    [Area("User")]
    [Authorize(Roles = "User")]
    public class AccountSettingsController : Controller
    {
        private readonly UserManager<AppUser> userManager;

        public AccountSettingsController(UserManager<AppUser> userManager)
        {
            this.userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            //AppUser appUser = await userManager.FindByNameAsync(User.Identity.Name);
            return View();
        }
    }
}
