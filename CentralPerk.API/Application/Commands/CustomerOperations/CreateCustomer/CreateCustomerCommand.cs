using CentralPerk.API.Dtos;

namespace CentralPerk.API.Application.Commands.CustomerOperations.CreateCustomer;

public class CreateCustomerCommand : ICommand<ResponseDto<int>>
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string PhoneNumber { get; set; }
}