using FluentValidation;
using Hamburger_Application.Areas.User.Models.AppUserVMs;

namespace Hamburger_Application.Validations.AppUserValidationRules
{
    public class AppUserCreateValidator : AbstractValidator<AppUserCreateVM>
    {
        public AppUserCreateValidator()
        {
            RuleFor(x => x.FirstName).NotEmpty().WithMessage("Lütfen adınızı giriniz !");
            RuleFor(x => x.LastName).NotEmpty().WithMessage("Lütfen soyadınızı giriniz !");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Lütfen email adresinizi giriniz !");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Lütfen şifrenizi giriniz !");
            RuleFor(x => x.ConfirmedPassword).NotEmpty().WithMessage("Lütfen şifrenizi tekrar giriniz !");

            RuleFor(x => x.FirstName).MaximumLength(30).WithMessage("İsminiz en fazla 30 karakter olmalıdır !");
            RuleFor(x => x.LastName).MaximumLength(30).WithMessage("Soyisminiz en fazla 30 karakter olmalıdır !");
            RuleFor(x => x.Email).MaximumLength(50).WithMessage("Email adresiniz en fazla 50 karakter olmalıdır !");
            RuleFor(x => x.Password).MaximumLength(16).WithMessage("Şifreniz en fazla 16 karakter olmalıdır !");

            RuleFor(x => x.Email).EmailAddress().WithMessage("Geçersiz email adresi !");
            
            RuleFor(x => x.ConfirmedPassword).Matches(y => y.Password).WithMessage("Girilen şifreler eşleşmiyor !");
        }
    }
}
