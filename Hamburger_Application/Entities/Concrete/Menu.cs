using Hamburger_Application.Entities.Abstract;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hamburger_Application.Entities.Concrete
{
    public class Menu : ProductBaseEntity
    {
        // Relations
        public int? OrderId { get; set; }
        public Order? Order { get; set; }
        public int? DrinkId { get; set; }
        public Drink? Drink { get; set; }
        public int? FriesId { get; set; }
        public Fries? Fries { get; set; }
        public int? HamburgerId { get; set; }
        public Hamburger? Hamburger { get; set; }
    }
}
