using System;
using System.Collections.Generic;

namespace AttendanceSystem.Models
{
    public partial class Teacher
    {
        public Teacher()
        {
            Schedules = new HashSet<Schedule>();
        }

        public int TeacherId { get; set; }
        public string FullName { get; set; } = null!;
        public DateTime? Birthdate { get; set; }
        public string? Gender { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public int? RoleId { get; set; }

        public virtual Role? Role { get; set; }
        public virtual ICollection<Schedule> Schedules { get; set; }
    }
}
