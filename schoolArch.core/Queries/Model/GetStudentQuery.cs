using MediatR;
using schoolArch.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace schoolArch.core.Queries.Model
{
    public class GetStudentQuery:IRequest<List<Student>>
    {
    }
}
