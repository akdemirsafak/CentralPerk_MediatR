using CentralPerk.API.Dtos;
using CentralPerk.API.Dtos.Customer;
using MediatR;

namespace CentralPerk.API.Application.Queries.GetCustomers;

public class GetCustomersQuery : IRequest<ResponseDto<List<CustomerDto>>>
{
}