using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nipuna.Model;

namespace Nipuna.DataAccess.RegistrationCodes
{
    public class RegistrationCodesDataAccess
    {
        // get all issued barcode info
        public static IEnumerable<RegistrationIds> getBarcodes()
        {
            using (var db = new NipunaDataContext())
            {
                var records = db.RegistrationIds.ToList();
                return records;
            }
        }

        // add new record
        public static bool add(RegistrationIds barcodeInfo)
        {
            using (var db = new NipunaDataContext())
            {
                db.RegistrationIds.Add(barcodeInfo);
                db.SaveChanges();

                return true;
            }
        }

        // find student by course registration Id
        public static RegistrationIds findStudentByRegistrationId(RegistrationIds registration)
        {
            using (var db = new NipunaDataContext())
            {
                var record = db.RegistrationIds.SingleOrDefault(x => x.RegistrationId == registration.RegistrationId);
                return record;
            }
        }

        // filter registraion id
        public static IEnumerable<RegistrationIds> filterRegistrationId(string search) 
        {
            using (var db = new NipunaDataContext())
            {
                var records = db.RegistrationIds.Where(x => x.StudentId.StartsWith(search)
                                                || x.StudentName.StartsWith(search)
                                                || x.CourseId.StartsWith(search)
                                                || x.CourseName.StartsWith(search)).ToList();
                return records;
            }
        }
    }
}
