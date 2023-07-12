using Hamburger_Application.Entities.Abstract;

namespace Hamburger_Application.Entities.Concrete
{
    public class Sauce : BaseEntity
    {
        public int? OrderId { get; set; }
        public Order? Order { get; set; }
        public int? MenuId { get; set; }
        public Menu? Menu { get; set; }
    }
}
