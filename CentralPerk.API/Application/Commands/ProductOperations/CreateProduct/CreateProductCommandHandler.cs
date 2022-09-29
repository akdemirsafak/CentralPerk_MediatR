using CentralPerk.API.Dtos;
using CentralPerk.API.RepositoryCore;

namespace CentralPerk.API.Application.Commands.ProductOperations.CreateProduct;

public class CreateProductCommandHandler : ICommandHandler<CreateProductCommand, ResponseDto<int>>
{
    private readonly IProductRepository _productRepository;

    public CreateProductCommandHandler(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public async Task<ResponseDto<int>> Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {
        var result = await _productRepository.Create(request);
        return ResponseDto<int>.Success(result, 201);
    }
}