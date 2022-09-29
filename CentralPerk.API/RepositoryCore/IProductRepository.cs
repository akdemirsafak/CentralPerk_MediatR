using CentralPerk.API.Application.Commands.ProductOperations.CreateProduct;
using CentralPerk.API.Application.Commands.ProductOperations.DeleteProduct;
using CentralPerk.API.Application.Commands.ProductOperations.UpdateProduct;
using CentralPerk.API.Application.Queries.ProductOperations.GetProductById;
using CentralPerk.API.Models;

namespace CentralPerk.API.RepositoryCore;

public interface IProductRepository
{
    Task<List<Product>> GetAll();
    Task<Product> GetById(GetProductByIdQuery query);

    Task<int> Create(CreateProductCommand command);
    Task<int> Update(UpdateProductCommand command);
    Task<int> Delete(DeleteProductCommand command);
}