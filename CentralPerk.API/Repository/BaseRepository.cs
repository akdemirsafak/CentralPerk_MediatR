using System.Data;

namespace CentralPerk.API.Repository;

public class BaseRepository
{
    protected readonly IDbConnection _dbConnection;
    protected readonly IDbTransaction _dbTransaction;

    public BaseRepository(IDbConnection dbConnection, IDbTransaction dbTransaction)
    {
        _dbConnection = dbConnection;
        _dbTransaction = dbTransaction;
    }
}