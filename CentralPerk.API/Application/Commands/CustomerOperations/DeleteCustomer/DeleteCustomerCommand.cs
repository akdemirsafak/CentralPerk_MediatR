using CentralPerk.API.Dtos;
using Microsoft.AspNetCore.Http.HttpResults;

namespace CentralPerk.API.Application.Commands.CustomerOperations.DeleteCustomer;

public class DeleteCustomerCommand : ICommand<ResponseDto<NoContent>>
{
    public int Id { get; set; }
}