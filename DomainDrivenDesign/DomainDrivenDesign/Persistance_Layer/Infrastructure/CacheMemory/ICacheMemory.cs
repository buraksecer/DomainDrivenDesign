namespace Persistance_Layer.Infrastructure.CacheMemory
{
    public interface ICacheMemory<T> where T : class
    {
        bool InsertValue(string key, object value);
        T GetByValue<T>(string key) where T : class;
        bool DeleteValue(string key);
    }
}
