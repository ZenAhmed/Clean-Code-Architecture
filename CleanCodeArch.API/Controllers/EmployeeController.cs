using CleanCodeArch.Application.Commands;
using CleanCodeArch.Application.Queries;
using CleanCodeArch.Domian.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CleanCodeArch.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController(ISender sender) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAllEmployeeAsync()
        {
            var result = await sender.Send(new GetAllEmployeeQuery());
            return Ok(result);
        }

        [HttpGet("{employeeID}")]
        public async Task<IActionResult> GetEmployeeById([FromRoute] Guid employeeID)
        {
            var result = await sender.Send(new GetEmployeeByIdQuery(employeeID));
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> AddEmployeeAsync([FromBody] EmployeeEntity entity)
        {
            var result = await sender.Send(new AddEmployeeCommand(entity));
            return Ok(entity);
        }

        [HttpPut("{employeeID}")]
        public async Task<IActionResult> UpdateEmployeeAsync([FromRoute] Guid employeeID, [FromBody] EmployeeEntity entity)
        {
            var result = await sender.Send(new UpdateEmployeeCommand(employeeID ,entity));
            return Ok();
        }

        [HttpDelete("{employeeID}")]
        public async Task<IActionResult> DeleteEmployee([FromRoute] Guid employeeID)
        {
            var result = await sender.Send(new DeleteEmployeeCommand(employeeID));
            return Ok();
        }
    }
}
