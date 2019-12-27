using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nipuna.Model;
using Nipuna.DataAccess;

namespace Nipuna.DataAccess.Attendances
{
    public class AttendanceDataAccess
    {
        // get all attendance
        public static IEnumerable<Attendance> getAttendance()
        {
            using (var db = new NipunaDataContext())
            {
                var record = db.Attendances.ToList();
                return record;
            }
        }

        // mark attendance
        public static bool markAttendance(Attendance attendnace)
        {
            using (var db = new NipunaDataContext())
            {
                db.Attendances.Add(attendnace);
                db.SaveChanges();
                return true;
            }
        }

        // delete attendance record
        public static bool deleteAttendance(Attendance attendance)
        {
            using (var db = new NipunaDataContext())
            {
                var record = db.Attendances.SingleOrDefault(x => x.Id == attendance.Id);
                db.Attendances.Remove(record);
                db.SaveChanges();

                return true;
            }
        }

        // filter grid view
        public static IEnumerable<Attendance> filter(string search)
        {
            using (var db = new NipunaDataContext())
            {
                var record = db.Attendances.Where(x => x.Id.ToString().StartsWith(search)
                                                     || x.StudentID.StartsWith(search)
                                                     || x.StudentName.StartsWith(search)
                                                     || x.CourseId.StartsWith(search)
                                                     || x.CourseName.StartsWith(search)).ToList();
                return record;
            }
        }
    }
}
