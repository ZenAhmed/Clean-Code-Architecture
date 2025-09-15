using CleanCodeArch.Domain.Options;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CleanCodeArch.Domain
{
    public static class DomainDI
    {
        public static IServiceCollection AddDomainDI(this IServiceCollection service)
        {
            return service;
        }
    }
}
