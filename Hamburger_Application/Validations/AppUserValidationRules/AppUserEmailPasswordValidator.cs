using FluentValidation;
using Hamburger_Application.Areas.User.Models.AppUserVMs;

namespace Hamburger_Application.Validations.AppUserValidationRules
{
    public class AppUserEmailPasswordValidator : AbstractValidator<AppUserEmailPasswordVM>
    {
        public AppUserEmailPasswordValidator()
        {
            RuleFor(x => x.Password).NotEmpty().WithMessage("Please enter your password !");
            RuleFor(x => x.ConfirmPassword).NotEmpty().WithMessage("Please enter your password confirm!");

            RuleFor(x => x.Password).MaximumLength(20).WithMessage("Password is up to 20 characters must be entered !");
            RuleFor(x => x.ConfirmPassword).MaximumLength(20).WithMessage("Password confirm is up to 20 characters must be entered !");

            RuleFor(x => x.ConfirmPassword).Equal(y => y.Password).WithMessage("Password does not match the password confirm  !");
        }
    }
}
