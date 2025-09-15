using CleanCodeArch.Domian.Entities;
using CleanCodeArch.Domian.Interfaces;
using CleanCodeArch.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace CleanCodeArch.Infrastructure.Repositories
{
    public class EmployeeRepo(AppDbContext context) : IEmployeeRepo
    {
        public async Task<IEnumerable<EmployeeEntity>> GetEmployeesAsync()
        {
            return await context.Employees_tb.ToListAsync();
        }

        public async Task<EmployeeEntity> GetEmployeeByIDAsync(Guid id)
        {
            return await context.Employees_tb.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<EmployeeEntity> AddEmployeeAsync(EmployeeEntity employee)
        {
            employee.Id = Guid.NewGuid();
            await context.Employees_tb.AddAsync(employee);
            await context.SaveChangesAsync();
            return employee;
        }

        public async Task<EmployeeEntity> UpdateEmployeeAsync(Guid id, EmployeeEntity employee)
        {
            var entity = await context.Employees_tb.FirstOrDefaultAsync(x => x.Id == id);
            if (entity is not null)
            {
                entity.Name = employee.Name;
                entity.Email = employee.Email;
                entity.Phone = employee.Phone;

                await context.SaveChangesAsync();
            }
            return entity;
        }

        public async Task<bool> DeleteEmployeeAsync(Guid id)
        {
            var entity = await context.Employees_tb.FindAsync(id);
            if (entity is not null)
            {
                context.Employees_tb.Remove(entity);
                return await context.SaveChangesAsync() > 0;
            }
            return false;
        }
    }
}
