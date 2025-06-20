using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using schoolArch.core.Queries.Model;

namespace schoolArch.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IMediator? _mediator;
        public StudentController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> GetStudents()
        {
            var students = await _mediator!.Send(new GetStudentQuery());
            return Ok(students);
        }
    }
}
