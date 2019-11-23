using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;

namespace Persistance_Layer.Infrastructure.CommonRepositories
{
    public interface IReadOnlyRepository<TEntity> where TEntity : class
    {
        IQueryable<TEntity> GetAll();

        TEntity GetByID(int id);

        IQueryable<TEntity> GetQueryable(Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            string includeProperties = null,
            int? skip = null,
            int? take = null);

        IQueryable<TEntity> GetPagedQueryable(int pageNumber, int rowsPerPage, string conditions, string orderby,
            object parametres = null,
            IDbTransaction transaction = null,
            int? commandTimeout = null);

        IQueryable<TEntity> RunStoredProcedureList<T>(string spName, object param = null);

        IEnumerable<TEntity> GetPredicateList(Expression<Func<TEntity, bool>> predicate = null);

        T RunStoredProcedure<T>(string spName, object param = null);

        TEntity GetPredicateBy(Expression<Func<TEntity, bool>> predicate = null);
    }
}
