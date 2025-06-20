using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace schoolArch.core
{
    public static class ModuleCore
    {
        public static IServiceCollection AddCore(this IServiceCollection services)
        {
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));
            return services;
        }
    }
}
