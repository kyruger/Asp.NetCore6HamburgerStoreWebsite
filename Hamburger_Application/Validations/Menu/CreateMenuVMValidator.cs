using FluentValidation;
using Hamburger_Application.Areas.Admin.Models.ViewModels.Menu;

namespace Hamburger_Application.Validations.Menu
{
	public class CreateMenuVMValidator:AbstractValidator<CreateMenuVM>
	{
        public CreateMenuVMValidator()
        {
            RuleFor(f => f.Menu.Name).NotEmpty().WithMessage("Menu name must not be empty");
            RuleFor(f => f.Menu.Name).MaximumLength(30).WithMessage("Maximum characters must be 30");
            RuleFor(f => f.Menu.Price).NotEmpty().WithMessage("Price cannot be a empty");
            RuleFor(f => f.Menu.Price).GreaterThan(0).WithMessage("Price cannot be a negative value");
            RuleFor(f => f.Menu.Piece).GreaterThan(0).WithMessage("Piece cannot be a negative value");
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
