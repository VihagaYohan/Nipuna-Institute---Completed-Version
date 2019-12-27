using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nipuna.Model
{
    public class Lecturer
    {
        // properties
        public int Id { get; set; }
        public string LecturerId { get; set; }
        public string SurName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Nic { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public bool IsRemoved { get; set; }

        //public ICollection<Course> Courses { get; set; }

        public Lecturer()
        {
            //Courses = new List<Course>();
            //IsRemoved = false;
        }
    }
}
