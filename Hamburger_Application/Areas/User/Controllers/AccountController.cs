using Hamburger_Application.Areas.User.Models.AppUserVMs;
using Hamburger_Application.Entities.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using MailKit.Net.Smtp;
using AutoMapper;

namespace Hamburger_Application.Areas.User.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> userManager;
        private readonly IMapper mapper;
        public AccountController(UserManager<AppUser> userManager, IMapper mapper)
        {
            this.userManager = userManager;
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
                    return RedirectToAction("Index", "EmailConfirm");
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
    }
}
