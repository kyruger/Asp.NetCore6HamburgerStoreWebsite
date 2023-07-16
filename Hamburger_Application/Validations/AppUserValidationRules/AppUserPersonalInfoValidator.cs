using FluentValidation;
using Hamburger_Application.Areas.User.Models.AppUserVMs;

namespace Hamburger_Application.Validations.AppUserValidationRules
{
    public class AppUserPersonalInfoValidator : AbstractValidator<AppUserPersonalInfoVM>
    {
        public AppUserPersonalInfoValidator()
        {
            RuleFor(x => x.FirstName).NotEmpty().WithMessage("Please enter your name !");
            RuleFor(x => x.LastName).NotEmpty().WithMessage("Please enter your surname !");
            RuleFor(x => x.UserName).NotEmpty().WithMessage("Please enter your username !");

            RuleFor(x => x.FirstName).MaximumLength(30).WithMessage("Name is up to 30 characters must be entered !");
            RuleFor(x => x.LastName).MaximumLength(30).WithMessage("Surname is up to 30 characters must be entered !");
            RuleFor(x => x.UserName).MaximumLength(20).WithMessage("Username is up to 20 characters must be entered !");
        }
    }
}
