using Microsoft.Extensions.DependencyInjection;
using schoolArch.service.Abstract;
using schoolArch.service.Repo;

namespace schoolArch.service
{
    public static class ModuleService
    {
        public static IServiceCollection AddService(this IServiceCollection services)
        {
            services.AddTransient<IStudentService, StudentService>();
            return services;
        }
    }
}
