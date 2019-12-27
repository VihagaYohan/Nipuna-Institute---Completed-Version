using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nipuna.Model;

namespace Nipuna.DataAccess.Students
{
    public class StudentDataAccess
    {
        // get all students
        public static IEnumerable<Student> getSutdents()
        {
            using (var db = new NipunaDataContext())
            {
                var record = db.Students.ToList();
                return record;
            }
        }

        // add new student
        public static bool addStudent(Student student)
        {
            using (var db = new NipunaDataContext())
            {
                db.Students.Add(student);
                db.SaveChanges();
                return true;
            }
        }

        // edit student records
        public static Student editStudent(Student student)
        {
            using (var db = new NipunaDataContext())
            {
                var record = db.Students.SingleOrDefault(x => x.RefNo == student.RefNo);
                record.Name = student.Name;
                record.Nic = student.Nic;
                record.Dob = student.Dob;
                record.School = student.School;
                record.Address = student.Address;
                record.Mobile = student.Mobile;
                record.Email = student.Email;
                record.Type = student.Type;
                record.Pname = student.Pname;
                record.Pmobile = student.Pmobile;
                record.Plandline = student.Plandline;

                db.SaveChanges();
                return record;

            }
        }

        // Remove student - change IsRemove property to false
        public static Student deleteStudent (Student student)
        {
            using (var db = new NipunaDataContext())
            {
                var record = db.Students.SingleOrDefault(x => x.RefNo == student.RefNo);
                record.IsRemoved = student.IsRemoved;

                db.SaveChanges();

                return record;
            }
        }

        // filter student datagrid
        public static IEnumerable<Student> filterStudent(string search)
        {
            using (var db = new NipunaDataContext())
            {
                var records = db.Students.Where(x => x.RefNo.StartsWith(search)
                                                || x.Name.StartsWith(search)
                                                || x.Nic.StartsWith(search)
                                                || x.Mobile.StartsWith(search)).ToList();
                return records;
            }
        }

        // find students by id
        public static Student findStudent(Student student)
        {
            using (var db = new NipunaDataContext())
            {
                var record = db.Students.SingleOrDefault(x => x.RefNo == student.RefNo);
                return record;
            }
        }

        // find student parent info by student id
        public static Student findParentInfo(string studentId) 
        {
            using (var db = new NipunaDataContext()) 
            {
                var record = db.Students.SingleOrDefault(x => x.RefNo == studentId);
                return record;
            }
        }


        // find student by NIC. no
        public static Student findStudentByNic(string nic)
        {
            using (var db = new NipunaDataContext())
            {
                var record = db.Students.SingleOrDefault(x => x.Nic == nic);
                return record;
            }
        }

        // get list of students by NIC. no
        public static IEnumerable<Student> getStudentsByNic(string nic)
        {
            using (var db = new NipunaDataContext())
            {
                var record = db.Students.Where(x => x.Nic == nic).ToList();
                return record;
            }
        }
    }
}
