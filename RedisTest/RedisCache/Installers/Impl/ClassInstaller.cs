using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RedisCache.BackgroundTask;
using RedisCache.Controllers;
using RedisCache.Installers.Interface;
using RedisCache.Service;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedisCache.Installers.Impl
{
    public class ClassInstaller : IInstaller
    {
        public void InstallServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton<ICacheService, InMemoryCacheService>();
            services.AddSingleton<ICacheService, RedisCacheService>();
            //services.AddSingleton<IConnectionMultiplexer>(x => ConnectionMultiplexer.Connect(configuration.GetValue<string>("RedisConnection")));
            //services.AddHostedService<RedisSubscriber>();
        }
    }
}
