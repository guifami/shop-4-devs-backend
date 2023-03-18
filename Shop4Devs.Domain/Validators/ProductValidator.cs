using FluentValidation;
using Shop4Devs.Domain.Entities;

namespace Shop4Devs.Domain.Validators
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(x => x.Id).NotNull().NotEmpty().WithMessage("Invalid ID.");

            RuleFor(x => x.Name).NotNull().NotEmpty().WithMessage("Invalid Name, required field.")
                .MinimumLength(3).WithMessage("Invalid Name, minimum of 3 characters.");

            RuleFor(x => x.Description).NotNull().NotEmpty().WithMessage("Invalid Description, required field.")
                .MinimumLength(20).WithMessage("Invalid Description, minimum of 20 characters.");

            RuleFor(x => x.Description).NotNull().NotEmpty().WithMessage("Invalid Description, required field.")
                .MaximumLength(1000).WithMessage("Invalid Description, maximum of 1000 characters.");

            RuleFor(x => x.Price).LessThan(0).WithMessage("Invalid Price.");

            RuleFor(x => x.Stock).LessThan(0).WithMessage("Invalid Stock.");
        }
    }
}
