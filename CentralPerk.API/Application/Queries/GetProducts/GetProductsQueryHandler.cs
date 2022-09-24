using AutoMapper;
using CentralPerk.API.Dtos;
using CentralPerk.API.Dtos.Product;
using CentralPerk.API.RepositoryCore;
using MediatR;

namespace CentralPerk.API.Application.Queries.GetProducts;

public class GetProductsQueryHandler:IRequestHandler<GetProductsQuery,ResponseDto<List<ProductDto>>>
{
    private readonly IProductRepository _productRepository;
    private readonly IMapper _mapper;

    public GetProductsQueryHandler(IProductRepository productRepository, IMapper mapper, IMediator mediator)
    {
        _productRepository = productRepository;
        _mapper = mapper;
    }

    public async Task<ResponseDto<List<ProductDto>>> Handle(GetProductsQuery request, CancellationToken cancellationToken)
    {
        var result=await _productRepository.GetAll();
        var resultDto = _mapper.Map<List<ProductDto>>(result);
        return ResponseDto<List<ProductDto>>.Success(
        resultDto,200);
    }
}