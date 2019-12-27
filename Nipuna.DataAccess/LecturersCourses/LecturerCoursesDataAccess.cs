using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nipuna.Model;

namespace Nipuna.DataAccess.LecturersCourses
{
    public class LecturerCoursesDataAccess
    {
        // get all assigned courses
        public static IEnumerable<LecturerCourses> getCourses()
        {
            using (var db = new NipunaDataContext())
            {
                var records = db.LecturerCourses.ToList();
                return records;
            }
        }

        // assign courses to lecturers
        public static bool assignCourse(LecturerCourses assign)
        {
            using (var db = new NipunaDataContext())
            {
                db.LecturerCourses.Add(assign);
                db.SaveChanges();

                return true;
            }
        }

        // edit data
        public static bool edit(LecturerCourses assign)
        {
            using (var db = new NipunaDataContext())
            {
                var record = db.LecturerCourses.SingleOrDefault(x => x.Id == assign.Id);
                record.LecturerId = assign.LecturerId;
                record.LecturerName = assign.LecturerName;
                record.CourseId = assign.CourseId;
                record.CourseName = assign.CourseName;

                db.SaveChanges();
                return true;
            }
        }

        // delete data
        public static bool delete(LecturerCourses assign)
        {
            using (var db = new NipunaDataContext())
            {
                var record = db.LecturerCourses.SingleOrDefault(x => x.Id == assign.Id);
                db.LecturerCourses.Remove(record);

                db.SaveChanges();
                return true;
            }
        }

        // filter gridview
        public static IEnumerable<LecturerCourses> filter(string search)
        {
            using (var db = new NipunaDataContext())
            {
                var records = db.LecturerCourses.Where(x => x.Id.ToString().StartsWith(search)
                                                          || x.LecturerId.ToString().StartsWith(search)
                                                          || x.CourseId.ToString().StartsWith(search)
                                                          || x.LecturerName.StartsWith(search)
                                                          || x.CourseName.StartsWith(search)).ToList();
                return records;
            }
        }

        // find lectuerers by course id
        public static IEnumerable<LecturerCourses> findLectuerersByCourseId(string courseId)
        {
            using (var db = new NipunaDataContext())
            {
                var records = db.LecturerCourses.Where(x => x.CourseId == courseId).ToList();
                return records;
            }
        }
    }
}
