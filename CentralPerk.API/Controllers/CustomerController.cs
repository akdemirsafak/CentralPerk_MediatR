using CentralPerk.API.Application.Commands.CustomerOperations.CreateCustomer;
using CentralPerk.API.Application.Commands.CustomerOperations.DeleteCustomer;
using CentralPerk.API.Application.Commands.CustomerOperations.UpdateCustomer;
using CentralPerk.API.Application.Queries.CustomerOperations.GetCustomerById;
using CentralPerk.API.Application.Queries.CustomerOperations.GetCustomers;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CentralPerk.API.Controllers;

public class CustomerController : CustomControllerBase
{
    private readonly IMediator _mediatr;

    public CustomerController(IMediator mediatr)
    {
        _mediatr = mediatr;
    }

    [HttpGet]
    public async Task<IActionResult> GetProducts()
    {
        return CreateActionResult(await _mediatr.Send(new GetCustomersQuery()));
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById([FromRoute] int id)
    {
        return CreateActionResult(await _mediatr.Send(new GetCustomerByIdQuery { Id = id }));
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateCustomerCommand command)
    {
        return CreateActionResult(await _mediatr.Send(command));
    }

    [HttpPut]
    public async Task<IActionResult> Update(UpdateCustomerCommand command)
    {
        return CreateActionResult(await _mediatr.Send(command));
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        return CreateActionResult(await _mediatr.Send(new DeleteCustomerCommand { Id = id }));
    }
}