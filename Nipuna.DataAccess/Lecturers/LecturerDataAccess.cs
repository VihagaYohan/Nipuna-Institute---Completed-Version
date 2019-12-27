using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nipuna.Model;

namespace Nipuna.DataAccess.Lecturers
{
    public class LecturerDataAccess
    {
        // get all lecturer
        public static IEnumerable<Lecturer> getLecturers()
        {
            using (var db = new NipunaDataContext())
            {
                var records = db.Lecturers.ToList();
                return records;
            }
        }

        // add new lecturer
        public static bool addLecturer(Lecturer lecturer)
        {
            using (var db = new NipunaDataContext())
            {
                db.Lecturers.Add(lecturer);
                db.SaveChanges();
                return true;
            }
        }

        // edit lecturer data
        public static Lecturer editLecturer(Lecturer lecturer)
        {
            using (var db = new NipunaDataContext())
            {
                var record = db.Lecturers.SingleOrDefault(x => x.LecturerId == lecturer.LecturerId);
                record.SurName = lecturer.SurName;
                record.FirstName = lecturer.FirstName;
                record.LastName = lecturer.LastName;
                record.Nic = lecturer.Nic;
                record.Address = lecturer.Address;
                record.Mobile = lecturer.Mobile;
                record.Email = lecturer.Email;

                db.SaveChanges();

                return lecturer;
            }
        }

        // delete lecturer data
        public static Lecturer deleteLecturer(Lecturer lecturer)
        {
            using (var db = new NipunaDataContext())
            {
                var record = db.Lecturers.SingleOrDefault(x => x.LecturerId == lecturer.LecturerId);
                record.IsRemoved = lecturer.IsRemoved;

                db.SaveChanges();

                return lecturer;
            }
        }

        // filter lecturer datagrid
        public static IEnumerable<Lecturer> filterLecturers(string search)
        {
            using (var db = new NipunaDataContext())
            {
                var records = db.Lecturers.Where(x => x.LecturerId.StartsWith(search)
                                                || x.SurName.StartsWith(search)
                                                || x.FirstName.StartsWith(search)
                                                || x.LastName.StartsWith(search)
                                                || x.Nic.StartsWith(search)
                                                || x.Mobile.StartsWith(search)).ToList();
                return records;
            }
        }

        // find lecturer by id
        public static Lecturer findLecturerById(Lecturer lecturer)
        {
            using (var db = new NipunaDataContext())
            {
                var records = db.Lecturers.SingleOrDefault(x => x.LecturerId == lecturer.LecturerId);
                return records;
            }
        }

       
    }
}
