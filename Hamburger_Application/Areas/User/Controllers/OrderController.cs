using Hamburger_Application.Areas.Admin.Models.ViewModels.Menu;
using Hamburger_Application.Areas.User.Models.OrderVMs;
using Hamburger_Application.Entities.Concrete;
using Hamburger_Application.Entities.Enum;
using Hamburger_Application.Repositories.Abstract;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using NuGet.Protocol;
using System.Xml.Linq;

namespace Hamburger_Application.Areas.User.Controllers
{
    [Area("User")]
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
            return View(productListVM);
        }
        public async Task<IActionResult> Cart(AppUser user)
        {
            Order order = orderRepository.GetByUserId(user.Id, false);
            var enumList = Enum.GetValues(typeof(Size)).Cast<Size>().ToList();
            SelectList selectList = new SelectList(enumList);
            ViewBag.size = selectList;
            return View(order);
        }
        //public IActionResult Save()
        //{

        //}
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
                    return RedirectToAction("ProductList");
                }
                bool isAdded = orderRepository.Update(order);

            }
            return RedirectToAction("Cart", user);

        }
        public async Task<IActionResult> Delete(int id, string name)
        {

            AppUser user = await userManager.FindByNameAsync(User.Identity.Name);
            Order order = orderRepository.GetByUserId(user.Id, false);
            if (name == "fries")
            {
                Fries fries = friesRepository.GetById(id);
                order.Fries.Remove(fries);
            }
            else if (name == "drink")
            {
                Drink drink = drinkRepository.GetById(id);
                order.Drinks.Remove(drink);
            }
            else if (name == "menu")
            {
                Menu menu = menuRepository.GetById(id);
                order.Menus.Remove(menu);
            }
            else if (name == "hamburger")
            {
                Hamburger hamburger = hamburgerRepository.GetById(id);
                order.Hamburgers.Remove(hamburger);
            }
            else if (name == "dessert")
            {
                Dessert dessert = dessertRepository.GetById(id);
                order.Desserts.Remove(dessert);
            }
            else if (name == "sauce")
            {
                Sauce sauce = sauceRepository.GetById(id);
                order.Sauces.Remove(sauce);
            }
            bool IsUpdated = orderRepository.Update(order);

            return RedirectToAction("Cart", user);
        }
        public async Task<IActionResult> Update(int id, string name, Size size)
        {
            AppUser user = await userManager.FindByNameAsync(User.Identity.Name);
            Order order = orderRepository.GetByUserId(user.Id, false);
            if (name == "fries")
            {
                Fries fries = friesRepository.GetById(id);
                Fries fries1 = order.Fries.FirstOrDefault(x => x.Name == fries.Name);

                List<Fries> frieses = new List<Fries>();
                foreach (Fries item in order.Fries)
                {
                    if (item == fries1)
                    {
                        fries1.Size = size;
                    }

                    frieses.Add(item);
                }
                order.Fries = frieses;
                bool IsUpdated = orderRepository.Update(order);
            }
            return RedirectToAction("Cart", user);

        }



    }
}
