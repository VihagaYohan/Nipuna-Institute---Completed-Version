using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nipuna.Model;

namespace Nipuna.DataAccess.Courses
{
    public class CoursesDataAccess
    {
        // get all courses
        public static IEnumerable<Course> getCourses()
        {
            using (var db = new NipunaDataContext())
            {
                var record = db.Courses.ToList();
                return record;
            }
        }

        // add new courses
        public static bool addCourses(Course course)
        {
            using (var db = new NipunaDataContext())
            {
                db.Courses.Add(course);
                db.SaveChanges();

                return true;
            }
        }

        // edit course
        public static Course editCourse(Course course)
        {
            using (var db = new NipunaDataContext())
            {
                var record = db.Courses.SingleOrDefault(x => x.RefNo == course.RefNo);
                record.Title = course.Title;
                record.Fee = course.Fee;

                db.SaveChanges();
                return record;
            }
        }

        // delete course
        public static Course deleteCourse(Course course)
        {
            using (var db = new NipunaDataContext())
            {
                var record = db.Courses.SingleOrDefault(x => x.RefNo == course.RefNo);
                record.IsRemoved = course.IsRemoved;

                db.SaveChanges();
                return record;
            }
        }

        // filter datagrid view based on search value
        public static IEnumerable<Course> filterCourses(string search)
        {
            using (var db = new NipunaDataContext())
            {
                var record = db.Courses.Where(x => x.RefNo.StartsWith(search)
                                              || x.Title.StartsWith(search)
                                              || x.Fee.ToString().StartsWith(search)).ToList();
                return record;
            }
        }

        // find course by id
        public static Course findCourseById(Course course)
        {
            using (var db = new NipunaDataContext())
            {
                var records = db.Courses.SingleOrDefault(x => x.RefNo == course.RefNo);
                return records;
            }
        }


    }
}
