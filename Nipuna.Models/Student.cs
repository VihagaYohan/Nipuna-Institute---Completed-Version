using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nipuna.Model
{
    public class Student
    {
        // properties
        public int Id { get; set; }
        public string RefNo { get; set; }
        public string Name { get; set; }
        public string Nic { get; set; }
        public DateTime Dob { get; set; }
        public string School { get; set; }
        public string Address { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string Type { get; set; }
        public string Pname { get; set; }
        public string Pmobile { get; set; }
        public string Plandline { get; set; }
        public DateTime Registereddate { get; set; }
        public bool IsRemoved { get; set; }

        public ICollection<CourseEnrollment> Enrollments { get; set; }
        public Student()
        {
            Enrollments = new List<CourseEnrollment>();
            IsRemoved = false;
        }
    }
}
