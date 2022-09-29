using CentralPerk.API.Dtos;
using CentralPerk.API.Dtos.Product;

namespace CentralPerk.API.Application.Queries.ProductOperations.GetProductById;

public class GetProductByIdQuery : IQuery<ResponseDto<ProductDto>>
{
    public int Id { get; set; }
}