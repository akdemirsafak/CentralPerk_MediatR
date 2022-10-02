using CentralPerk.API.Application.Queries.ProductOperations.GetProductById;
using FluentValidation;

namespace CentralPerk.API.Validations.Product;

public class GetProductByIdQueryValidator : AbstractValidator<GetProductByIdQuery>
{
    public GetProductByIdQueryValidator()
    {
        RuleFor(x => x.Id)
            .NotNull().WithMessage("{PropertyName} is required.")
            .GreaterThan(0).WithMessage("{PropertyName} is must be greater than zero");
    }
}