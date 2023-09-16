using System;
using System.Collections.Generic;

namespace AttendanceSystem.Models
{
    public partial class ClassMember
    {
        public int? ClassId { get; set; }
        public int? SubjectId { get; set; }
        public int? StudentId { get; set; }

        public virtual Class? Class { get; set; }
        public virtual Student? Student { get; set; }
        public virtual Subject? Subject { get; set; }
    }
}
