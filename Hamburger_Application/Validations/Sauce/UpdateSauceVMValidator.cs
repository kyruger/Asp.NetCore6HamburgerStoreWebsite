using FluentValidation;
using Hamburger_Application.Areas.Admin.Models.ViewModels.Sauce;
using Hamburger_Application.Areas.User.Utilities;

namespace Hamburger_Application.Validations.Sauce
{
	public class UpdateSauceVMValidator : AbstractValidator<UpdateSauceVM>
	{
		public UpdateSauceVMValidator() 
		{
            RuleFor(f => f.Name).NotEmpty().WithMessage("Sauce name must not be empty");
            RuleFor(f => f.Name).MaximumLength(30).WithMessage("Maximum characters must be 30");
            RuleFor(f => f.Price).NotEmpty().WithMessage("Price cannot be a empty");
            RuleFor(f => f.Price).GreaterThan(0).WithMessage("Price cannot be a negative value");
            RuleFor(f => f.Piece).GreaterThan(0).WithMessage("Piece cannot be a negative value");
            RuleFor(f => f.imgCover).Must(PhotoFile.BeValidImageFormat).WithMessage("Invalid photo format. Only JPEG, JPG and PNG formats are allowed.");
        }
    }
}
