using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace schoolArch.entity
{
    public class Subject
    {
        #region props

        [Key]
        public int SubjectId { get; set; }
        [StringLength(50)]
        public string SubjectName { get; set; }
        = string.Empty;
        [StringLength(100)]
        public string SubjectDescription { get; set; } = string.Empty;
        public virtual ICollection<DepartmentSubject> DepartmantSubjects { get; set; }=new HashSet<DepartmentSubject>();
        public virtual ICollection<StudentSubject> StudentSubjects { get; set; }=new HashSet<StudentSubject>();
        #endregion
    }
}
