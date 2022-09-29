using CentralPerk.API.Application.Commands.CustomerOperations.CreateCustomer;
using CentralPerk.API.Application.Commands.CustomerOperations.DeleteCustomer;
using CentralPerk.API.Application.Commands.CustomerOperations.UpdateCustomer;
using CentralPerk.API.Application.Queries.CustomerOperations.GetCustomerById;
using CentralPerk.API.Models;

namespace CentralPerk.API.RepositoryCore;

public interface ICustomerRepository
{
    Task<List<Customer>> GetAll();
    Task<Customer> GetById(GetCustomerByIdQuery query);

    Task<int> Create(CreateCustomerCommand command);
    Task<int> Update(UpdateCustomerCommand command);
    Task<int> Delete(DeleteCustomerCommand command);
}