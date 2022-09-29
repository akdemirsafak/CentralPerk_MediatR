using CentralPerk.API.Dtos;

namespace CentralPerk.API.Application.Commands.ProductOperations.DeleteProduct;

public class DeleteProductCommand : ICommand<ResponseDto<NoContentDto>>
{
    public int Id { get; set; }
}