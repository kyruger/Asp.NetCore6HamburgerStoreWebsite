using Hamburger_Application.Entities.Concrete;

namespace Hamburger_Application.Areas.User.Models.AppUserVMs
{
    public class AppUserAccountVM
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string? Address { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public int? ConfirmCode { get; set; }
        public bool IsActive { get; set; }
        public bool IsDark { get; set; } = false;
        public ICollection<Order> Orders { get; set; }
    }
}
