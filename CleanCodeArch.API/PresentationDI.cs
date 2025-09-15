using CleanCodeArch.Application;
using CleanCodeArch.Domain;
using CleanCodeArch.Infrastructure;

namespace CleanCodeArch.API
{
    public static class PresentationDI
    {
        public static IServiceCollection ApiDI (this IServiceCollection services, IConfiguration configuration)
        {
            
            services.AddApplicationDI().AddInfrastructureDI(configuration);
            return services;
        }
    }
}
