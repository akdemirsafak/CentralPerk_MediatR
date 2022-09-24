using CentralPerk.API.Models;

namespace CentralPerk.API.RepositoryCore;

public interface ICustomerRepository
{
    Task<List<Customer>> GetAll();
    Task<Customer> GetById(int id);
}