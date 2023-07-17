using Hamburger_Application.Entities.Abstract;
using Size = Hamburger_Application.Entities.Enum.Size;

namespace Hamburger_Application.Entities.Concrete
{
    public class Fries : ProductBaseEntity
    {
        public Size Size { get; set; }

        // Relations
        public int? OrderId { get; set; }
        public Order? Order { get; set; }
        public int? MenuId { get; set; }
        public Menu? Menu { get; set; }
    }
}
