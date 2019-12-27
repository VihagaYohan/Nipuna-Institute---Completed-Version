using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Nipuna.Model;
using Nipuna.Models;

namespace Nipuna.DataAccess
{
    public class NipunaDataContext:DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseEnrollment> CourseEnrollments { get; set; }
        public DbSet<Lecturer> Lecturers { get; set; }
        public DbSet<LecturerCourses> LecturerCourses { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Attendance> Attendances { get; set; }
        public DbSet<RegistrationIds> RegistrationIds { get; set; }

        public DbSet<Sample> tbStudent { get; set; }
        public NipunaDataContext():base("name=DB")
        {

        }
    }
}
