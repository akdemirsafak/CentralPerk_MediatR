using System.Data;
using CentralPerk.API.Application.Commands.CreateCustomer;
using CentralPerk.API.Application.Commands.DeleteCustomer;
using CentralPerk.API.Application.Commands.UpdateCustomer;
using CentralPerk.API.Application.Queries.GetCustomerById;
using CentralPerk.API.Models;
using CentralPerk.API.RepositoryCore;
using Dapper;

namespace CentralPerk.API.Repository;

public class CustomerRepository : BaseRepository, ICustomerRepository
{
    public CustomerRepository(IDbConnection dbConnection, IDbTransaction dbTransaction) : base(dbConnection,
        dbTransaction)
    {
    }

    public async Task<List<Customer>> GetAll()
    {
        var query = "select * from customers";
        var result = await _dbConnection.QueryAsync<Customer>(query);
        return result.ToList();
    }

    public async Task<Customer> GetById(GetCustomerByIdQuery query)
    {
        var sql = "select * from customers where id=@Id";
        return await _dbConnection.QuerySingleOrDefaultAsync<Customer>(sql, query);
    }

    public async Task<int> Create(CreateCustomerCommand command) //Doesnt working
    {
        var cmd = "select func_customer_add(@firstname,@lastname,@phonenumber)";
        var id = await _dbConnection.ExecuteScalarAsync<int>(cmd, command, _dbTransaction);
        _dbTransaction.Commit();
        return id;
    }

    public async Task<bool> Update(UpdateCustomerCommand command)
    {
        var cmd = "Select func_customer_update(@id,@firstname,@lastname,@phonenumber)";
        var result = await _dbConnection.ExecuteScalarAsync<int>(cmd, command, _dbTransaction);
        _dbTransaction.Commit();
        return result > 0;
    }

    public async Task<int> Delete(DeleteCustomerCommand command)
    {
        var cmd = "select func_customer_delete(@id)";
        var result = await _dbConnection.ExecuteScalarAsync<int>(cmd, command, _dbTransaction);
        _dbTransaction.Commit();
        return result;
    }
}