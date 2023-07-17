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
        Random random;
        int randomCode;

        public AccountSettingsController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, IMapper mapper)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.mapper = mapper;
            random = new();
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
                randomCode = random.Next(100_000, 1_000_000);
                Helper.EmailSend(appUser.Email, "Your mbf hamburger account was deleted successfully !");
                return RedirectToAction("Main", "Home", new { area = "" });
            }
            else
            {
                ModelState.AddModelError("", "Email confirm process is unsuccess !");
                return View();
            }
        }

        public async Task<IActionResult> PersonalInfo()
        {
            AppUser appUser = await userManager.FindByNameAsync(User.Identity.Name);
            AppUserPersonalInfoVM appUserPersonalInfoVM = mapper.Map<AppUserPersonalInfoVM>(appUser);
            return View(appUserPersonalInfoVM);
        }

        [HttpPost]
        public async Task<IActionResult> PersonalInfo(AppUserPersonalInfoVM appUserPersonalInfoVM)
        {
            if (ModelState.IsValid)
            {
                AppUser appUser = await userManager.FindByEmailAsync(appUserPersonalInfoVM.Email);
                if (appUser is not null)
                {
                    appUser = mapper.Map<AppUser>(appUserPersonalInfoVM);
                    IdentityResult result = await userManager.UpdateAsync(appUser);
                    if (result.Succeeded)
                    {
                        ModelState.AddModelError("", "Update process is succeed !");
                        Helper.EmailSend(appUser.Email, $"Personal informations was changed !");
                    }
                    else ModelState.AddModelError("Error", $"Update process is unsucceed. Something went wrong !");
                }
                else ModelState.AddModelError("Error", $"{appUserPersonalInfoVM.Email} email address was not found !\nPlease try again later.");
            }
            return View(appUserPersonalInfoVM);
        }

        public async Task<IActionResult> Email()
        {
            AppUser appUser = await userManager.FindByNameAsync(User.Identity.Name);
            AppUserUsernameEmailVM appUserUsernameEmailVM = mapper.Map<AppUserUsernameEmailVM>(appUser);
            return View(appUserUsernameEmailVM);
        }

        [HttpPost]
        public async Task<IActionResult> Email(AppUserUsernameEmailVM appUserUsernameEmailVM)
        {
            if (await userManager.FindByEmailAsync(appUserUsernameEmailVM.Email) is null)
            {
                AppUser appUser = await userManager.FindByNameAsync(appUserUsernameEmailVM.UserName);
                if (appUser is not null)
                {
                    appUser = mapper.Map<AppUser>(appUserUsernameEmailVM);
                    appUser.EmailConfirmed = false;
                    randomCode = random.Next(100_000, 1_000_000);
                    Helper.EmailSend(appUser.Email, $"{appUser.UserName}'s mbf hamburger account change email address confirm code : ", randomCode);
                    IdentityResult result = await userManager.UpdateAsync(appUser);
                    if (result.Succeeded)
                    {
                        ModelState.AddModelError("", "You are redirected to the verification page to finish updating the email address !");
                        Helper.EmailSend(appUser.Email, "Verification page to finish updating the email address :  ", randomCode);
                        TempData["Email"] = appUser.Email;
                        return RedirectToAction("EmailConfirm", "Account", new { area = "User" });
                    }
                    else
                    {
                        ModelState.AddModelError("", "Update process is unsucceed ! Please try again.");
                    }
                }
                else ModelState.AddModelError("Error", $"Something went wrong !\nPlease try again later.");
            }
            ModelState.AddModelError("Error", $"{appUserUsernameEmailVM.Email} can not be used !");
            return View(appUserUsernameEmailVM);
        }

        public async Task<IActionResult> Password()
        {
            AppUser appUser = await userManager.FindByNameAsync(User.Identity.Name);
            AppUserEmailPasswordVM appUserEmailPasswordVM = mapper.Map<AppUserEmailPasswordVM>(appUser);
            return View(appUserEmailPasswordVM);
        }

        [HttpPost]
        public async Task<IActionResult> Password(AppUserEmailPasswordVM appUserEmailPasswordVM)
        {
            AppUser appUser = await userManager.FindByEmailAsync(appUserEmailPasswordVM.Email);
            if (appUser is not null)
            {
                appUser.PasswordHash = userManager.PasswordHasher.HashPassword(appUser, appUserEmailPasswordVM.Password);
                appUser.EmailConfirmed = false;
                randomCode = random.Next(100_000, 1_000_000);
                Helper.EmailSend(appUser.Email, $"{appUser.UserName}'s mbf hamburger account change password confirm code : ", randomCode);
                IdentityResult result = await userManager.UpdateAsync(appUser);
                if (result.Succeeded)
                {
                    ModelState.AddModelError("", "You are redirected to the verification page to finish updating the password !");
                    Helper.EmailSend(appUser.Email, "Verification page to finish updating the email address :  ", randomCode);
                    return RedirectToAction("EmailConfirm", "Account", new { area = "User" });
                }
                else
                {
                    ModelState.AddModelError("", "Update process is unsucceed ! Please try again.");
                }
            }
            else ModelState.AddModelError("Error", $"Something went wrong !\nPlease try again later.");
            return View(appUserEmailPasswordVM);
        }

        public async Task<IActionResult> Address()
        {
            AppUser appUser = await userManager.FindByNameAsync(User.Identity.Name);
            AppUserEmailAddressVM appUserEmailAddressVM = mapper.Map<AppUserEmailAddressVM>(appUser);
            return View(appUserEmailAddressVM);
        }

        [HttpPost]
        public async Task<IActionResult> Address(AppUserEmailAddressVM appUserEmailAddressVM)
        {
            AppUser appUser = await userManager.FindByEmailAsync(appUserEmailAddressVM.Email);
            if (appUser is not null)
            {
                appUser = mapper.Map<AppUser>(appUserEmailAddressVM);
                IdentityResult result = await userManager.UpdateAsync(appUser);
                if (result.Succeeded)
                {
                    ModelState.AddModelError("", "Update process is succeed !");
                    Helper.EmailSend(appUser.Email, $"Address info was changed !");
                }
                else ModelState.AddModelError("Error", $"Update process is unsucceed. Something went wrong !");
            }
            else ModelState.AddModelError("Error", $"{appUserEmailAddressVM.Email} email address was not found !\nPlease try again later.");
            return View(appUserEmailAddressVM);
        }

        public async Task<IActionResult> Theme()
        {
            AppUser appUser = await userManager.FindByNameAsync(User.Identity.Name);
            AppUserThemeVM appUserThemeVM = mapper.Map<AppUserThemeVM>(appUser);
            return View(appUserThemeVM);
        }

        [HttpPost]
        public async Task<IActionResult> Theme(AppUserThemeVM appUserThemeVM)
        {
            AppUser appUser = await userManager.FindByEmailAsync(appUserThemeVM.Email);
            if (appUser is not null)
            {
                appUser = appUserThemeVM.IsDark;
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
                }
            }
            return View(appUserThemeVM);
        }
    }
}
