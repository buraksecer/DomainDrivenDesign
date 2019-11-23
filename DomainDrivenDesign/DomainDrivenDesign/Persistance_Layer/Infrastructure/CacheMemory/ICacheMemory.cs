namespace Persistance_Layer.Infrastructure.CacheMemory
{
    public interface ICacheMemory<T> where T : class
    {
        string GetByValue(string T);
        void InsertValue(string value, string key);
        void DeleteValue(string T);
    }
}
