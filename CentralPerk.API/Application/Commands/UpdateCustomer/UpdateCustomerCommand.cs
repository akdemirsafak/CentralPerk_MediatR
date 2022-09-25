using CentralPerk.API.Dtos;
using MediatR;

namespace CentralPerk.API.Application.Commands.UpdateCustomer;

public class UpdateCustomerCommand : IRequest<ResponseDto<NoContentDto>>
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string PhoneNumber { get; set; }
}