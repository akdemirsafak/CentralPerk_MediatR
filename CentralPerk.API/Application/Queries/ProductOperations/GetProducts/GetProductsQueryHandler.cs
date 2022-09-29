using AutoMapper;
using CentralPerk.API.Dtos;
using CentralPerk.API.Dtos.Product;
using CentralPerk.API.RepositoryCore;
using MediatR;

namespace CentralPerk.API.Application.Queries.ProductOperations.GetProducts;

public class GetProductsQueryHandler : IQueryHandler<GetProductsQuery, ResponseDto<List<ProductDto>>>
{
    private readonly IMapper _mapper;
    private readonly IProductRepository _productRepository;

    public GetProductsQueryHandler(IProductRepository productRepository, IMapper mapper, IMediator mediator)
    {
        _productRepository = productRepository;
        _mapper = mapper;
    }

    public async Task<ResponseDto<List<ProductDto>>> Handle(GetProductsQuery request,
        CancellationToken cancellationToken)
    {
        var result = await _productRepository.GetAll();
        var resultDto = _mapper.Map<List<ProductDto>>(result);
        return ResponseDto<List<ProductDto>>.Success(
            resultDto, 200);
    }
}