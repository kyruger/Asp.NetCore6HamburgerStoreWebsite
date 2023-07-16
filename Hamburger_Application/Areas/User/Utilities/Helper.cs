using MailKit.Net.Smtp;
using MimeKit;

namespace Hamburger_Application.Areas.User.Utilities
{
    internal static class Helper
    {
         internal static void EmailSend(string email, string info)
        {
            Random random = new();
            int randomCode = random.Next(100_000, 1_000_000);
            MailboxAddress mailboxAddressFrom = new MailboxAddress("mbf hamburger", "fatih_trkci96@hotmail.com");
            MailboxAddress mailboxAddressTo = new MailboxAddress("User", email);

            var bodyBuilder = new BodyBuilder();
            bodyBuilder.TextBody = $"{info} :  " + randomCode;

            MimeMessage mimeMessage = new();
            mimeMessage.From.Add(mailboxAddressFrom);
            mimeMessage.To.Add(mailboxAddressTo);

            mimeMessage.Body = bodyBuilder.ToMessageBody();
            mimeMessage.Subject = "mbf hamburger";

            SmtpClient client = new();
            client.Connect("smtp.office365.com", 587, false);
            client.Authenticate("fatih_trkci96@hotmail.com", "dakytkefxqwqevks");
            client.Send(mimeMessage);
            client.Disconnect(true);
        }
    }
}
