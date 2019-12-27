using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using Nipuna.Users; // user management
using Nipuna.Students; // student 
using Nipuna.Lecturers; // lecturer
using Nipuna.Courses; // courses
using Nipuna.CourseEnrollments; // course enrollment
using Nipuna.StudentPaymnet; // course payment
using Nipuna.StudentAttendance; // student attendance
using Nipuna.Reports; // reports project
using Nipuna.Reports.Reports;
using Nipuna.Main; // home

namespace Nipuna
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Nipuna.Reports.Reports.frm_AttendanceRecord());
            //Application.Run(new Nipuna.Reports.frm_Reports());
            //Application.Run(new Nipuna.frm_Login());
            //Application.Run(new Nipuna.Login.frm_Splash());
            //Application.Run(new frm_Login());
            //Application.Run(new Nipuna.StudentPaymnet.frm_StudentPayment());
            //Application.Run(new Nipuna.Users.frm_UserRegistration());
            //Application.Run(new Nipuna.Users.frm_UserRegistration());
            //Application.Run(new Nipuna.StudentPaymnet.frm_StudentPayment());
            //Application.Run(new Nipuna.Reports.Reports.frm_CourseEnrollment());

            //Application.Run(new Nipuna.Students.frm_Students());
            //Application.Run(new Nipuna.CourseEnrollments.frm_CourseEnrollment());
            //Application.Run(new Nipuna.StudentPaymnet.frm_StudentPayment());
            //Application.Run(new Nipuna.Lecturers.frm_Lecturers());
            //Application.Run(new Nipuna.StudentAttendance.frm_Attendance());
            //Application.Run(new Nipuna.Reports.frm_Reports());
            //Application.Run(new Nipuna.Reports.Reports.frm_AttendanceRecordMatrix());
            Application.Run(new frm_Login());
            //Application.Run(new Nipuna.StudentPaymnet.frm_StudentPayment());
            //Application.Run(new Nipuna.StudentAttendance.frm_Attendance());


            //Application.Run(new Nipuna.Reports.Reports.frm_StudentAttendanceDates());
            //Application.Run(new Nipuna.Reports.Reports.frm_StudentPayment());
            //Application.Run(new Nipuna.Reports.Reports.frm_PaymentsByDate());
            //Application.Run(new Nipuna.StudentPaymnet.frm_StudentPayment());

            //Application.Run(new Nipuna.Reports.frm_Reports());
        }
    }
}
