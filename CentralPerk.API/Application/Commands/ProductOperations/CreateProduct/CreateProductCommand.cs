using CentralPerk.API.Dtos;

namespace CentralPerk.API.Application.Commands.ProductOperations.CreateProduct;

public class CreateProductCommand : ICommand<ResponseDto<int>>
{
    public string Name { get; set; }
    public string? Description { get; set; }
    public decimal Price { get; set; }
}