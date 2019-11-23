namespace Persistance_Layer.Infrastructure.CommonRepositories
{
    public interface IWriteOnlyRepository<TEntity> where TEntity : class
    {
        void Insert(TEntity entity);

        void UpdateStandart(TEntity entity);

        void Update(TEntity entity);

        void Delete(TEntity entity);

        void HardDelete(TEntity entity);

        //void HardDelete(string table, string column, int columnValue);
    }
}
