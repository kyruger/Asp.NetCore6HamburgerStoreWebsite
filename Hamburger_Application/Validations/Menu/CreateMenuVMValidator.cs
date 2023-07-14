using FluentValidation;
using Hamburger_Application.Areas.Admin.Models.ViewModels.Menu;

namespace Hamburger_Application.Validations.Menu
{
	public class CreateMenuVMValidator:AbstractValidator<CreateMenuVM>
	{
        public CreateMenuVMValidator()
        {
			RuleFor(f => f.Menu.Name).NotEmpty();
			RuleFor(f => f.Menu.Price).NotEmpty().GreaterThan(0).WithMessage("Price cannot be a negative value");
			RuleFor(f => f.Menu.Photo).Must(BeValidImageFormat).WithMessage("Invalid photo format. Only JPEG, JPG and PNG formats are allowed.");
			RuleFor(f=>f.Menu.Piece).NotEmpty().GreaterThan(0).WithMessage("Priece cannot be a negative value");
		}
		private bool BeValidImageFormat(string photo)
		{
			if (string.IsNullOrEmpty(photo))                 // photo null => true;
				return true;

			var validFormats = new[] { ".jpg", ".jpeg", ".png" };
			var fileExtension = Path.GetExtension(photo);    //return jpg, jpeg, png

			return validFormats.Contains(fileExtension, StringComparer.OrdinalIgnoreCase);
		}
	}
}
