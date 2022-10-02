using CentralPerk.API.Application.Commands.ProductOperations.DeleteProduct;
using FluentValidation;

namespace CentralPerk.API.Validations.Product;

public class DeleteProductCommandValidator : AbstractValidator<DeleteProductCommand>
{
    public DeleteProductCommandValidator()
    {
        RuleFor(x => x.Id)
            .GreaterThan(0).WithMessage("{PropertyName} is must be greater than zero.");
    }
}