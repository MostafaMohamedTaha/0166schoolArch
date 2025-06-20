using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace schoolArch.entity
{
    public class DepartmentSubject
    {
        #region props

        [Key]
        public int DepartmentSubjectId { get; set; }
        [StringLength(100)]
        public string DepartmentSubjectName { get; set; }=string.Empty;
        [StringLength(100)]
        public string DepartmentSubjectDescription { get; set; } = string.Empty;
        [InverseProperty("Department")]
        [ForeignKey("DepartmentId")]
        public int DepartmentId { get; set; }
        [InverseProperty("Subject")]
        [ForeignKey("SubjectId")]
        public int SubjectId { get; set; }
        public virtual Department? Department { get; set; } 
        public virtual Subject? Subject { get; set; }    
        #endregion

    }
}
