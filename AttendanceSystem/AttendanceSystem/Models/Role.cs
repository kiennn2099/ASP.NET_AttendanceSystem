using System;
using System.Collections.Generic;

namespace AttendanceSystem.Models
{
    public partial class Role
    {
        public Role()
        {
            Staff = new HashSet<Staff>();
            Students = new HashSet<Student>();
            Teachers = new HashSet<Teacher>();
        }

        public int RoleId { get; set; }
        public string RoleName { get; set; } = null!;

        public virtual ICollection<Staff> Staff { get; set; }
        public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<Teacher> Teachers { get; set; }
    }
}
