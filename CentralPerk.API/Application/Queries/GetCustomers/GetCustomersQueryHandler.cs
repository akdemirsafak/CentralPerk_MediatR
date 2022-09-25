using AutoMapper;
using CentralPerk.API.Dtos;
using CentralPerk.API.Dtos.Customer;
using CentralPerk.API.RepositoryCore;
using MediatR;

namespace CentralPerk.API.Application.Queries.GetCustomers;

public class GetCustomersQueryHandler : IRequestHandler<GetCustomersQuery, ResponseDto<List<CustomerDto>>>
{
    private readonly ICustomerRepository _customerRepository;
    private readonly IMapper _mapper;

    public GetCustomersQueryHandler(ICustomerRepository customerRepository, IMapper mapper)
    {
        _customerRepository = customerRepository;
        _mapper = mapper;
    }

    public async Task<ResponseDto<List<CustomerDto>>> Handle(GetCustomersQuery request,
        CancellationToken cancellationToken)
    {
        var customers = await _customerRepository.GetAll();
        var customersDto = _mapper.Map<List<CustomerDto>>(customers);
        return ResponseDto<List<CustomerDto>>.Success(customersDto, 200);
    }
}