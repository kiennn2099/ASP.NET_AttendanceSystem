using System;
using System.Collections.Generic;

namespace AttendanceSystem.Models
{
    public partial class Class
    {
        public Class()
        {
            Schedules = new HashSet<Schedule>();
        }

        public int ClassId { get; set; }
        public string ClassName { get; set; } = null!;

        public virtual ICollection<Schedule> Schedules { get; set; }
    }
}
