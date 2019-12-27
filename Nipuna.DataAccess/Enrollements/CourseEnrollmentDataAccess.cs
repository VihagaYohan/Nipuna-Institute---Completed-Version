using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nipuna.Model;

namespace Nipuna.DataAccess.Enrollements
{
    public class CourseEnrollmentDataAccess
    {
        // get all course enrollment
        public static IEnumerable<CourseEnrollment> getEnrollements()
        {
            using (var db = new NipunaDataContext())
            {
                var record = db.CourseEnrollments.Where(x => x.IsRemoved == false).ToList();
                return record;
            }
        }

        // add course enrollment
        public static bool addEnrollment(CourseEnrollment enrollment)
        {
            using (var db = new NipunaDataContext())
            {
                db.CourseEnrollments.Add(enrollment);
                db.SaveChanges();
                return true;
            }
        }

        // edit course enrollment
        public static bool edit(CourseEnrollment enrollment)
        {
            using (var db = new NipunaDataContext())
            {
                var record = db.CourseEnrollments.SingleOrDefault(x => x.Id == enrollment.Id);
                record.RegistrationId = enrollment.RegistrationId;
                record.StudentName = enrollment.StudentName;
                record.CourseId = enrollment.CourseId;
                record.CourseName = enrollment.CourseName;
                record.LecturerId = enrollment.LecturerId;
                record.LecturerName = enrollment.LecturerName;
                record.RegisteredDate = enrollment.RegisteredDate;

                db.SaveChanges();
                return true;
            }
        }

        // delete 
        public static bool delete(CourseEnrollment enrollment)
        {
            using (var db = new NipunaDataContext())
            {
                var record = db.CourseEnrollments.SingleOrDefault(x => x.Id == enrollment.Id);
                record.IsRemoved = true;

                db.SaveChanges();
                return true;
            }
        }

        // filter
        public static IEnumerable<CourseEnrollment> filter(string search)
        {
            using (var db = new NipunaDataContext())
            {
                var records = db.CourseEnrollments.Where(x => x.Id.ToString().StartsWith(search)
                                                            || x.RegistrationId.ToString().StartsWith(search)
                                                            || x.StudentName.StartsWith(search)
                                                            || x.CourseId.ToString().StartsWith(search)
                                                            || x.CourseName.StartsWith(search)).ToList();
                return records;
            }
        }

        // find courses by student Id
        public static IEnumerable<CourseEnrollment> findCourseByStudentId(string registrationId)
        {
            using (var db = new NipunaDataContext())
            {
                var records = db.CourseEnrollments.Where(x => x.RegistrationId == registrationId).ToList();
                return records;
            }
        }

        // find course by course id
        public static CourseEnrollment findCourseByCourseId(string id)
        {
            using (var db = new NipunaDataContext())
            {
                var records = db.CourseEnrollments.SingleOrDefault(x => x.CourseId == id);
                return records;
            }
        }

        // find course registration date by course id and student id
        public static CourseEnrollment findRegistrationDateByStudentId(string registrationId, string courseId)
        {
            using (var db = new NipunaDataContext())
            {
                var record = db.CourseEnrollments.Where(x => x.RegistrationId == registrationId && x.CourseId == courseId).OrderByDescending(x => x.Id).FirstOrDefault();
                return record;
            }
        }

        // find last entry
        public static CourseEnrollment findLastEntry(string courseId)
        {
            using (var db = new NipunaDataContext())
            {
                var record = db.CourseEnrollments.Where(x => x.CourseId == courseId).OrderByDescending(x => x.Id).FirstOrDefault();
                return record;
            }
        }
    }
}
