using CentralPerk.API.Dtos;
using CentralPerk.API.RepositoryCore;
using MediatR;

namespace CentralPerk.API.Application.Commands.CreateCustomer;

public class CreateCustomerCommandHandler : IRequestHandler<CreateCustomerCommand, ResponseDto<int>>
{
    private readonly ICustomerRepository _customerRepository;

    public CreateCustomerCommandHandler(ICustomerRepository customerRepository)
    {
        _customerRepository = customerRepository;
    }

    public async Task<ResponseDto<int>> Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
    {
        var result = await _customerRepository.Create(request);
        return ResponseDto<int>.Success(result, 201);
    }
}