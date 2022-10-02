using CentralPerk.API.Dtos;

namespace CentralPerk.API.Application.Commands.CustomerOperations.DeleteCustomer;

public class DeleteCustomerCommand : ICommand<ResponseDto<NoContentDto>>
{
    public int Id { get; set; }
}