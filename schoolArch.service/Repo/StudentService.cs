using schoolArch.entity;
using schoolArch.infra.Abstracts;
using schoolArch.service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace schoolArch.service.Repo
{
    public class StudentService : IStudentService
    {
        #region props

        private readonly IStudentRepo? _studentRepo;
        #endregion
        #region ctor

        public StudentService()
        {
            
        }
        public StudentService(IStudentRepo studentRepo)
        {
            _studentRepo = studentRepo;
        }
        #endregion
        #region method

        public async Task<List<Student>> GetStudentsListAsync()
        {
            return await _studentRepo!.GetStudentsAsync();
        }
        #endregion
    }
}
