using Hamburger_Application.Entities.Concrete;
using Microsoft.AspNetCore.Identity;

namespace Hamburger_Application.Data.Utilities
{
	public class ForLogin
	{
		public static async void AddASuperUserAsync(UserManager<AppUser> user)
		{
			AppUser tempUser = new AppUser
			{
				UserName = "admin@adminbilgeadamboost.com",
				NormalizedUserName = "ADMIN@ADMINBILGEADAMBOOST.COM",
				Email = "admin@adminbilgeadamboost.com",
				NormalizedEmail = "ADMIN@ADMINBILGEADAMBOOST.COM",
				FirstName = "Admin",
				LastName = "Kadikoy",
				EmailConfirmed = true
			};
			await user.CreateAsync(tempUser, "Admin_12");
			await user.AddToRoleAsync(tempUser, "Admin");
		}
	}
}
