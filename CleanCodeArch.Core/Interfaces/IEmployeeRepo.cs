using CleanCodeArch.Domian.Entities;

namespace CleanCodeArch.Domian.Interfaces
{
    public interface IEmployeeRepo
    {
        public Task<IEnumerable<EmployeeEntity>> GetEmployeesAsync();
        public Task<EmployeeEntity> GetEmployeeByIDAsync(Guid id);
        public Task<EmployeeEntity> AddEmployeeAsync(EmployeeEntity employee);
        public Task<EmployeeEntity> UpdateEmployeeAsync(Guid id, EmployeeEntity employee);
        public Task<bool> DeleteEmployeeAsync(Guid id);
    }
}
