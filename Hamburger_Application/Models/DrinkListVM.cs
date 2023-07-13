using Hamburger_Application.Entities.Concrete;

namespace Hamburger_Application.Models
{
    public class DrinkListVM
    {
        public DrinkListVM()
        {
            Drinks = new List<Drink>();
        }
        public List<Drink> Drinks { get; set; }
    }
}
