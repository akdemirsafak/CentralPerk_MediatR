using CentralPerk.API.Dtos;

namespace CentralPerk.API.Application.Commands.ProductOperations.UpdateProduct;

public class UpdateProductCommand : ICommand<ResponseDto<NoContentDto>>
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
}