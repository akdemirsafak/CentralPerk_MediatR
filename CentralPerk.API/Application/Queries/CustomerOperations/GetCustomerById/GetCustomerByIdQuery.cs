using CentralPerk.API.Dtos;
using CentralPerk.API.Dtos.Customer;

namespace CentralPerk.API.Application.Queries.CustomerOperations.GetCustomerById;

public class GetCustomerByIdQuery : IQuery<ResponseDto<CustomerDto>>
{
    public int Id { get; set; }
}