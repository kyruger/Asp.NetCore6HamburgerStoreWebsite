using Hamburger_Application.Areas.User.Models.AppUserVMs;
using Hamburger_Application.Entities.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Hamburger_Application.Areas.User.Controllers
{
    [Area("User")]
    public class SignInController : Controller
    {
        private readonly UserManager<AppUser> userManager;

        private readonly SignInManager<AppUser> signInManager;

        public SignInController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(AppUserSignInVM appUserSignInVM)
        {
            if (ModelState.IsValid)
            {
                AppUser appUser = await userManager.FindByEmailAsync(appUserSignInVM.Email);
                if (appUser is not null)
                {
                    if (appUser.IsActive)
                    {
                        Microsoft.AspNetCore.Identity.SignInResult result = await signInManager.PasswordSignInAsync(appUser, appUserSignInVM.Password, false, true);
                        if (result.Succeeded)
                        {
                            if (appUser.EmailConfirmed)
                            {
                                return RedirectToAction("Index", "UserAccounts");
                            }
                            else
                            {
                                ModelState.AddModelError("Error", "Your email could not have been confirmed");
                            }
                        }
                        else ModelState.AddModelError("Error", "Email or password is incorrect !");
                    }
                }
                else ModelState.AddModelError("Error", "Something went wrong !");
            }
            return View();
        }
    }
}
