using System.Data;
using CentralPerk.API.Application.Queries.GetProductById;
using CentralPerk.API.Models;
using CentralPerk.API.RepositoryCore;
using Dapper;

namespace CentralPerk.API.Repository;

public class ProductRepository : BaseRepository, IProductRepository
{
    public ProductRepository(IDbConnection dbConnection, IDbTransaction dbTransaction) : base(dbConnection,
        dbTransaction)
    {
    }

    public async Task<List<Product>> GetAll()
    {
        var query = "Select * from products";
        var products = await _dbConnection.QueryAsync<Product>(query);
        return products.ToList();
    }

    public async Task<Product> GetById(GetProductByIdQuery query)
    {
        var sql = "Select * from products where id = @id";
        return await _dbConnection.QuerySingleAsync<Product>(sql, query);
    }
}