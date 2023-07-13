using Hamburger_Application.Areas.User.Models.AppUserVMs;
using Hamburger_Application.Entities.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using MailKit.Net.Smtp;

namespace Hamburger_Application.Areas.User.Controllers
{
    [Area("User")]
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> userManager;
        public AccountController(UserManager<AppUser> userManager)
        {
            this.userManager = userManager;
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
                int confirmCode = random.Next(100_000, 1_000_000);

                AppUser appUser = new AppUser()
                {
                    FirstName = appUserCreateVM.FirstName,
                    LastName = appUserCreateVM.LastName,
                    Email = appUserCreateVM.Email,
                    ConfirmCode = confirmCode
                };

                appUser.PasswordHash = userManager.PasswordHasher.HashPassword(appUser, appUserCreateVM.Password);

                IdentityResult result = await userManager.CreateAsync(appUser);

                if (result.Succeeded)
                {
                    MailboxAddress mailboxAddressFrom = new MailboxAddress("mbf hamburger", "fatih_trkci96@hotmail.com");
                    MailboxAddress mailboxAddressTo = new MailboxAddress("User", appUser.Email);

                    var bodyBuilder = new BodyBuilder();
                    bodyBuilder.TextBody = "Sign Up process confirm code :  " + confirmCode;

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

                    TempData["Email"] = appUser.Email;
                    return RedirectToAction("Index", "EmailConfirm");
                }
                else
                {
                    foreach (IdentityError error in result.Errors)
                    {
                        ModelState.AddModelError("Error", $"{error.Code}  =>  {error.Description}");
                    }
                }
            }
            return View(appUserCreateVM);
        }

        public async Task<IActionResult> LogIn()
        {
            return View();
        }
        public IActionResult LogOut()
        {
            return View();
        }
    }
}
