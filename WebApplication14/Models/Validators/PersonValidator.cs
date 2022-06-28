using FluentValidation;

namespace WebApplication14_FluentValidation.Models.Validators
{
    public class PersonValidator : AbstractValidator<Person>
    {
        public PersonValidator()
        {
            RuleFor(x => x.ıd.StartsWith('a')).NotNull().WithMessage("ıd 'a' ile başlamalıdır ve boş olmamalıdır.");
            RuleFor(x => x.Name).MaximumLength(10).WithMessage("isim uzunluğu en fazla 10 karakter olabilir.");
            RuleFor(x => x.Email).EmailAddress().WithMessage("lütfen mail adresinizi kontrol ediniz");
            RuleFor(x=>x.Yas).GreaterThan(18).LessThan(90).WithMessage("yas 18 ve 90 yaş arasında olmalıdır.");
            RuleFor(x => x.Telefon).Matches(@"^(\+\d{1,2}\s)?\(?\d{3}\)?[\s.-]\d{3}[\s.-]\d{4}$").WithMessage("lütfen telefon numaranızı kontrol ediniz.");
            RuleFor(x => x.CreditCard.ToString()).CreditCard().WithMessage("lütfen kredi kartı numaranızı kontrol ediniz.");
        }
    }
}
