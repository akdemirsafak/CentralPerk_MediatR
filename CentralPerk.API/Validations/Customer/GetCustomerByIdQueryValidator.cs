using CentralPerk.API.Application.Queries.CustomerOperations.GetCustomerById;
using FluentValidation;

namespace CentralPerk.API.Validations.Customer;

public class GetCustomerByIdQueryValidator : AbstractValidator<GetCustomerByIdQuery>
{
    public GetCustomerByIdQueryValidator()
    {
        RuleFor(x => x.Id)
            .NotNull().WithMessage("{PropertyName} is required.")
            .GreaterThan(0).WithMessage("{PropertyName} is must be greater than zero.");
    }
}