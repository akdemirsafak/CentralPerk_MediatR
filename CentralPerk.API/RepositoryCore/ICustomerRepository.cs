using CentralPerk.API.Application.Commands.CreateCustomer;
using CentralPerk.API.Application.Commands.DeleteCustomer;
using CentralPerk.API.Application.Commands.UpdateCustomer;
using CentralPerk.API.Application.Queries.GetCustomerById;
using CentralPerk.API.Models;

namespace CentralPerk.API.RepositoryCore;

public interface ICustomerRepository
{
    Task<List<Customer>> GetAll();
    Task<Customer> GetById(GetCustomerByIdQuery query);

    Task<int> Create(CreateCustomerCommand command);
    Task<bool> Update(UpdateCustomerCommand command);
    Task<int> Delete(DeleteCustomerCommand command);
}