using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace schoolArch.entity
{
    public class Student
    {
        #region props

        [Key]
        public int StudentId { get; set; } 
        [StringLength(100)]
        public string StudentName { get; set; } = string.Empty;
        [StringLength(100)]
        public string StudentDescription { get; set; } = string.Empty;
        [StringLength(100)]
        public string StudentAddress { get; set; } = string.Empty;
        [StringLength(100)]
        public string StudentEmail { get; set; } = string.Empty;
        [StringLength(100)]
        public string StudentPhone { get; set; } = string.Empty;
        [ForeignKey("DepartmentId")]
        public int DepartmentId { get; set; }
        public virtual Department? Department { get; set; }
        public virtual ICollection<StudentSubject> StudentSubjects{ get; set; }=new HashSet<StudentSubject>();
        #endregion
    }
}
