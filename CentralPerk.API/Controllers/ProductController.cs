using CentralPerk.API.Application.Commands.ProductOperations.CreateProduct;
using CentralPerk.API.Application.Commands.ProductOperations.DeleteProduct;
using CentralPerk.API.Application.Commands.ProductOperations.UpdateProduct;
using CentralPerk.API.Application.Queries.ProductOperations.GetProductById;
using CentralPerk.API.Application.Queries.ProductOperations.GetProducts;
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
    public async Task<IActionResult> GetById([FromRoute] int id)
    {
        return CreateActionResult(await _mediatr.Send(new GetProductByIdQuery { Id = id }));
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateProductCommand command)
    {
        return CreateActionResult(await _mediatr.Send(command));
    }

    [HttpPut]
    public async Task<IActionResult> Update(UpdateProductCommand command)
    {
        return CreateActionResult(await _mediatr.Send(command));
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete([FromRoute] int id)
    {
        return CreateActionResult(await _mediatr.Send(new DeleteProductCommand { Id = id }));
    }
}