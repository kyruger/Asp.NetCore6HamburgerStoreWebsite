using System.ComponentModel.DataAnnotations.Schema;

namespace Hamburger_Application.Entities.Abstract
{
    public abstract class BaseEntity
    {
        public BaseEntity()
        {
            CreationTime = DateTime.Now;
        }
        public int Id { get; set; }
        public DateTime CreationTime { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
