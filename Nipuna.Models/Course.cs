using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nipuna.Model
{
    public class Course
    {
        // properties
        public int Id { get; set; }
        public string RefNo { get; set; }
        public string Title { get; set; }
        public decimal Fee { get; set; }
        public bool IsRemoved { get; set; }

        public ICollection<CourseEnrollment> Enrollments { get; set; }
        //public ICollection<Lecturer> Lecturers { get; set; }
        public Course()
        {
            Enrollments = new List<CourseEnrollment>(); // list implementation
            IsRemoved = false;
        }
    }
}
