using schoolArch.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace schoolArch.infra.Abstracts
{
    public interface IStudentRepo
    {
        public Task<List<Student>> GetStudentsAsync();
    }
}
