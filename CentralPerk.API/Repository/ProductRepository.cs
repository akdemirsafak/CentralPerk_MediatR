using System.Data;
using CentralPerk.API.Application.Commands.ProductOperations.CreateProduct;
using CentralPerk.API.Application.Commands.ProductOperations.DeleteProduct;
using CentralPerk.API.Application.Commands.ProductOperations.UpdateProduct;
using CentralPerk.API.Application.Queries.ProductOperations.GetProductById;
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

    public async Task<int> Create(CreateProductCommand command)
    {
        var cmd = "Select func_product_add(@name,@description,@price)";
        var result = await _dbConnection.ExecuteScalarAsync<int>(cmd, command, _dbTransaction);
        _dbTransaction.Commit();
        return result;
    }

    public async Task<int> Update(UpdateProductCommand command)
    {
        var cmd = "select func_product_update(@id,@name,@description,@price)";
        var result = await _dbConnection.ExecuteScalarAsync<int>(cmd, command, _dbTransaction);
        _dbTransaction.Commit();
        return result;
    }

    public async Task<int> Delete(DeleteProductCommand command)
    {
        var cmd = "delete from products where id = @id";
        var result = await _dbConnection.ExecuteScalarAsync<int>(cmd, command, _dbTransaction);
        _dbTransaction.Commit();
        return result;
    }
}