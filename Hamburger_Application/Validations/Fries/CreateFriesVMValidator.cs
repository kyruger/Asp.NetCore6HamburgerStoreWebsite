using FluentValidation;
using Hamburger_Application.Areas.Admin.Models.ViewModels.Fries;

namespace Hamburger_Application.Validations.Fries
{
	public class CreateFriesVMValidator : AbstractValidator<CreateFriesVM>
	{
		public CreateFriesVMValidator()
		{
            RuleFor(f => f.Name).NotEmpty().MaximumLength(30).WithMessage("Fries name must not be empty & maximum characters must be 30");
            RuleFor(f => f.Price).NotEmpty().GreaterThan(0).WithMessage("Price cannot be a negative value");
			RuleFor(f => f.Photo).Must(BeValidImageFormat).WithMessage("Invalid photo format. Only JPEG, JPG and PNG formats are allowed.");
			RuleFor(f => f.Piece).NotEmpty().GreaterThan(0).WithMessage("Priece cannot be a negative value");
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
