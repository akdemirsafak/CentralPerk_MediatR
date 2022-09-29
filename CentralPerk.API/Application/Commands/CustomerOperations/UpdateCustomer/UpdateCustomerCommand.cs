using CentralPerk.API.Dtos;

namespace CentralPerk.API.Application.Commands.CustomerOperations.UpdateCustomer;

public class UpdateCustomerCommand : ICommand<ResponseDto<NoContentDto>>
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string PhoneNumber { get; set; }
}