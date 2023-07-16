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
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> userManager;
        private readonly SignInManager<AppUser> signInManager;
        private readonly IMapper mapper;

        public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, IMapper mapper)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.mapper = mapper;
        }

        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SignUp(AppUserCreateVM appUserCreateVM)
        {
            if (ModelState.IsValid)
            {
                Random random = new();
                int randomCode = random.Next(100_000, 1_000_000);

                AppUser appUser = new();
                appUser = mapper.Map<AppUser>(appUserCreateVM);

                appUser.ConfirmCode = randomCode;
                appUser.PasswordHash = userManager.PasswordHasher.HashPassword(appUser, appUserCreateVM.Password);

                IdentityResult result = await userManager.CreateAsync(appUser);

                if (result.Succeeded)
                {
                    EmailSend(appUser.Email, randomCode);
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

        [NonAction]
        private void EmailSend(string email, int randomCode)
        {
            MailboxAddress mailboxAddressFrom = new MailboxAddress("mbf hamburger", "fatih_trkci96@hotmail.com");
            MailboxAddress mailboxAddressTo = new MailboxAddress("User", email);

            var bodyBuilder = new BodyBuilder();
            bodyBuilder.TextBody = "Sign Up process confirm code :  " + randomCode;

            MimeMessage mimeMessage = new();
            mimeMessage.From.Add(mailboxAddressFrom);
            mimeMessage.To.Add(mailboxAddressTo);

            mimeMessage.Body = bodyBuilder.ToMessageBody();
            mimeMessage.Subject = "mbf Hamburger";

            SmtpClient client = new();
            client.Connect("smtp.office365.com", 587, false);
            client.Authenticate("fatih_trkci96@hotmail.com", "dakytkefxqwqevks");
            client.Send(mimeMessage);
            client.Disconnect(true);
        }

        public IActionResult EmailConfirm()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> EmailConfirm(AppUserEmailConfirmVM appUserEmailConfirmVM)
        {
            AppUser appUser = await userManager.FindByEmailAsync(appUserEmailConfirmVM.Email);
            if (appUser is not null)
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
                    foreach (IdentityError error in result.Errors)
                    {
                        ModelState.AddModelError("Email confirm process is unsuccess !", error.Description);
                    }
                }
            }
            else
            {
                ModelState.AddModelError("Error", "Something went wrong !\nA new confirm code was sent.");
                Helper.EmailSend(appUser.Email, "A new confirm code");
            }
            return View(appUserEmailConfirmVM);
        }

        public IActionResult SignIn()
        {
            return View();
        }

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
                else ModelState.AddModelError("Error", "Something went wrong !");
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
