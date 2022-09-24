using CentralPerk.API.Models;

namespace CentralPerk.API.RepositoryCore;

public interface IProductRepository
{
    Task<List<Product>> GetAll();
    Task<Product> GetById(int id);
}