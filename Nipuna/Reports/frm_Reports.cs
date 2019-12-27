using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nipuna.Reports.Reports;


namespace Nipuna.Reports
{
    public partial class frm_Reports : MetroFramework.Forms.MetroForm
    {
        public string Role;
        public frm_Reports()
        {
            InitializeComponent();
        }

        public frm_Reports(string role) 
        {
            this.Role = role;
        }

        private void frm_Reports_Load(object sender, EventArgs e)
        {
            Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.White;


        }

        private void pic_Close_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "Do you want to exit ?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                return;
            }
        }

        private void pic_Maximize_Click(object sender, EventArgs e)
        {
            // Maximize window
            this.WindowState = FormWindowState.Maximized;
        }

        private void pic_Resize_Click(object sender, EventArgs e)
        {
            // Resize
            this.WindowState = FormWindowState.Normal;
        }

        private void pic_Minimize_Click(object sender, EventArgs e)
        {
            // Minimize window
            this.WindowState = FormWindowState.Minimized;
        }

        private void studentRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // show student registration report
            var registration = new frm_StudentRegistration();
            registration.MdiParent = this ;
            registration.Show();
        }

        private void studentDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void allStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // show all student details report
            try
            {
            var studentDetails = new frm_StudentDetails();
            studentDetails.MdiParent = this;
            studentDetails.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed : " + ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            //var studentDetails = new frm_StudentDetails();
            //studentDetails.MdiParent = this;
            //studentDetails.Show();
        }

        private void singleRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // show single student detail report
            var studentDetail = new frm_StudentDetailsFilterStudentId();
            studentDetail.MdiParent = this;
            studentDetail.WindowState = FormWindowState.Maximized;
            studentDetail.Show();
        }

        private void attendanceByLecturerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // show student attendance by lecturer id
            var studentAttendance = new frm_AttendanceFilterLecturerId();
            studentAttendance.MdiParent = this;
            studentAttendance.WindowState = FormWindowState.Maximized;
            studentAttendance.Show();
        }

        private void attendanceByStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // show student attendance by student id
            var studentAttendance = new frm_AttendanceFilterStudentId();
            studentAttendance.MdiParent = this;
            studentAttendance.WindowState = FormWindowState.Maximized;
            studentAttendance.Show();
        }

        private void allRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // show lecturer details report
            var lecturerDetails = new frm_LecturerDetails();
            lecturerDetails.MdiParent = this;
            lecturerDetails.WindowState = FormWindowState.Maximized;
            lecturerDetails.Show();
        }

        private void byLecturerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // show lecturer details by lecturer id
            var lecturerDetails = new frm_LecturerDetailsFilterLecturerId();
            lecturerDetails.MdiParent = this;
            lecturerDetails.WindowState = FormWindowState.Maximized;
            lecturerDetails.Show();
        }

        private void allRecordsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // show all lecturer enrollment report
            var lecturerEnrollment = new frm_LecturerEnrollment();
            lecturerEnrollment.MdiParent = this;
            lecturerEnrollment.WindowState = FormWindowState.Maximized;
            lecturerEnrollment.Show();
        }

        private void lecturerEnrollmentByLecturerIDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // show lecturer enrollment by lecturer name
            var lecturerEnrollment = new frm_LecturerEnrollmentByLecturerName();
            lecturerEnrollment.MdiParent = this;
            lecturerEnrollment.WindowState = FormWindowState.Maximized;
            lecturerEnrollment.Show();
        }

        private void lecturerEnrollmentByCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // show lecturer enrollment by course
            var lecturerEnrollment = new frm_LecturerEnrollmentByCourse();
            lecturerEnrollment.MdiParent = this;
            lecturerEnrollment.WindowState = FormWindowState.Maximized;
            lecturerEnrollment.Show();
        }

        private void courseDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // show course details report
            var courseDetails = new frm_CourseDetails();
            courseDetails.MdiParent = this;
            courseDetails.WindowState = FormWindowState.Maximized;
            courseDetails.Show();
        }

        private void courseEnrollmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // show course enrollment details report
            var courseEnrollment = new frm_CourseEnrollment();
            courseEnrollment.MdiParent = this;
            courseEnrollment.WindowState = FormWindowState.Maximized;
            courseEnrollment.Show();
        }

        private void studentPaymnetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // show all payment records
            var studentPayment = new frm_StudentPayment();
            studentPayment.MdiParent = this;
            studentPayment.WindowState = FormWindowState.Maximized;
            studentPayment.Show();
        }

        private void paymentByLecturerIDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // show payment records by lecturer id
            var studentPayment = new frm_PaymentByLecturerId();
            studentPayment.MdiParent = this;
            studentPayment.WindowState = FormWindowState.Maximized;
            studentPayment.Show();
        }

        private void paymentByStudentIDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // show payment records by student id
            var studentPayment = new frm_PaymentByStudentId();
            studentPayment.MdiParent = this;
            studentPayment.WindowState = FormWindowState.Maximized;
            studentPayment.Show();
        }

        private void paymentByLecturerIDToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // show single payment record based on lecturer id
            var studentPayment = new frm_PaymentFilterLecturerId();
            studentPayment.MdiParent = this;
            studentPayment.WindowState = FormWindowState.Maximized;
            studentPayment.Show();
        }

        private void paymentByStudentIDToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // show single payment record based on student id
            var studentPayment = new frm_PaymentFilterStudentId();
            studentPayment.MdiParent = this;
            studentPayment.WindowState = FormWindowState.Maximized;
            studentPayment.Show();
        }

        private void allRecordsToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            // show all attendance records
            var attendance = new frm_StudentAttendance();
            attendance.MdiParent = this;
            attendance.WindowState = FormWindowState.Maximized;
            attendance.Show();
        }

        private void userProfileReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // show all user account records
            var users = new frm_Users();
            users.MdiParent = this;
            users.WindowState = FormWindowState.Maximized;
            users.Show();
        }

        private void studentRecordsMatrixToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // show all user account records
            var AttendanceMatrix = new frm_StudentAttendanceDates();
            AttendanceMatrix.MdiParent = this;
            AttendanceMatrix.WindowState = FormWindowState.Maximized;
            AttendanceMatrix.Show();
        }

        private void paymentsByDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // show all payments by date (Filter)
            var paymentsReport = new frm_PaymentsByDate();
            paymentsReport.MdiParent = this;
            paymentsReport.WindowState = FormWindowState.Maximized;
            paymentsReport.Show();
        }
    }
}
