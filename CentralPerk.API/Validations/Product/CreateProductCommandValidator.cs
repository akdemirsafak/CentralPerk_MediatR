using CentralPerk.API.Application.Commands.ProductOperations.CreateProduct;
using FluentValidation;

namespace CentralPerk.API.Validations.Product;

public class CreateProductCommandValidator : AbstractValidator<CreateProductCommand>
{
    public CreateProductCommandValidator()
    {
        RuleFor(x => x.Name)
            .NotNull().WithMessage("{PropertyName} is required.")
            .NotEmpty().WithMessage("{PropertyName} cannot be empty.")
            .Length(2, 63).WithMessage("{PropertyName} 's length must be between 3-64 characters.");

        RuleFor(x => x.Price)
            .NotNull().WithMessage("{PropertyName} is required.")
            .GreaterThan(0).WithMessage("{PropertyName} must be greater than 0.");
    }
}