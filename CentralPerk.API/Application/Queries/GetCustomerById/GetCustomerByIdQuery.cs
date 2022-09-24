using CentralPerk.API.Dtos;
using CentralPerk.API.Dtos.Customer;
using MediatR;

namespace CentralPerk.API.Application.Queries.GetCustomerById;

public class GetCustomerByIdQuery:IRequest<ResponseDto<CustomerDto>>
{
    public int Id { get; set; }
}