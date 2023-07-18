using FluentValidation;
using Hamburger_Application.Areas.Admin.Models.ViewModels.Hamburger;

namespace Hamburger_Application.Validations.Hamburger
{
	public class CreateHamburgerVMValidator : AbstractValidator<CreateHamburgerVM>
	{
		public CreateHamburgerVMValidator()
		{
            RuleFor(f => f.Name).NotEmpty().WithMessage("Hamburger name must not be empty");
            RuleFor(f => f.Name).MaximumLength(30).WithMessage("Maximum characters must be 30");
            RuleFor(f => f.Price).NotEmpty().WithMessage("Price cannot be a empty");
            RuleFor(f => f.Price).GreaterThan(0).WithMessage("Price cannot be a negative value");
            RuleFor(f => f.Piece).GreaterThan(0).WithMessage("Piece cannot be a negative value");
            RuleFor(f => f.imgCover).Must(BeValidImageFormat).WithMessage("Invalid photo format. Only JPEG, JPG and PNG formats are allowed.");
        }
        private bool BeValidImageFormat(IFormFile photo)
        {
            if (photo is null)                 // photo null => true;
                return true;



            var validFormats = new[] { ".jpg", ".jpeg", ".png" };
            var fileExtension = Path.GetExtension(photo.FileName);    //return jpg, jpeg, png



            return validFormats.Contains(fileExtension.ToLower());
        }
    }
}
