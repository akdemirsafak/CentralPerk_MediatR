using CentralPerk.API.Application.Commands.CustomerOperations.UpdateCustomer;
using FluentValidation;

namespace CentralPerk.API.Validations.Customer;

public class UpdateCustomerCommandValidator : AbstractValidator<UpdateCustomerCommand>
{
    public UpdateCustomerCommandValidator()
    {
        RuleFor(x => x.Id)
            .GreaterThan(0).WithMessage("{PropertyName} is must be greater than zero.");
        RuleFor(x => x.FirstName)
            .NotNull().WithMessage("{PropertyName} is required")
            .NotEmpty().WithMessage("{PropertyName} is cannot empty")
            .Length(3, 64).WithMessage("{PropertyName} must be between 3 and 64 characters.");

        RuleFor(x => x.LastName)
            .NotNull().WithMessage("{PropertyName} is required")
            .NotEmpty().WithMessage("{PropertyName} is cannot empty")
            .Length(3, 64).WithMessage("{PropertyName} must be between 3 and 64 characters.");
        RuleFor(x => x.PhoneNumber)
            .NotNull().WithMessage("{PropertyName} is required")
            .NotEmpty().WithMessage("{PropertyName} is cannot empty")
            .Length(3, 64).WithMessage("{PropertyName} must be between 3 and 64 characters.");
    }
}