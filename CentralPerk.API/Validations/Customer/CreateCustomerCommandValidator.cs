using CentralPerk.API.Application.Commands.CreateCustomer;
using FluentValidation;

namespace CentralPerk.API.Validations.Customer;

public class CreateCustomerCommandValidator : AbstractValidator<CreateCustomerCommand>
{
    public CreateCustomerCommandValidator()
    {
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