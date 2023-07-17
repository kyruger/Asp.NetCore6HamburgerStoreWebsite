using Hamburger_Application.Entities.Abstract;

namespace Hamburger_Application.Entities.Concrete
{
    public class Order : BaseEntity
    {
        public Order()
        {
            Menus = new List<Menu>();
            Hamburgers = new List<Hamburger>();
            Drinks = new List<Drink>();
            Fries = new List<Fries>();
            Desserts = new List<Dessert>();
            Sauces = new List<Sauce>();
        }
        public bool IsAccepted { get; set; }

        // Relations
        public int UserId { get; set; }
        public AppUser User { get; set; }
        public ICollection<Menu>? Menus { get; set; }
        public ICollection<Hamburger>? Hamburgers { get; set; }
        public ICollection<Drink>? Drinks { get; set; }
        public ICollection<Fries>? Fries { get; set; }
        public ICollection<Dessert>? Desserts { get; set; }
        public ICollection<Sauce>? Sauces { get; set; }

    }
}
