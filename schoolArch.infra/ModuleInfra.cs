using Microsoft.Extensions.DependencyInjection;
using schoolArch.infra.Abstracts;
using schoolArch.infra.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace schoolArch.infra
{
    public static class ModuleInfra
    {
        public static IServiceCollection AddInfra(this IServiceCollection services) { 
            services.AddTransient<IStudentRepo, StudentRepo>();
            return services;
        }
    }
}
