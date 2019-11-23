using Persistance_Layer.Infrastructure.CommonRepositories;
using System;
using System.Data;

namespace Persistance_Layer.Infrastructure.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IWriteOnlyRepository<TEntity> GetWriteRepository<TEntity>() where TEntity : class;

        int SaveChanges();

        void BeginTransaction(IsolationLevel isolationLevel = IsolationLevel.ReadCommitted);

    }
}
