using Hamburger_Application.Entities.Abstract;

namespace Hamburger_Application.Entities.Concrete
{
    public class Hamburger : ProductBaseEntity
    {
        // Relations
        public int? OrderId { get; set; }
        public Order? Order { get; set; }
        public int? MenuId { get; set; }
        public Menu? Menu { get; set; }
    }
}
