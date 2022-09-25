using CentralPerk.API.Application.Queries.GetProductById;
using CentralPerk.API.Models;

namespace CentralPerk.API.RepositoryCore;

public interface IProductRepository
{
    Task<List<Product>> GetAll();
    Task<Product> GetById(GetProductByIdQuery query);
}