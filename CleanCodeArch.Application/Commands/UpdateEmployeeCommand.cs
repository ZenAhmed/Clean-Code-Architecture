using CleanCodeArch.Domian.Entities;
using CleanCodeArch.Domian.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCodeArch.Application.Commands
{
    public record UpdateEmployeeCommand(Guid Id, EmployeeEntity entity) : IRequest<EmployeeEntity>;

    public class UpdateEmployeeCommandHandler(IEmployeeRepo employeeRepo) : IRequestHandler<UpdateEmployeeCommand, EmployeeEntity>
    {
        public async Task<EmployeeEntity> Handle(UpdateEmployeeCommand request, CancellationToken cancellationToken)
        {
            return await employeeRepo.UpdateEmployeeAsync(request.Id,request.entity);
        }
    }
}
