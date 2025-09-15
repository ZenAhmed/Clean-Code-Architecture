using CleanCodeArch.Domian.Entities;
using CleanCodeArch.Domian.Interfaces;
using MediatR;

namespace CleanCodeArch.Application.Commands
{
    public record DeleteEmployeeCommand(Guid Id) : IRequest<bool>;

    public class DeleteEmployeeCommandHandler(IEmployeeRepo employeeRepo) : IRequestHandler<DeleteEmployeeCommand, bool>
    {
        public async Task<bool> Handle(DeleteEmployeeCommand request, CancellationToken cancellationToken)
        {
            return await employeeRepo.DeleteEmployeeAsync(request.Id);
        }
    }
}
