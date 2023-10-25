using FluentValidation;
using FluentValidationMvcApp.Web.Models;

namespace FluentValidationMvcApp.Web.FluentValidator
{
    public class AddressValidator : AbstractValidator<Address>
    {
        public string NotEmptyMessage { get; } = "{PropertyName} alanı boş geçilemez";


        public AddressValidator()
        {
            RuleFor(x => x.Content).NotEmpty().WithMessage(NotEmptyMessage);
            RuleFor(x=>x.Province).NotEmpty().WithMessage(NotEmptyMessage);
            RuleFor(x=>x.PostCode).NotEmpty().WithMessage(NotEmptyMessage).MaximumLength(5).WithMessage("{PropertyName} alanı en fazla {MaxLength} karakter olmalıdır");
        }
    }
}
