using FluentValidation;
using Hamburger_Application.Areas.User.Models.AppUserVMs;

namespace Hamburger_Application.Validations.AppUserValidationRules
{
    public class AppUserCreateValidator : AbstractValidator<AppUserCreateVM>
    {
        public AppUserCreateValidator()
        {
            RuleFor(x => x.FirstName).NotEmpty().WithMessage("Please enter your name !");
            RuleFor(x => x.LastName).NotEmpty().WithMessage("Please enter your surname !");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Please enter your email !");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Please enter your password !");
            RuleFor(x => x.ConfirmedPassword).NotEmpty().WithMessage("Please enter your password confirm !");

            RuleFor(x => x.FirstName).MinimumLength(3).WithMessage("İsminiz en fazla 30 karakter olmalıdır !");
            RuleFor(x => x.FirstName).MaximumLength(30).WithMessage("Name is up to 30 characters must be entered !");
            RuleFor(x => x.LastName).MaximumLength(30).WithMessage("Surname is up to 30 characters must be entered !");
            RuleFor(x => x.Email).MaximumLength(50).WithMessage("Email address is up to 50 characters must be entered !");
            RuleFor(x => x.Password).MaximumLength(16).WithMessage("Password is up to 16 characters must be entered !");

            RuleFor(x => x.Email).EmailAddress().WithMessage("Email address is invalid !");
            
            RuleFor(x => x.ConfirmedPassword).Matches(y => y.Password).WithMessage("Password does not match the password confirm  !");
        }
    }
}
