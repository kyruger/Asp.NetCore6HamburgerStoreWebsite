using AutoMapper;
using Hamburger_Application.Areas.User.Models.AppUserVMs;
using Hamburger_Application.Areas.User.Utilities;
using Hamburger_Application.Entities.Concrete;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MimeKit;

namespace Hamburger_Application.Areas.User.Controllers
{
    [Area("User")]
    [Authorize(Roles = "User, Admin")]
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> userManager;
        private readonly SignInManager<AppUser> signInManager;
        private readonly IMapper mapper;
        Random random;
        int randomCode;

        public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, IMapper mapper)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.mapper = mapper;
            random = new();
        }

        [AllowAnonymous]
        public IActionResult SignUp()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> SignUp(AppUserCreateVM appUserCreateVM)
        {
            if (ModelState.IsValid)
            {

                AppUser appUser = mapper.Map<AppUser>(appUserCreateVM);

                randomCode = random.Next(100_000, 1_000_000);
                appUser.ConfirmCode = randomCode;
                appUser.PasswordHash = userManager.PasswordHasher.HashPassword(appUser, appUserCreateVM.Password);

                IdentityResult result = await userManager.CreateAsync(appUser);

                if (result.Succeeded)
                {
                    Helper.EmailSend(appUser.Email, "Sign Up process confirm code :  ", randomCode);
                    TempData["Email"] = appUser.Email;
                    await userManager.AddToRoleAsync(appUser, "User");
                    return RedirectToAction("EmailConfirm");
                }
                else
                {
                    foreach (IdentityError error in result.Errors)
                    {
                        ModelState.AddModelError("Error", error.Description);
                    }
                }
            }
            else ModelState.AddModelError("Error", "Something was wrong");
            return View(appUserCreateVM);
        }
        [AllowAnonymous]
        public IActionResult EmailConfirm()
        {
            return View();
        }
        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> EmailConfirm(AppUserEmailConfirmVM appUserEmailConfirmVM)
        {
            AppUser appUser = await userManager.FindByEmailAsync(appUserEmailConfirmVM.Email);
            if (appUser is not null)
            {
                if (appUser.ConfirmCode == appUserEmailConfirmVM.ConfirmCode)
                {
                    appUser.EmailConfirmed = true;
                    IdentityResult result = await userManager.UpdateAsync(appUser);
                    if (result.Succeeded)
                    {
                        Helper.EmailSend(appUser.Email, "Welcome to mbf hamburger !");
                        return RedirectToAction("SignIn");
                    }
                    else
                    {
                        ModelState.AddModelError("Error", "Something went wrong !\nA new confirm code was sent.");
                        randomCode = random.Next(100_000, 1_000_000);
                        appUser.ConfirmCode = randomCode;
                        await userManager.UpdateAsync(appUser);
                    }
                }
                else ModelState.AddModelError("Error", "Confirm code is wrong !");
            }

            ModelState.AddModelError("Error", "Something went wrong. Please try again !");

            Helper.EmailSend(appUser.Email, "A new confirm code : ", appUser.ConfirmCode);
            TempData["Email"] = appUser.Email;

            return View(appUserEmailConfirmVM);
        }

        [AllowAnonymous]
        public IActionResult SignIn()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> SignIn(AppUserSignInVM appUserSignInVM)
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
                                return RedirectToAction("Main", "Home", new { area = "" });
                            }
                            else
                            {
                                ModelState.AddModelError("Error", "Your email could not have been confirmed !\nA new confirm code was sent.");
                                Helper.EmailSend(appUser.Email, "A new confirm code");
                                return RedirectToAction("EmailConfirm");
                            }
                        }
                        else ModelState.AddModelError("Error", "Email or password is incorrect !");
                    }
                    ModelState.AddModelError("Error", "Can not be sign in with email is in account was deleted !\nPlease get in touch with sending email");
                }
                else ModelState.AddModelError("Error", $"{appUserSignInVM} email address is not registered in the system !");
            }
            return View(appUserSignInVM);
        }
        
        public async Task<IActionResult> SignOut()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Main", "Home", new { area = "" });
        }
    }
}
