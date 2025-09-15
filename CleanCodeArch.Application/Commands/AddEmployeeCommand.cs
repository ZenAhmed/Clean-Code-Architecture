using CleanCodeArch.Domian.Entities;
using CleanCodeArch.Domian.Interfaces;
using MediatR;

namespace CleanCodeArch.Application.Commands
{
    public record AddEmployeeCommand(EmployeeEntity employee) : IRequest<EmployeeEntity>;

    public class AddEmployeeCommandHandler(IEmployeeRepo iemployee) : IRequestHandler<AddEmployeeCommand, EmployeeEntity>
    {
        public async Task<EmployeeEntity> Handle(AddEmployeeCommand request, CancellationToken cancellationToken)
        {
            return await iemployee.AddEmployeeAsync(request.employee);
        }
    }


}
