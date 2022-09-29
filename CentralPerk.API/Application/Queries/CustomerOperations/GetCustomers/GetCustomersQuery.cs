using CentralPerk.API.Dtos;
using CentralPerk.API.Dtos.Customer;

namespace CentralPerk.API.Application.Queries.CustomerOperations.GetCustomers;

public class GetCustomersQuery : IQuery<ResponseDto<List<CustomerDto>>>
{
}