using CleanCodeArch.Application.Commands;
using Microsoft.Extensions.DependencyInjection;

namespace CleanCodeArch.Application
{
    public static class ApplicationDI
    {
        public static IServiceCollection AddApplicationDI(this IServiceCollection service)
        {
            service.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(ApplicationDI).Assembly));
            return service;
        }
    }
}
