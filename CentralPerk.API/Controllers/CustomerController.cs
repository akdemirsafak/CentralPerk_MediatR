using CentralPerk.API.Application.Queries.GetCustomerById;
using CentralPerk.API.Application.Queries.GetCustomers;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CentralPerk.API.Controllers;


public class CustomerController:CustomControllerBase
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
    public async Task<IActionResult> GetById(int id)
    {
        return CreateActionResult(await _mediatr.Send(new GetCustomerByIdQuery{Id = id}));
    }

   
    
}