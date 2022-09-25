using CentralPerk.API.Dtos;
using CentralPerk.API.Dtos.Product;
using MediatR;

namespace CentralPerk.API.Application.Queries.GetProductById;

public class GetProductByIdQuery : IRequest<ResponseDto<ProductDto>>
{
    public int Id { get; set; }
}