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
        private readonly SignInManager<AppUser> signInManager;

        public AccountSettingsController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        public async Task<IActionResult> Index()
        {
            //AppUser appUser = await userManager.FindByNameAsync(User.Identity.Name);
            return View();
        }

        public async Task<IActionResult> DeleteAccount()
        {
            return PartialView("_DeleteAccountPartial");
        }

        [HttpPost]
        public async Task<IActionResult> Delete(string id)
        {
            AppUser appUser = await userManager.FindByIdAsync(id);
            appUser.IsActive = false;
            IdentityResult result = await userManager.UpdateAsync(appUser);
            if (result.Succeeded)
            {
                await signInManager.SignOutAsync();
                return RedirectToAction("Main", "Home", new { area = "" });
            }
            else
            {
                foreach (IdentityError error in result.Errors)
                {
                    ModelState.AddModelError("Email confirm process is unsuccess !", error.Description);
                }
                return Json("fail");
            }
        }

        public async Task<IActionResult> PersonalInfo()
        {
            return PartialView();
        }

        public async Task<IActionResult> Email()
        {
            return PartialView();
        }

        public async Task<IActionResult> Password()
        {
            return PartialView();
        }

        public async Task<IActionResult> Address()
        {
            return PartialView();
        }

        public async Task<IActionResult> Theme()
        {
            return PartialView();
        }
    }
}
