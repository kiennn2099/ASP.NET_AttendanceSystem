using System;
using System.Collections.Generic;

namespace AttendanceSystem.Models
{
    public partial class Schedule
    {
        public Schedule()
        {
            Attendances = new HashSet<Attendance>();
        }

        public int ScheduleId { get; set; }
        public DateTime? DateTime { get; set; }
        public int? Slot { get; set; }
        public int? TeacherId { get; set; }
        public int? SubjectId { get; set; }
        public int? ClassId { get; set; }

        public virtual Class? Class { get; set; }
        public virtual Subject? Subject { get; set; }
        public virtual Teacher? Teacher { get; set; }
        public virtual ICollection<Attendance> Attendances { get; set; }
    }
}
