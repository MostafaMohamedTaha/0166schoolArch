using MediatR;
using schoolArch.core.Queries.Model;
using schoolArch.entity;
using schoolArch.service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace schoolArch.core.Queries.Handler
{
    public class StudentHandler : IRequestHandler<GetStudentQuery, List<Student>>
    {
        private readonly IStudentService? _studentService;
        public StudentHandler()
        {
            
        }

        public StudentHandler(IStudentService studentService)
        {
            _studentService = studentService;
        }
        public async Task<List<Student>> Handle(GetStudentQuery request, CancellationToken cancellationToken)
        {
            return await _studentService!.GetStudentsListAsync();
        }
    }
}
