using AutoMapper;
using CentralPerk.API.Dtos;
using CentralPerk.API.Dtos.Customer;
using CentralPerk.API.RepositoryCore;

namespace CentralPerk.API.Application.Queries.CustomerOperations.GetCustomerById;

public class GetCustomerByIdQueryHandler : IQueryHandler<GetCustomerByIdQuery, ResponseDto<CustomerDto>>
{
    private readonly ICustomerRepository _customerRepository;
    private readonly IMapper _mapper;

    public GetCustomerByIdQueryHandler(ICustomerRepository customerRepository, IMapper mapper)
    {
        _customerRepository = customerRepository;
        _mapper = mapper;
    }

    public async Task<ResponseDto<CustomerDto>> Handle(GetCustomerByIdQuery request,
        CancellationToken cancellationToken)
    {
        var customer = await _customerRepository.GetById(request);
        var customerDto = _mapper.Map<CustomerDto>(customer);
        return ResponseDto<CustomerDto>.Success(customerDto, 200);
    }
}