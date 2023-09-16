using System;
using System.Collections.Generic;

namespace AttendanceSystem.Models
{
    public partial class Subject
    {
        public Subject()
        {
            Schedules = new HashSet<Schedule>();
        }

        public int SubjectId { get; set; }
        public string SubjectName { get; set; } = null!;

        public virtual ICollection<Schedule> Schedules { get; set; }
    }
}
