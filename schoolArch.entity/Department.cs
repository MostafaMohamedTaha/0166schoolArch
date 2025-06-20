using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace schoolArch.entity
{
    public class Department
    {
        #region props

        [Key]
        public int DepartmentId { get; set; }
        [StringLength(100)] 
        public string DepartmentName { get; set; } = string.Empty;
        public virtual ICollection<Student> Students { get; set; } = new HashSet<Student>();
        public virtual ICollection<DepartmentSubject> DepartmentSubjects { get; set; } = new HashSet<DepartmentSubject>();
        #endregion
    }
}
