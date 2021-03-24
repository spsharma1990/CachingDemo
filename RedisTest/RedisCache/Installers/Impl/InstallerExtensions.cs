using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RedisCache.Installers.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedisCache.Installers.Impl
{
    public static class InstallerExtensions
    {
        public static void InstallServicesInAssembly(this IServiceCollection services,  IConfiguration configuration)
        {
            var Installers = typeof(Startup).Assembly.ExportedTypes.Where(x => typeof(IInstaller).IsAssignableFrom(x) && !x.IsInterface && !x.IsAbstract)
                  .Select(Activator.CreateInstance)
                  .Cast<IInstaller>().ToList();
            Installers.ForEach(k => k.InstallServices(services, configuration));
        }
    }
}
