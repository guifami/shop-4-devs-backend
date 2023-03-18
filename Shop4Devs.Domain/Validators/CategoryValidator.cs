using FluentValidation;
using Shop4Devs.Domain.Entities;

namespace Shop4Devs.Domain.Validators
{
    public class CategoryValidator : AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.Id).NotNull().NotEmpty().WithMessage("Invalid ID.");

            RuleFor(x => x.Name).NotNull().NotEmpty().WithMessage("Invalid Name, required field.")
                .MinimumLength(3).WithMessage("Invalid Name, minimum of 3 characters.");
        }
    }
}
