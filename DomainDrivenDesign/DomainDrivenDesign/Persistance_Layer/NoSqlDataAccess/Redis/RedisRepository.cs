using Microsoft.Extensions.Configuration;
using Persistance_Layer.Infrastructure.CacheMemory;
using ServiceStack.Redis;

namespace Persistance_Layer.NoSqlDataAccess.Redis
{
    public class RedisRepository<T> : ICacheMemory<T> where T : class
    {
        string redisDbCollection = "";
        string redisDbPassword = "";
        public RedisRepository(IConfiguration configuration)
        {
            redisDbCollection = configuration["RedisConnection:ConnectionStringRedis"];
            redisDbPassword = configuration["RedisConnection:Password"];
        }

        public bool InsertValue(string key, object value)
        {
            bool isSuccess = false;
            using (RedisClient redisClient = new RedisClient(redisDbCollection))
            {
                lock (redisClient)
                {
                    redisClient.Password = redisDbPassword;
                    isSuccess = redisClient.Set(key, value);
                    return isSuccess;
                }
            }
        }

        public T GetByValue<T>(string key) where T : class
        {
            using (RedisClient redisClient = new RedisClient(redisDbCollection))
            {
                lock (redisClient)
                {
                    redisClient.Password = redisDbPassword;
                    return redisClient.Get<T>(key);
                }
            }
        }


        public bool DeleteValue(string key)
        {
            using (RedisClient redisClient = new RedisClient(redisDbCollection))
            {
                redisClient.Password = redisDbPassword;
                return redisClient.Remove(key);
            }
        }
    }
}
