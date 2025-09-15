using CleanCodeArch.Domian.Entities;
using Microsoft.EntityFrameworkCore;

namespace CleanCodeArch.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }
        public DbSet<EmployeeEntity> Employees_tb { get; set; }
    }
}
