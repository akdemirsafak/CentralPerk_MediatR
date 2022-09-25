using CentralPerk.API.Dtos;
using MediatR;
using Microsoft.AspNetCore.Http.HttpResults;

namespace CentralPerk.API.Application.Commands.DeleteCustomer;

public class DeleteCustomerCommand : IRequest<ResponseDto<NoContent>>
{
    public int Id { get; set; }
}