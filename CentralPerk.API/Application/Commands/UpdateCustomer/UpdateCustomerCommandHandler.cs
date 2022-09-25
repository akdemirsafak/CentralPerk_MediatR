using CentralPerk.API.Dtos;
using CentralPerk.API.RepositoryCore;
using MediatR;

namespace CentralPerk.API.Application.Commands.UpdateCustomer;

public class UpdateCustomerCommandHandler : IRequestHandler<UpdateCustomerCommand, ResponseDto<NoContentDto>>
{
    private readonly ICustomerRepository _customerRepository;

    public UpdateCustomerCommandHandler(ICustomerRepository customerRepository)
    {
        _customerRepository = customerRepository;
    }


    public async Task<ResponseDto<NoContentDto>> Handle(UpdateCustomerCommand request,
        CancellationToken cancellationToken)
    {
        var result = await _customerRepository.Update(request);
        if (result) return ResponseDto<NoContentDto>.Success(204);

        return ResponseDto<NoContentDto>.Fail("Güncelleme başarısız", 500);
    }
}