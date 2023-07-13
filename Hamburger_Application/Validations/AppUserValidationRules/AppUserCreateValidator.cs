using FluentValidation;
using Hamburger_Application.Models.AppUserVMs;

namespace Hamburger_Application.Validations.AppUserValidationRules
{
    public class AppUserCreateValidator : AbstractValidator<AppUserCreateVMs>
    {
        public AppUserCreateValidator()
        {
            RuleFor(x => x.FirstName).NotEmpty().WithMessage("This field is required !");
            RuleFor(x => x.LastName).NotEmpty().WithMessage("This field is required !");
            RuleFor(x => x.UserName).NotEmpty().WithMessage("This field is required !");
            RuleFor(x => x.Email).NotEmpty().WithMessage("This field is required !");
            RuleFor(x => x.Password).NotEmpty().WithMessage("This field is required !");
            RuleFor(x => x.ConfirmedPassword).NotEmpty().WithMessage("This field is required !");

            RuleFor(x => x.FirstName).MaximumLength(30).WithMessage("Up to 30 characters can be entered !");
            RuleFor(x => x.LastName).MinimumLength(3).WithMessage("Up to 30 characters can be entered !");
            RuleFor(x => x.Email).EmailAddress().WithMessage("This mail address is not valid !");
            RuleFor(x => x.ConfirmedPassword).Equal(y => y.Password).WithMessage("Password must be equal confirmed password !");
        }
    }
}
