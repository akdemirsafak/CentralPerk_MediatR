using CentralPerk.API.Dtos;
using CentralPerk.API.RepositoryCore;
using Microsoft.AspNetCore.Http.HttpResults;

namespace CentralPerk.API.Application.Commands.CustomerOperations.DeleteCustomer;

public class DeleteCustomerCommandHandler : ICommandHandler<DeleteCustomerCommand, ResponseDto<NoContent>>
{
    private readonly ICustomerRepository _customerRepository;

    public DeleteCustomerCommandHandler(ICustomerRepository customerRepository)
    {
        _customerRepository = customerRepository;
    }

    public async Task<ResponseDto<NoContent>> Handle(DeleteCustomerCommand request, CancellationToken cancellationToken)
    {
        var result = await _customerRepository.Delete(request);
        if (result > 0) return ResponseDto<NoContent>.Success(204);
        return ResponseDto<NoContent>.Fail("Kayıt silinemedi.", 500);
    }
}