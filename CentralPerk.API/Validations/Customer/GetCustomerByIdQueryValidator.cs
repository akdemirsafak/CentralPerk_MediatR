using CentralPerk.API.Application.Queries.GetCustomerById;
using FluentValidation;

namespace CentralPerk.API.Validations.Customer;

public class GetCustomerByIdQueryValidator : AbstractValidator<GetCustomerByIdQuery>
{
    public GetCustomerByIdQueryValidator()
    {
        RuleFor(x => x.Id)
            .GreaterThan(0).WithMessage("{PropertyName} is must be greater than zero.");
    }
}