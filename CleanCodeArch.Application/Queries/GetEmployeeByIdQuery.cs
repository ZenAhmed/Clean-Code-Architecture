using CleanCodeArch.Domian.Entities;
using CleanCodeArch.Domian.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCodeArch.Application.Queries
{
    public record GetEmployeeByIdQuery(Guid id) : IRequest<EmployeeEntity>;

    public class GetEmployeeByIdQueryHandler(IEmployeeRepo employeeRepo) : IRequestHandler<GetEmployeeByIdQuery, EmployeeEntity>
    {
        public async Task<EmployeeEntity> Handle(GetEmployeeByIdQuery request, CancellationToken cancellationToken)
        {
            return await employeeRepo.GetEmployeeByIDAsync(request.id);
        }
    }
}
