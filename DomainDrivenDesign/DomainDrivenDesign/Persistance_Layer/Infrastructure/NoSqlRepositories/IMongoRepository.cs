using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Persistance_Layer.Infrastructure.NoSqlRepositories
{
    public interface IMongoRepository<T> where T : class
    {
        // add new note document
        Task Add(T item);

        Task Add(T item, string collectionName = "");

        // update just a single document / note
        Task<bool> Update(string id, string body, System.Linq.Expressions.Expression<Func<T, string>> predicate = null);

        Task<bool> Update(string id, string collectionName, BsonDocument field);

        // remove a single document / note
        Task<bool> Remove(string id);

        Task<T> Get(System.Linq.Expressions.Expression<Func<T, bool>> predicate = null);

        Task<T> Get(BsonDocument objectDocument, string collectionName = "");
        Task<List<T>> GetList(BsonDocument objectDocument, string collectionName = "");

        Task<List<T>> GetFilterList(FilterDefinition<T> filterDefinition, string collectionName = "", int skip = 1, int limit = 100, SortDefinition<T> sortBy = null);
        long GetDataCount(FilterDefinition<T> filterDefinition, string collectionName = "");

        Task<List<T>> GetAll();
        Task<List<T>> GetAll(string collectionName = "");

        Task CreateIndex(Dictionary<string, SortDirection> indexs);
    }
}
