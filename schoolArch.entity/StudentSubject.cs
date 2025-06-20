using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace schoolArch.entity
{
    public class StudentSubject
    {
        #region props

        [Key]
        public int StudentSubjectId { get; set; }
        [StringLength(50)]
        public string StudentSubjectName { get; set; } = string.Empty;
        [StringLength(100)]
        public string StudentSubjectDescription { get; set;} = string.Empty;
        [InverseProperty("Student")]
        [ForeignKey("StudentId")]
        public int StudentId { get;set;}
        [InverseProperty("Subject")]
        [ForeignKey("SubjectId")]
        public int SubjectId { get; set; }
        public virtual Student? Student { get; set; }
        public virtual Subject? Subject { get; set; }
        #endregion


    }
}
