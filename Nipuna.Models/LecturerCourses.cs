using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nipuna.Model
{
    public class LecturerCourses
    {
        // properties
        public int Id { get; set; }
        public string LecturerId { get; set; }
        public string LecturerName { get; set; }
        public string CourseId { get; set; }
        public string CourseName { get; set; }
    }
}
