using AutoMapper;
using CentralPerk.API.Dtos;
using CentralPerk.API.Dtos.Product;
using CentralPerk.API.RepositoryCore;

namespace CentralPerk.API.Application.Queries.ProductOperations.GetProductById;

public class GetProductByIdQueryHandler : IQueryHandler<GetProductByIdQuery, ResponseDto<ProductDto>>
{
    private readonly IMapper _mapper;
    private readonly IProductRepository _productRepository;

    public GetProductByIdQueryHandler(IProductRepository productRepository, IMapper mapper)
    {
        _productRepository = productRepository;
        _mapper = mapper;
    }

    public async Task<ResponseDto<ProductDto>> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
    {
        var result = await _productRepository.GetById(request);
        var resultDto = _mapper.Map<ProductDto>(result);
        return ResponseDto<ProductDto>.Success(resultDto, 200);
    }
}