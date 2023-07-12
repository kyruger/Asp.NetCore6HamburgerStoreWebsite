using Microsoft.AspNetCore.Identity;

namespace Hamburger_Application.Entities.Concrete
{
    public class AppRole : IdentityRole<int>
    {
        public AppRole()
        {
            CreationTime = DateTime.Now;
        }
        public DateTime CreationTime { get; set; }
    }
}
