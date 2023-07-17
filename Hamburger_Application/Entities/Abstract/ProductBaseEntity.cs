using System.ComponentModel.DataAnnotations.Schema;

namespace Hamburger_Application.Entities.Abstract
{
    public class ProductBaseEntity : BaseEntity
    {
        public string Name { get; set; }
        public decimal? Price { get; set; }
        public int? Piece { get; set; }
        public string? Photo { get; set; }
        [NotMapped]
        public decimal? TotalPrice { get => (Piece * Price); }
    }
}
