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
            client.Connect("smtp.office365.com", 587, false);
            client.Authenticate("email", "code");
            client.Send(mimeMessage);
            client.Disconnect(true);
        }

        //internal static bool ProductPieceIncreaseOrDecrease(ICollection<ProductBaseEntity> products, int pieceChangingAmount, IOrderRepository orderRepository, Order order)
        //{
        //    foreach (var entity in products)
        //    {
        //        if (entity is Menu)
        //        {
        //            Menu menu = (Menu)entity;
        //            order.Menus.FirstOrDefault(m => m.Id == menu.Id).me


        //            order.Menus.Remove(menu);
        //            menu.Piece += pieceChangingAmount;
        //            order.Menus.Add(menu);
        //            break;
        //        }
        //        else if (entity is Hamburger)
        //        {
        //            Hamburger hamburger = (Hamburger)entity;
        //            order = orderRepository.GetAllOrdersWithProductsWhere(o => o.Hamburgers == hamburger && o.Id == order.Id).FirstOrDefault();
        //            order.Hamburgers.Remove(hamburger);
        //            hamburger.Piece += pieceChangingAmount;
        //            order.Hamburgers.Add(hamburger);
        //            break;
        //        }
        //        else if (entity is Fries)
        //        {
        //            Fries fries = (Fries)entity;
        //            order = orderRepository.GetAllOrdersWithProductsWhere(o => o.Fries == fries && o.Id == order.Id).FirstOrDefault();
        //            order.Fries.Remove(fries);
        //            fries.Piece += pieceChangingAmount;
        //            order.Fries.Add(fries);
        //            break;
        //        }
        //        else if (entity is Sauce)
        //        {
        //            Sauce sauce = (Sauce)entity;
        //            order = orderRepository.GetAllOrdersWithProductsWhere(o => o.Sauces == sauce && o.Id == order.Id).FirstOrDefault();
        //            order.Sauces.Remove(sauce);
        //            sauce.Piece += pieceChangingAmount;
        //            order.Sauces.Add(sauce);
        //            break;
        //        }
        //        else if (entity is Drink)
        //        {
        //            Drink drink = (Drink)entity;
        //            order = orderRepository.GetAllOrdersWithProductsWhere(o => o.Drinks == drink && o.Id == order.Id).FirstOrDefault();
        //            order.Drinks.Remove(drink);
        //            drink.Piece += pieceChangingAmount;
        //            order.Drinks.Add(drink);
        //            break;
        //        }
        //        else if (entity is Dessert)
        //        {
        //            Dessert dessert = (Dessert)entity;
        //            order = orderRepository.GetAllOrdersWithProductsWhere(o => o.Desserts == dessert && o.Id == order.Id).FirstOrDefault();
        //            order.Desserts.Remove(dessert);
        //            dessert.Piece += pieceChangingAmount;
        //            order.Desserts.Add(dessert);
        //        }
        //        else return false;
        //    }
        //}
    }
}
