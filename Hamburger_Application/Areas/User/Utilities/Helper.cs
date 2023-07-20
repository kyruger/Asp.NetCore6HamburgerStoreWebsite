using Hamburger_Application.Entities.Abstract;
using Hamburger_Application.Entities.Concrete;
using Hamburger_Application.Repositories.Abstract;
using MailKit.Net.Smtp;
using MimeKit;
using NuGet.Packaging;

namespace Hamburger_Application.Areas.User.Utilities
{
    internal static class Helper
    {
        internal static void EmailSend(string email, string info, int? randomCode = null)
        {
            /***********************************************************************Email Address**********************/
            MailboxAddress mailboxAddressFrom = new MailboxAddress("mbf hamburger", "email");
            MailboxAddress mailboxAddressTo = new MailboxAddress("User", email);

            var bodyBuilder = new BodyBuilder();
            bodyBuilder.TextBody = $"{info}  " + randomCode;

            MimeMessage mimeMessage = new();
            mimeMessage.From.Add(mailboxAddressFrom);
            mimeMessage.To.Add(mailboxAddressTo);

            mimeMessage.Body = bodyBuilder.ToMessageBody();
            mimeMessage.Subject = "mbf hamburger";
            SmtpClient client = new();
            /**********Smtp Address**Smptp Türkiye(587)****************************************************************************/
            client.Connect("smtp.office365.com", 587, false);
            /**********Smtp Address**Smptp Türkiye(587)****************************************************************************/
            client.Authenticate("email", "email application verification code");
            client.Send(mimeMessage);
            client.Disconnect(true);
        }
    }
}
