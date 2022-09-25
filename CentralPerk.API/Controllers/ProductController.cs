using CentralPerk.API.Application.Queries.GetProductById;
using CentralPerk.API.Application.Queries.GetProducts;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CentralPerk.API.Controllers;

public class ProductController : CustomControllerBase
{
    private readonly IMediator _mediatr;

    public ProductController(IMediator mediatr)
    {
        _mediatr = mediatr;
    }

    [HttpGet]
    public async Task<IActionResult> GetProducts()
    {
        return CreateActionResult(await _mediatr.Send(new GetProductsQuery()));
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        return CreateActionResult(await _mediatr.Send(new GetProductByIdQuery { Id = id }));
    }
}