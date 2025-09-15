using CleanCodeArch.Domian.Entities;
using CleanCodeArch.Domian.Interfaces;
using MediatR;

namespace CleanCodeArch.Application.Queries
{
    public record GetAllEmployeeQuery() : IRequest<IEnumerable<EmployeeEntity>>;

    public class GetAllEmployeeQueryHamdler(IEmployeeRepo employeeRepo) : IRequestHandler<GetAllEmployeeQuery, IEnumerable<EmployeeEntity>>
    {
        public async Task<IEnumerable<EmployeeEntity>> Handle(GetAllEmployeeQuery request, CancellationToken cancellationToken)
        {
            return await employeeRepo.GetEmployeesAsync();
        }
    }
}
