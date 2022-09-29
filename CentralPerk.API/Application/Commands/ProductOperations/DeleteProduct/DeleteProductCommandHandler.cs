using CentralPerk.API.Dtos;
using CentralPerk.API.RepositoryCore;

namespace CentralPerk.API.Application.Commands.ProductOperations.DeleteProduct;

public class DeleteProductCommandHandler : ICommandHandler<DeleteProductCommand, ResponseDto<NoContentDto>>
{
    private readonly IProductRepository _productRepository;

    public DeleteProductCommandHandler(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public async Task<ResponseDto<NoContentDto>> Handle(DeleteProductCommand request,
        CancellationToken cancellationToken)
    {
        var response = await _productRepository.Delete(request);
        return ResponseDto<NoContentDto>.Success(204);
    }
}