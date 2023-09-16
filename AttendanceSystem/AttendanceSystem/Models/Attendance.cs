using System;
using System.Collections.Generic;

namespace AttendanceSystem.Models
{
    public partial class Attendance
    {
        public int AttendanceId { get; set; }
        public int? ScheduleId { get; set; }
        public int? StudentId { get; set; }
        public string? AttendanceStatus { get; set; }

        public virtual Schedule? Schedule { get; set; }
        public virtual Student? Student { get; set; }
    }
}
