using Biniverso.Business.Interfaces.Repository;
using Biniverso.Business.Interfaces.Services;
using Biniverso.Business.Services;
using Biniverso.Data;
using Biniverso.Data.Repository;

namespace Biniverso.Presentation.Configurations
{
    public static class DependencyInjectionConfiguration
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<BiniContext>();

            services.AddScoped<IBiniRepository, BiniRepository>();
            services.AddScoped<IBiniService, BiniService>();

            return services;
        }
    }
}
