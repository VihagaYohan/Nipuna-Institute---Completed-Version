using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nipuna.Model
{
    public class Attendance
    {
        // properties
        public int Id { get; set; }
        public string Date { get; set; }
        public string RegistrationId { get; set; }
        public string StudentID { get; set; }
        public string StudentName { get; set; }

        public string CourseId { get; set; }
        public string CourseName { get; set; }

        public string LecturerId { get; set; }
        public string LecturerName { get; set; }
    }
}
