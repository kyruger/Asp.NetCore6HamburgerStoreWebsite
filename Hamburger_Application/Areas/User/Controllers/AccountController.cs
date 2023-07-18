using AutoMapper;
using Hamburger_Application.Areas.User.Models.AppUserVMs;
using Hamburger_Application.Areas.User.Utilities;
using Hamburger_Application.Entities.Concrete;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

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
            ViewData["WebSiteTitle"] = "Sign Up";
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> SignUp(AppUserCreateVM appUserCreateVM)
        {
            if (ModelState.IsValid)
            {
                AppUser appUser = await userManager.FindByEmailAsync(appUserCreateVM.Email);
                if (appUser is null)
                {
                    appUser = mapper.Map<AppUser>(appUserCreateVM);

                    randomCode = random.Next(100_000, 1_000_000);
                    appUser.ConfirmCode = randomCode;
                    appUser.PasswordHash = userManager.PasswordHasher.HashPassword(appUser, appUserCreateVM.Password);
                    IdentityResult result = await userManager.CreateAsync(appUser);
                    if (result.Succeeded)
                    {
                        await userManager.AddToRoleAsync(appUser, "User");

                        Helper.EmailSend(appUser.Email, "Sign Up process confirm code :  ", randomCode);
                        TempData["Email"] = appUser.Email;
                        ViewData["WebSiteTitle"] = "Email Confirm";
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
                else
                {
                    if (!appUser.IsActive)
                    {
                        if (appUser.UserName != appUserCreateVM.UserName)
                        {
                            appUser = mapper.Map<AppUser>(appUserCreateVM);

                            randomCode = random.Next(100_000, 1_000_000);
                            appUser.ConfirmCode = randomCode;
                            appUser.PasswordHash = userManager.PasswordHasher.HashPassword(appUser, appUserCreateVM.Password);
                            IdentityResult result = await userManager.CreateAsync(appUser);
                            if (result.Succeeded)
                            {
                                await userManager.AddToRoleAsync(appUser, "User");

                                Helper.EmailSend(appUser.Email, "Sign Up process confirm code :  ", randomCode);
                                TempData["Email"] = appUser.Email;
                                ViewData["WebSiteTitle"] = "Email Confirm";
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
                        else ModelState.AddModelError("Error", "Register must not have been made with this email address or username !");
                    }
                    else ModelState.AddModelError("Error", "Register must not have been made with this email address or username !");
                }
            }
            ViewData["WebSiteTitle"] = "Sign Up";
            return View(appUserCreateVM);
        }

        [AllowAnonymous]
        public IActionResult EmailConfirm()
        {
            ViewData["WebSiteTitle"] = "Email Confirm";
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
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
                        Helper.EmailSend(appUser.Email, $"Welcome to mbf hamburger {appUser.FirstName} {appUser.LastName} !");
                        ViewData["WebSiteTitle"] = "Sign In";
                        await signInManager.SignOutAsync();
                        return RedirectToAction("SignIn");
                    }
                    else
                    {
                        ModelState.AddModelError("Error", "Something went wrong !\nA new confirm code was sent.");
                        randomCode = random.Next(100_000, 1_000_000);
                        appUser.ConfirmCode = randomCode;
                        Helper.EmailSend(appUser.Email, "A new confirm code : ", appUser.ConfirmCode);
                        await userManager.UpdateAsync(appUser);
                        ViewData["WebSiteTitle"] = "Email Confirm";
                        return View(appUserEmailConfirmVM);
                    }
                }
                else ModelState.AddModelError("Error", "Confirm code is wrong !");
                TempData["Email"] = appUser.Email;
                ViewData["WebSiteTitle"] = "Email Confirm";
                return View(appUserEmailConfirmVM);
            }
            ModelState.AddModelError("Error", "Something went wrong. Email address field can not be empty or this email address is wrong !");
            ViewData["WebSiteTitle"] = "Email Confirm";
            return View(appUserEmailConfirmVM);
        }

        [AllowAnonymous]
        public IActionResult SignIn()
        {
            ViewData["WebSiteTitle"] = "Sign In";
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
                                ViewData["WebSiteTitle"] = "Home";
                                return RedirectToAction("Main", "Home", new { area = "" });
                            }
                            else
                            {
                                ModelState.AddModelError("Error", "Your email could not have been confirmed !\nA new confirm code was sent.");
                                randomCode = random.Next(100_000, 1_000_000);
                                appUser.ConfirmCode = randomCode;
                                Helper.EmailSend(appUser.Email, "A new confirm code : ", appUser.ConfirmCode);
                                ViewData["WebSiteTitle"] = "Email Confirm";
                                return RedirectToAction("EmailConfirm");
                            }
                        }
                        else ModelState.AddModelError("Error", "Email or password is incorrect !");
                    }
                    else ModelState.AddModelError("Error", $"{appUserSignInVM.Email} email address is not registered in the system !");
                }
                else ModelState.AddModelError("Error", $"{appUserSignInVM.Email} email address is not registered in the system !");
            }
            ViewData["WebSiteTitle"] = "Sign In";
            return View(appUserSignInVM);
        }

        public async Task<IActionResult> SignOut()
        {
            await signInManager.SignOutAsync();
            ViewData["WebSiteTitle"] = "Home";
            return RedirectToAction("Main", "Home", new { area = "" });
        }
    }
}
