using FluentValidation;

namespace WebApplication14_FluentValidation.Models.Validators
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(x => x.Email).NotNull().WithMessage("burayı boş bırakmayınız..");
            RuleFor(x => x.Email).EmailAddress().WithMessage("lütfen mai adresinizi kontrol ediniz..");
            RuleFor(x => x.ProductName).NotNull().WithMessage("lütfen bu alanı boş bırakmayınız..");
            RuleFor(x => x.ProductName).MaximumLength(100).WithMessage("lütfen productname karakterini 100 karakterden fazla girmeyiniz..");
        }
    }
}
