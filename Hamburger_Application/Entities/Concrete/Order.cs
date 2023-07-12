using Hamburger_Application.Entities.Abstract;

namespace Hamburger_Application.Entities.Concrete
{
    public class Order : BaseEntity
    {
        public string UserId { get; set; }
        public AppUser User { get; set; }
        public ICollection<Menu>? Menus { get; set; }
        public ICollection<Hamburger>? Hamburgers { get; set; }
        public ICollection<Drink>? Drinks { get; set; }
        public ICollection<Fries>? Fries { get; set; }
        public ICollection<Dessert>? Desserts { get; set; }
        public ICollection<Sauce>? Sauces { get; set; }

    }
}
