using CleanCodeArch.Domian.Interfaces;
using CleanCodeArch.Infrastructure.Data;
using CleanCodeArch.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CleanCodeArch.Infrastructure
{
    public static class InfrastructureDI
    {
        public static IServiceCollection AddInfrastructureDI(this IServiceCollection service, IConfiguration configuration)
        {
            service.AddDbContext<AppDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
            service.AddScoped<IEmployeeRepo, EmployeeRepo>();
            return service;
        }
    }
}
