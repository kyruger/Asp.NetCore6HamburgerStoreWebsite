using Hamburger_Application.Areas.Admin.Models.ViewModels.Menu;
using Hamburger_Application.Areas.User.Models.OrderVMs;
using Hamburger_Application.Areas.User.Utilities;
using Hamburger_Application.Entities.Concrete;
using Hamburger_Application.Repositories.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Hamburger_Application.Areas.User.Controllers
{
    [Area("User")]
    [Authorize(Roles = "User")]
    public class OrderController : Controller
    {
        private readonly IMenuRepository menuRepository;
        private readonly IRepository<Drink> drinkRepository;
        private readonly IRepository<Fries> friesRepository;
        private readonly IRepository<Hamburger> hamburgerRepository;
        private readonly IRepository<Sauce> sauceRepository;
        private readonly IRepository<Dessert> dessertRepository;
        private readonly UserManager<AppUser> userManager;
        private readonly IOrderRepository orderRepository;

        public OrderController(IMenuRepository menuRepository, IRepository<Drink> drinkRepository, IRepository<Fries> friesRepository, IRepository<Hamburger> hamburgerRepository, IRepository<Sauce> sauceRepository, IRepository<Dessert> dessertRepository, UserManager<AppUser> userManager, IOrderRepository orderRepository)
        {
            this.menuRepository = menuRepository;
            this.drinkRepository = drinkRepository;
            this.friesRepository = friesRepository;
            this.hamburgerRepository = hamburgerRepository;
            this.sauceRepository = sauceRepository;
            this.dessertRepository = dessertRepository;
            this.userManager = userManager;
            this.orderRepository = orderRepository;
        }

        [AllowAnonymous]
        public IActionResult ProductList()
        {
            MenuListVM menuListVM = new MenuListVM();
            menuListVM.Menus = menuRepository.GetAllIncludeFriesIncludeDrinkIncludeHamburger(true);
            List<Menu> menuListTemp = new List<Menu>();
            foreach (var menu in menuListVM.Menus)
            {
                Drink drink = drinkRepository.GetById((int)menu.DrinkId);
                Fries fries = friesRepository.GetById((int)menu.FriesId);
                Hamburger hamburger = hamburgerRepository.GetById((int)menu.HamburgerId);
                menu.Drink = drink;
                menu.Fries = fries;
                menu.Hamburger = hamburger;
                menuListTemp.Add(menu);
            }

            var menuList = menuListVM.Menus;
            var hamburgerList = hamburgerRepository.GetAllTrue(true);
            var friesList = friesRepository.GetAllTrue(true);
            var drinkList = drinkRepository.GetAllTrue(true);
            var sauceList = sauceRepository.GetAllTrue(true);
            var dessertList = dessertRepository.GetAllTrue(true);
            ProductListVM productListVM = new ProductListVM();
            productListVM.Menus = menuList;
            productListVM.Hamburgers = hamburgerList;
            productListVM.Frieses = friesList;
            productListVM.Drinks = drinkList;
            productListVM.Sauces = sauceList;
            productListVM.Desserts = dessertList;
            ViewData["WebSiteTitle"] = "Orders";
            return View(productListVM);
        }

        public async Task<IActionResult> Cart()
        {
            AppUser user = await userManager.FindByNameAsync(User.Identity.Name);

            Order order = orderRepository.GetByUserId(user.Id, false);
            ViewData["WebSiteTitle"] = "Shopping Cart";
            return View(order);
        }

        public async Task<IActionResult> AddToCart(int id, string name)
        {
            AppUser user = await userManager.FindByNameAsync(User.Identity.Name);
            Order order = orderRepository.GetByUserId(user.Id, false);
            if (order == null)
            {
                order = new Order();
                order.UserId = user.Id;
                orderRepository.Add(order);
            }

            if (user != null && name != null)
            {
                if (name == "menu")
                {
                    Menu menu = menuRepository.GetById(id);
                    order.Menus.Add(menu);
                }
                else if (name == "hamburger")
                {
                    Hamburger hamburger = hamburgerRepository.GetById(id);
                    order.Hamburgers.Add(hamburger);
                }
                else if (name == "fries")
                {
                    Fries fries = friesRepository.GetById(id);
                    order.Fries.Add(fries);
                }
                else if (name == "drink")
                {
                    Drink drink = drinkRepository.GetById(id);
                    order.Drinks.Add(drink);
                }
                else if (name == "dessert")
                {
                    Dessert dessert = dessertRepository.GetById(id);
                    order.Desserts.Add(dessert);
                }
                else if (name == "sauce")
                {
                    Sauce sauce = sauceRepository.GetById(id);
                    order.Sauces.Add(sauce);
                }
                else
                {
                    TempData["info"] = "Product couldn't be added to cart";
                    ViewData["WebSiteTitle"] = "Product List";
                    return RedirectToAction("ProductList");
                }
                bool isAdded = orderRepository.Update(order);

            }
            ViewData["WebSiteTitle"] = "Shopping Cart";
            return RedirectToAction("Cart", user);

        }

        public async Task<IActionResult> Delete(string entityName)
        {

            AppUser user = await userManager.FindByNameAsync(User.Identity.Name);
            Order order = orderRepository.GetByUserId(user.Id, false);

            Menu menu = order.Menus.FirstOrDefault(o => o.Name == entityName);
            Hamburger hamburger = order.Hamburgers.FirstOrDefault(o => o.Name == entityName);
            Fries fries = order.Fries.FirstOrDefault(o => o.Name == entityName);
            Sauce sauce = order.Sauces.FirstOrDefault(o => o.Name == entityName);
            Drink drink = order.Drinks.FirstOrDefault(o => o.Name == entityName);
            Dessert dessert = order.Desserts.FirstOrDefault(o => o.Name == entityName);

            if (menu is not null) order.Menus.Remove(menu);
            else if (hamburger is not null) order.Hamburgers.Remove(hamburger);
            else if (sauce is not null) order.Sauces.Remove(sauce);
            else if (fries is not null) order.Fries.Remove(fries);
            else if (drink is not null) order.Drinks.Remove(drink);
            else if (dessert is not null) order.Desserts.Remove(dessert);

            bool IsUpdated = orderRepository.Update(order);

            ViewData["WebSiteTitle"] = "Shopping Cart";
            return RedirectToAction("Cart");
        }

        public async Task<IActionResult> SaveOrder(decimal totalPrice)
        {
            AppUser user = await userManager.FindByNameAsync(User.Identity.Name);
            if (user.Address is not null)
            {
                Order order = orderRepository.GetByUserId(user.Id, false);
                if (order is not null)
                {
                    order.IsAccepted = true;
                    bool isUpdateOrder = orderRepository.Update(order);
                    if (isUpdateOrder)
                    {
                        Helper.EmailSend(user.Email, $"Your Order was confirmed {DateTime.Now} Order Price:{totalPrice / 100} ₺..Your order will arrive at your {user.Address} within 1 hours.\nAfter paying at the door, you can receive your order. ");
                        TempData["Info"] = $"Your Order was confirmed {DateTime.Now}. After paying at the door, you can receive your order.";
                        ViewData["WebSiteTitle"] = "Shopping Cart";
                        return RedirectToAction("Cart");
                    }
                    else
                    {
                        TempData["Info"] = "Something went wrong..Please try again later.. :)";
                        ViewData["WebSiteTitle"] = "Shopping Cart";
                        return RedirectToAction("Cart");
                    }
                }
                else
                {
                    TempData["Info"] = "Order was not found";
                    ViewData["WebSiteTitle"] = "Shopping Cart";
                    return RedirectToAction("Cart");
                }
            }
            else
            {
                TempData["Info"] = "To place order, you must first add an address.";
                ViewData["WebSiteTitle"] = "Shopping Cart";
                return RedirectToAction("Cart");
            }
        }

        public async Task<IActionResult> Decrease(string entityName)
        {
            AppUser user = await userManager.FindByNameAsync(User.Identity.Name);
            Order order = orderRepository.GetByUserId(user.Id, false);

            Menu menu = order.Menus.FirstOrDefault(o => o.Name == entityName);
            Hamburger hamburger = order.Hamburgers.FirstOrDefault(o => o.Name == entityName);
            Fries fries = order.Fries.FirstOrDefault(o => o.Name == entityName);
            Sauce sauce = order.Sauces.FirstOrDefault(o => o.Name == entityName);
            Drink drink = order.Drinks.FirstOrDefault(o => o.Name == entityName);
            Dessert dessert = order.Desserts.FirstOrDefault(o => o.Name == entityName);
            if (menu is not null && menu.Piece > 1)
            {
                order.Menus.Remove(menu);
                menu.Piece--;
                order.Menus.Add(menu);
                bool isUpdated = orderRepository.Update(order);
            }
            else if (hamburger is not null && hamburger.Piece > 1)
            {
                order.Hamburgers.Remove(hamburger);
                hamburger.Piece--;
                order.Hamburgers.Add(hamburger);
                bool isUpdated = orderRepository.Update(order);
            }
            else if (sauce is not null && sauce.Piece > 1)
            {
                order.Sauces.Remove(sauce);
                sauce.Piece--;
                order.Sauces.Add(sauce);
                bool isUpdated = orderRepository.Update(order);
            }
            else if (fries is not null && fries.Piece > 1)
            {
                order.Fries.Remove(fries);
                fries.Piece--;
                order.Fries.Add(fries);
                bool isUpdated = orderRepository.Update(order);
            }
            else if (drink is not null && drink.Piece > 1)
            {
                order.Drinks.Remove(drink);
                drink.Piece--;
                order.Drinks.Add(drink);
                bool isUpdated = orderRepository.Update(order);
            }
            else if (dessert is not null && dessert.Piece > 1)
            {
                order.Desserts.Remove(dessert);
                dessert.Piece--;
                order.Desserts.Add(dessert);
                bool isUpdated = orderRepository.Update(order);
            }
            ViewData["WebSiteTitle"] = "Shopping Cart";
            return RedirectToAction("Cart");
        }

        public async Task<IActionResult> Increase(string entityName)
        {
            AppUser user = await userManager.FindByNameAsync(User.Identity.Name);
            Order order = orderRepository.GetByUserId(user.Id, false);

            Menu menu = order.Menus.FirstOrDefault(o => o.Name == entityName);
            Hamburger hamburger = order.Hamburgers.FirstOrDefault(o => o.Name == entityName);
            Fries fries = order.Fries.FirstOrDefault(o => o.Name == entityName);
            Sauce sauce = order.Sauces.FirstOrDefault(o => o.Name == entityName);
            Drink drink = order.Drinks.FirstOrDefault(o => o.Name == entityName);
            Dessert dessert = order.Desserts.FirstOrDefault(o => o.Name == entityName);
            if (menu is not null && menu.Piece < 5)
            {
                order.Menus.Remove(menu);
                menu.Piece++;
                order.Menus.Add(menu);
                bool isUpdated = orderRepository.Update(order);
            }
            else if (hamburger is not null && hamburger.Piece < 5)
            {
                order.Hamburgers.Remove(hamburger);
                hamburger.Piece++;
                order.Hamburgers.Add(hamburger);
                bool isUpdated = orderRepository.Update(order);
            }
            else if (sauce is not null && sauce.Piece < 5)
            {
                order.Sauces.Remove(sauce);
                sauce.Piece++;
                order.Sauces.Add(sauce);
                bool isUpdated = orderRepository.Update(order);
            }
            else if (fries is not null && fries.Piece < 5)
            {
                order.Fries.Remove(fries);
                fries.Piece++;
                order.Fries.Add(fries);
                bool isUpdated = orderRepository.Update(order);
            }
            else if (drink is not null && drink.Piece < 5)
            {
                order.Drinks.Remove(drink);
                drink.Piece++;
                order.Drinks.Add(drink);
                bool isUpdated = orderRepository.Update(order);
            }
            else if (dessert is not null && dessert.Piece < 5)
            {
                order.Desserts.Remove(dessert);
                dessert.Piece++;
                order.Desserts.Add(dessert);
                bool isUpdated = orderRepository.Update(order);
            }
            ViewData["WebSiteTitle"] = "Shopping Cart";
            return RedirectToAction("Cart");
        }
    }
}
