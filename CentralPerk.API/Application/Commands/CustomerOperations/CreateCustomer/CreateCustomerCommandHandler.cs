using CentralPerk.API.Dtos;
using CentralPerk.API.RepositoryCore;
using CentralPerk.API.Validations.Customer;
using FluentValidation;

namespace CentralPerk.API.Application.Commands.CustomerOperations.CreateCustomer;

public class CreateCustomerCommandHandler : ICommandHandler<CreateCustomerCommand, ResponseDto<int>>
{
    private readonly ICustomerRepository _customerRepository;

    public CreateCustomerCommandHandler(ICustomerRepository customerRepository)
    {
        _customerRepository = customerRepository;
    }

    public async Task<ResponseDto<int>> Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
    {
        var validator = new CreateCustomerCommandValidator();
        await validator.ValidateAndThrowAsync(request);

        var result = await _customerRepository.Create(request);
        if (result > 0) return ResponseDto<int>.Success(result, 201);
        return ResponseDto<int>.Fail("İşlem başarısız.", 500);
    }
}