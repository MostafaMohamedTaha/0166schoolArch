using Microsoft.EntityFrameworkCore;
using schoolArch.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace schoolArch.infra.Context
{
    public class AppSchoolContext
    {
        public class SchoolArchDb(DbContextOptions<SchoolArchDb> options) : DbContext(options)
        {
            public DbSet<Department>? Departments { get; set; } = null!;
            public DbSet<Student>? Students { get; set; }=null!;
            public DbSet<Subject>? Subjects { get; set; } = null!;
            public DbSet<StudentSubject>? StudentSubjects { get; set; } = null!;
            public DbSet<DepartmentSubject>? DepartmentSubjects { get; set; } = null!;
        }
    }
}
