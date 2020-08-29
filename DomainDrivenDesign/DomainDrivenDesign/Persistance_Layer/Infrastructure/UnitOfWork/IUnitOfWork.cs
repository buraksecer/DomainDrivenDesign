using Persistance_Layer.Infrastructure.CommonRepositories;
using System;
using System.Data;

namespace Persistance_Layer.Infrastructure.UnitOfWork
{
    public interface IUnitOfWork 
    {
        IWriteOnlyRepository<TEntity> GetWriteRepository<TEntity>() where TEntity : class, new();
        IReadOnlyRepository<TEntity> GetReadRepository<TEntity>() where TEntity : class, new();

    }
}
