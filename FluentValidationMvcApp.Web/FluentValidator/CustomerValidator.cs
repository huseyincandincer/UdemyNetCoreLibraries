using FluentValidation;
using FluentValidationMvcApp.Web.Models;

namespace FluentValidationMvcApp.Web.FluentValidator
{
    public class CustomerValidator : AbstractValidator<Customer>
    {

        public string NotEmptyMessage { get; } = "{PropertyName} alanı boş geçilemez";

        public CustomerValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage(NotEmptyMessage);
            RuleFor(x => x.Email).NotEmpty().WithMessage(NotEmptyMessage).EmailAddress().WithMessage("Bu alan email tipinde olmalıdır");
            RuleFor(x => x.Age).NotEmpty().WithMessage(NotEmptyMessage).InclusiveBetween(18, 60).WithMessage("Yaş alanı 18 - 60 yaş aralığında olmalıdır.");
            RuleFor(x => x.BirthDay).NotEmpty().WithMessage(NotEmptyMessage).Must(x =>
            {
                return DateTime.Now.AddYears(-18) >= x;
            }).WithMessage("Yaşınız 18'den büyük olmalıdır.");
        }
    }
}
