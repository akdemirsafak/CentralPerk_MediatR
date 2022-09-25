using CentralPerk.API.Dtos;
using MediatR;

namespace CentralPerk.API.Application.Commands.CreateCustomer;

public class CreateCustomerCommand : IRequest<ResponseDto<int>>
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string PhoneNumber { get; set; }
}