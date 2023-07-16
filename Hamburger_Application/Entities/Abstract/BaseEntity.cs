using System.ComponentModel.DataAnnotations.Schema;

namespace Hamburger_Application.Entities.Abstract
{
    public class BaseEntity
    {
        public BaseEntity()
        {
            CreationTime = DateTime.Now;
        }
        public int Id { get; set; }
        public string? Name { get; set; }
        public DateTime CreationTime { get; set; }
        public bool isActive { get; set; } = true;
        public decimal? Price { get; set; }
        public int? Piece { get; set; }
        public string? Photo { get; set; }
        [NotMapped]
        public decimal? TotalPrice { get => (Piece * Price); }
    }
}
