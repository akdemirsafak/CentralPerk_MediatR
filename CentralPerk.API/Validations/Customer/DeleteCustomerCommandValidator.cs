using CentralPerk.API.Application.Commands.DeleteCustomer;
using FluentValidation;

namespace CentralPerk.API.Validations.Customer;

public class DeleteCustomerCommandValidator : AbstractValidator<DeleteCustomerCommand>
{
    public DeleteCustomerCommandValidator()
    {
        RuleFor(x => x.Id)
            .GreaterThan(0).WithMessage("{PropertyName} is must be greater than zero.");
    }
}