using CentralPerk.API.Dtos;
using CentralPerk.API.Dtos.Product;

namespace CentralPerk.API.Application.Queries.ProductOperations.GetProducts;

public class GetProductsQuery : IQuery<ResponseDto<List<ProductDto>>>
{
}