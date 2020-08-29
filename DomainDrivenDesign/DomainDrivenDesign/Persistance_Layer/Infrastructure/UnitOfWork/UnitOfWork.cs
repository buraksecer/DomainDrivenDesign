using Persistance_Layer.Infrastructure.CommonRepositories;
using System;
using System.Data;

namespace Persistance_Layer.Infrastructure.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        public IReadOnlyRepository<TEntity> GetReadRepository<TEntity>() where TEntity : class, new()
        {
            throw new NotImplementedException();
        }

        public IWriteOnlyRepository<TEntity> GetWriteRepository<TEntity>() where TEntity : class, new()
        {
            throw new NotImplementedException();
        }
    }
}
