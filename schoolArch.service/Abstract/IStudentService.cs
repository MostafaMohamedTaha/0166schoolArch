using schoolArch.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace schoolArch.service.Abstract
{
    public interface IStudentService
    {
        public Task<List<Student>> GetStudentsListAsync();
    }
}
