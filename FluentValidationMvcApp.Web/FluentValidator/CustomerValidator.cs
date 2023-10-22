using FluentValidation;
using FluentValidationMvcApp.Web.Models;

namespace FluentValidationMvcApp.Web.FluentValidator
{
    public class CustomerValidator : AbstractValidator<Customer>
    {

        public CustomerValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("İsim alanı boş geçilemez");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Email alanı boş geçilemez").EmailAddress().WithMessage("Bu alan email tipinde olmalıdır");
            RuleFor(x => x.Age).NotEmpty().WithMessage("Yaş alanı boş geçilemez").InclusiveBetween(18, 60).WithMessage("Yaş alanı 18 - 60 yaş aralığında olmalıdır.");

        }
    }
}
