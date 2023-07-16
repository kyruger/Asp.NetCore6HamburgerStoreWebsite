using AutoMapper;
using Hamburger_Application.Areas.User.Models.AppUserVMs;
using Hamburger_Application.Areas.User.Utilities;
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
        private readonly IMapper mapper;

        public AccountSettingsController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, IMapper mapper)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            return View();
        }

        public async Task<IActionResult> DeleteAccount()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> DeleteAccount(string id)
        {
            AppUser appUser = await userManager.FindByIdAsync(id);
            appUser.IsActive = false;
            IdentityResult result = await userManager.UpdateAsync(appUser);
            if (result.Succeeded)
            {
                await signInManager.SignOutAsync();
                Helper.EmailSend(appUser.Email, "Your mbf hamburger account was deleted successfully !");
                return RedirectToAction("Main", "Home", new { area = "" });
            }
            else
            {
                foreach (IdentityError error in result.Errors)
                {
                    ModelState.AddModelError("Email confirm process is unsuccess !", error.Description);
                }
                return View();
            }
        }

        public async Task<IActionResult> PersonalInfo()
        {
            AppUser appUser = await userManager.FindByNameAsync(User.Identity.Name);
            AppUserAccountVM appUserAccountVM = mapper.Map<AppUserAccountVM>(appUser);
            return View(appUserAccountVM);
        }

        [HttpPost]
        public async Task<IActionResult> PersonalInfo(AppUserAccountVM appUserAccountVM)
        {
            if (ModelState.IsValid)
            {
                if (await userManager.FindByNameAsync(appUserAccountVM.UserName) is null)
                {
                    AppUser appUser = await userManager.FindByEmailAsync(appUserAccountVM.Email);
                    appUser.FirstName = appUserAccountVM.FirstName;
                    appUserAccountVM.LastName = appUserAccountVM.LastName;
                    appUserAccountVM.UserName = appUserAccountVM.UserName;

                    IdentityResult result = await userManager.UpdateAsync(appUser);
                    if (result.Succeeded)
                    {
                        ModelState.AddModelError("", "Update process is succeed");
                    }
                    else
                    {
                        foreach (var error in result.Errors)
                        {
                            ModelState.AddModelError("Error", $"{error.Description}");
                        }
                    }
                }
                ModelState.AddModelError("Error", $"{appUserAccountVM.UserName} can not be used !");
            }
            return View(appUserAccountVM);
        }

        public async Task<IActionResult> Email()
        {
            AppUser appUser = await userManager.FindByNameAsync(User.Identity.Name);
            AppUserAccountVM appUserAccountVM = new();
            appUserAccountVM.Email = appUser.Email;
            appUserAccountVM.UserName = appUser.UserName;
            return View(appUserAccountVM);
        }

        [HttpPost]
        public async Task<IActionResult> Email(AppUserAccountVM appUserAccountVM)
        {
            if (await userManager.FindByEmailAsync(appUserAccountVM.Email) is null)
            {
                AppUser appUser = await userManager.FindByNameAsync(appUserAccountVM.UserName);
                appUser.Email = appUserAccountVM.Email;
                Helper.EmailSend(appUser.Email, $"{appUser.UserName}'s mbf hamburger account change email address confirm code");
                IdentityResult result = await userManager.UpdateAsync(appUser);
                if (result.Succeeded)
                {
                    ModelState.AddModelError("", "Update process is succeed");
                    return RedirectToAction("Main", "Home", new { area = "" });
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("Error", $"{error.Description}");
                    }
                    return View(appUserAccountVM);
                }
            }
            ModelState.AddModelError("Error", $"{appUserAccountVM.UserName} can not be used !");
            return View(appUserAccountVM);
        }

        public async Task<IActionResult> Password()
        {
            AppUser appUser = await userManager.FindByNameAsync(User.Identity.Name);
            AppUserAccountVM appUserAccountVM = mapper.Map<AppUserAccountVM>(appUser);
            return View(appUserAccountVM);
        }

        [HttpPost]
        public async Task<IActionResult> Password(AppUserAccountVM appUserAccountVM)
        {
            AppUser appUser = await userManager.FindByNameAsync(appUserAccountVM.UserName);
            appUser.PasswordHash = userManager.PasswordHasher.HashPassword(appUser, appUserAccountVM.Password);
            Helper.EmailSend(appUser.Email, $"{appUser.UserName}'s mbf hamburger account change password confirm code");
            IdentityResult result = await userManager.UpdateAsync(appUser);
            if (result.Succeeded)
            {
                ModelState.AddModelError("", "Password changing process is succeeded !");
                Helper.EmailSend(appUser.Email, $"{appUser.UserName}'s account password was changed !");
                return RedirectToAction("Main", "Home", new { area = "" });
            }
            else
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("Error", $"{error.Description}");
                }
                Helper.EmailSend(appUser.Email, $"{appUser.UserName}'s account password changing process is unsucceeded !\nA new confirm code");
                return View(appUserAccountVM);
            }

            ModelState.AddModelError("Error", $"{appUserAccountVM.UserName} can not be used !");
            return View(appUserAccountVM);
        }

        public async Task<IActionResult> Address()
        {
            AppUser appUser = await userManager.FindByNameAsync(User.Identity.Name);
            AppUserAccountVM appUserAccountVM = mapper.Map<AppUserAccountVM>(appUser);
            return View(appUserAccountVM);
        }

        [HttpPost]
        public async Task<IActionResult> Address(AppUserAccountVM appUserAccountVM)
        {
            return View();
        }

        public async Task<IActionResult> Theme()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Theme(string id, bool IsDark)
        {
            AppUser appUser = await userManager.FindByIdAsync(id);
            appUser.IsDark = IsDark;
            IdentityResult result = await userManager.UpdateAsync(appUser);
            if (result.Succeeded)
            {
                return RedirectToAction("Main", "Home", new { area = "" });
            }
            else
            {
                foreach (IdentityError error in result.Errors)
                {
                    ModelState.AddModelError("Error", error.Description);
                }
                return View();
            }
        }
    }
}
