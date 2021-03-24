using RedisCache.Service;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedisCache.Controllers
{
    public class RedisCacheService : ICacheService
    {
        //public readonly IConnectionMultiplexer _connectionMultiplexer;
        public RedisCacheService()//IConnectionMultiplexer connectionMultiplexer
        {
           // _connectionMultiplexer = connectionMultiplexer;
        }

        public Task<string> GetCacheValueAsync(string key)
        {
            throw new NotImplementedException();
        }

        public Task SetCacheValueAsync(string key, string value)
        {
            throw new NotImplementedException();
        }
        //public async Task<string> GetCacheValueAsync(string key)
        //{
        //    var db = _connectionMultiplexer.GetDatabase();
        //    return await db.StringGetAsync(key);
        //}

        //public async Task SetCacheValueAsync(string key, string value)
        //{
        //    var db = _connectionMultiplexer.GetDatabase();
        //    await db.StringSetAsync(key, value);
        //}
    }
}
