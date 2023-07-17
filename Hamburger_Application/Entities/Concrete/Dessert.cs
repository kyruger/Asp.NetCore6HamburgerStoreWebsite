using Hamburger_Application.Entities.Abstract;

namespace Hamburger_Application.Entities.Concrete
{
    public class Dessert : ProductBaseEntity
    {
        // Relations
        public int? OrderId { get; set; }
        public Order? Order { get; set; }
    }
}
