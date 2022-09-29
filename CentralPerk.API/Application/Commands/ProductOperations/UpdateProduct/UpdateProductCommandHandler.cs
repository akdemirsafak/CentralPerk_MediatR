using CentralPerk.API.Dtos;
using CentralPerk.API.RepositoryCore;

namespace CentralPerk.API.Application.Commands.ProductOperations.UpdateProduct;

public class UpdateProductCommandHandler : ICommandHandler<UpdateProductCommand, ResponseDto<NoContentDto>>
{
    private readonly IProductRepository _productRepository;

    public UpdateProductCommandHandler(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public async Task<ResponseDto<NoContentDto>> Handle(UpdateProductCommand request,
        CancellationToken cancellationToken)
    {
        var result = await _productRepository.Update(request);
        return ResponseDto<NoContentDto>.Success(204);
    }
}