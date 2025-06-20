using Microsoft.EntityFrameworkCore;
using schoolArch.entity;
using schoolArch.infra.Abstracts;
using schoolArch.infra.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static schoolArch.infra.Context.AppSchoolContext;

namespace schoolArch.infra.Repo
{
    public class StudentRepo : IStudentRepo
    {
        #region props

        private readonly SchoolArchDb? _school;
        #endregion

        #region ctor

        public StudentRepo()
        {
        }

        public StudentRepo(SchoolArchDb school)
        {
            _school = school;
        }
        #endregion

        #region method
        public async Task<List<Student>> GetStudentsAsync()
        {
            return await _school!.Students!.ToListAsync();
        }
        #endregion
    }
}
