using Microsoft.AspNetCore.Identity;

namespace Hamburger_Application.Entities.Concrete
{
	public class AppUser : IdentityUser<int>
	{
		public AppUser() 
		{
			CreationTime = DateTime.Now;
		}
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Address { get; set; }
		public DateTime CreationTime { get; set; }
		public ICollection<Order> Orders { get; set; }
	}
}
