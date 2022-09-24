using CentralPerk.API.Dtos;
using CentralPerk.API.Dtos.Product;
using MediatR;

namespace CentralPerk.API.Application.Queries.GetProducts;

public class GetProductsQuery:IRequest<ResponseDto<List<ProductDto>>>
{
}