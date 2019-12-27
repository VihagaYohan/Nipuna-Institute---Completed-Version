using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nipuna.Model
{
    public class RegistrationIds
    {
        // properties
        public int Id { get; set; }
        public string StudentId { get; set; }
        public string StudentName { get; set; }
        public string CourseId { get; set; }
        public string CourseName { get; set; }
        public string RegistrationId { get; set; }
        public DateTime IssuedDate { get; set; }
        public string IssuedBy { get; set; }
    }
}
