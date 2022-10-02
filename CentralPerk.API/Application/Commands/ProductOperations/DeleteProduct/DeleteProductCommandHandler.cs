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
        var result = await _productRepository.Delete(request);
        if (result > 0) return ResponseDto<NoContentDto>.Success(204);
        return ResponseDto<NoContentDto>.Fail("Kayıt silinemedi.", 500);
    }
}