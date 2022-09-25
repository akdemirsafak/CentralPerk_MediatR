using System.Data;

namespace CentralPerk.API.UnitOfWorks;

public class UnitOfWork
{
    private readonly IDbTransaction _dbTransaction;

    public UnitOfWork(IDbTransaction dbTransaction)
    {
        _dbTransaction = dbTransaction;
    }

    public void Commit()
    {
        _dbTransaction.Commit();
    }

    public void Rollback()
    {
        _dbTransaction.Rollback();
    }
}