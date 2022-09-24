using System.Data;
using CentralPerk.API.Models;
using CentralPerk.API.RepositoryCore;
using Dapper;

namespace CentralPerk.API.Repository;

public class CustomerRepository:BaseRepository,ICustomerRepository
{
    
    public CustomerRepository(IDbConnection dbConnection, IDbTransaction dbTransaction) : base(dbConnection, dbTransaction)
    {
    }

    public async Task<List<Customer>> GetAll()
    {
        var query = "select * from customers";
        var result = await _dbConnection.QueryAsync<Customer>(query);
        return result.ToList();
    }

    public async Task<Customer> GetById(int id)
    {
        var query = "select * from customers where id=@customerId";
        DynamicParameters parameters = new DynamicParameters();
        parameters.Add("customerId", id,DbType.Int32);
        return await _dbConnection.QuerySingleOrDefaultAsync<Customer>(query,parameters);
    }

    
}