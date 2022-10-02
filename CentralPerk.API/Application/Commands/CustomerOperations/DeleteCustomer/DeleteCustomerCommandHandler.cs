using CentralPerk.API.Dtos;
using CentralPerk.API.RepositoryCore;

namespace CentralPerk.API.Application.Commands.CustomerOperations.DeleteCustomer;

public class DeleteCustomerCommandHandler : ICommandHandler<DeleteCustomerCommand, ResponseDto<NoContentDto>>
{
    private readonly ICustomerRepository _customerRepository;

    public DeleteCustomerCommandHandler(ICustomerRepository customerRepository)
    {
        _customerRepository = customerRepository;
    }

    public async Task<ResponseDto<NoContentDto>> Handle(DeleteCustomerCommand request,
        CancellationToken cancellationToken)
    {
        var result = await _customerRepository.Delete(request);
        if (result > 0) return ResponseDto<NoContentDto>.Success(204);
        return ResponseDto<NoContentDto>.Fail("Kayıt silinemedi.", 500);
    }
}