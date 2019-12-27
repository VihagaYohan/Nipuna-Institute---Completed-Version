using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nipuna.Model
{
    public class CourseEnrollment
    {
        // properties
        public int Id { get; set; }
        public string StudentId { get; set; }
        public DateTime RegisteredDate { get; set; }
        public string RegistrationId { get; set; }
        public string StudentName { get; set; }
        public string CourseId { get; set; }
        public string CourseName { get; set; }
        public string LecturerId { get; set; }
        public string LecturerName { get; set; }
        public bool IsRemoved { get; set; }

        public ICollection<Student> Students { get; set; } // list of students
        public ICollection<Course> Courses { get; set; } // list of courses

        public CourseEnrollment()
        {
            Students = new List<Student>();
            Courses = new List<Course>();
            IsRemoved = false;
        }
    }
}
