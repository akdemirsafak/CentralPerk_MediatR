using AutoMapper;
using CentralPerk.API.Dtos;
using CentralPerk.API.Dtos.Product;
using CentralPerk.API.RepositoryCore;
using MediatR;

namespace CentralPerk.API.Application.Queries.GetProductById;

public class GetProductByIdQueryHandler:IRequestHandler<GetProductByIdQuery,ResponseDto<ProductDto>>
{
    private readonly IProductRepository _productRepository;
    private readonly IMapper _mapper;

    public GetProductByIdQueryHandler(IProductRepository productRepository, IMapper mapper)
    {
        _productRepository = productRepository;
        _mapper = mapper;
    }

    public async Task<ResponseDto<ProductDto>> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
    {
        var result = await _productRepository.GetById(request.Id);
        var resultDto = _mapper.Map<ProductDto>(result);
        return ResponseDto<ProductDto>.Success(resultDto,200);
    }
}