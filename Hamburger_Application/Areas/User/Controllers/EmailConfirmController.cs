using Hamburger_Application.Areas.User.Models.AppUserVMs;
using Hamburger_Application.Entities.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Hamburger_Application.Areas.User.Controllers
{
    [Area("User")]
    public class EmailConfirmController : Controller
    {
        private readonly UserManager<AppUser> userManager;

        public EmailConfirmController(UserManager<AppUser> userManager)
        {
            this.userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(AppUserEmailConfirmVM appUserEmailConfirmVM)
        {
            AppUser appUser = await userManager.FindByEmailAsync(appUserEmailConfirmVM.Email);
            if (appUser is not null)
            {
                appUser.EmailConfirmed = true;
                IdentityResult result = await userManager.UpdateAsync(appUser);
                if (result.Succeeded) 
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    foreach (IdentityError error in result.Errors)
                    {
                        ModelState.AddModelError("Email confirm process is unsuccess !", error.Description);
                    }
                }
            }
            else
            {
                ModelState.AddModelError("Error", "Something went wrong !\nA new confirm code was sent.");
            }
            return View(appUserEmailConfirmVM);
        }
    }
}
