using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nipuna.Model;
using Nipuna.DataAccess.Attendances;
using Nipuna.DataAccess.Students;
using Nipuna.DataAccess.RegistrationCodes;
using Nipuna.DataAccess.Payments;
using Nipuna.DataAccess.Enrollements;
using System.IO.Ports;
using System.Threading;

namespace Nipuna.StudentAttendance
{
    public partial class frm_Attendance : Form
    {
        public string parentContact;
        public string Message = "Please note that student has been attended to the class"+"\n"+"Nipuna Institute";
        public string Port = "COM17";

        public string Role;
        public string date = DateTime.Now.ToShortDateString();

        public frm_Attendance()
        {
            InitializeComponent();
        }

        public frm_Attendance(string role)
        {
            InitializeComponent();
            this.Role = role;
        }

        private void frm_Attendance_Load(object sender, EventArgs e)
        {
            //gridRefresh(); // call grid refresh method
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                var registrationId = txt_RegistrationId.Text;
                var courseId = txt_CourseId.Text;

                // get the last paid date 
                var lastRecord = PaymentDataAccess.checkLastRecord(registrationId, courseId);

                var lastPaidDate = Convert.ToDateTime(lastRecord.PaidDate);
                var currentDate = Convert.ToDateTime(DateTime.Today);
                var totalDays = (currentDate - lastPaidDate).TotalDays;

                var totalMonths = Math.Truncate((totalDays % 365) / 28);

                if (totalMonths > 1)
                {
                    DialogResult userInput = MessageBox.Show("Your last payment for " + txt_CourseName.Text + " course has been made on " + lastPaidDate + "\n" + "." + " Do you want to override process ?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (userInput == DialogResult.Yes)
                    {

                        var attendance = new Attendance();

                        attendance.Date = DateTime.Today.ToShortDateString();
                        attendance.RegistrationId = registrationId;
                        attendance.StudentID = txtStudentId.Text;
                        attendance.StudentName = txtStudentName.Text;
                        attendance.CourseId = txt_CourseId.Text;
                        attendance.CourseName = txt_CourseName.Text;
                        attendance.LecturerId = txtLecturerID.Text;
                        attendance.LecturerName = txtLecturerName.Text;

                        var result = AttendanceDataAccess.markAttendance(attendance);
                        if (result == true)
                        {
                            MessageBox.Show("Attendance has been recorded", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                            //gridRefresh(); // call grid refresh method
                            clearFields(); // call clear field method
                        }
                        else
                        {
                            MessageBox.Show("Unable to mark attendance", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    // display student payment history
                    PaymentHistroy();

                    // mark attendance
                    var attendance = new Attendance();

                    attendance.Date = DateTime.Today.ToShortDateString();
                    attendance.RegistrationId = registrationId;
                    attendance.StudentID = txtStudentName.Text;
                    attendance.StudentName = txtStudentName.Text;
                    attendance.CourseId = txt_CourseId.Text;
                    attendance.CourseName = txt_CourseName.Text;
                    attendance.LecturerId = txtLecturerID.Text;
                    attendance.LecturerName = txtLecturerName.Text;

                    var result = AttendanceDataAccess.markAttendance(attendance);
                    if (result == true)
                    {
                        MessageBox.Show("Attendance has been recorded", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        //gridRefresh(); // call grid refresh method
                        clearFields(); // call clear field method
                    }
                    else
                    {
                        MessageBox.Show("Unable to mark attendance", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed : " + ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // clear fields
            txt_RegistrationId.Clear();
            txtStudentId.Clear();
            txtStudentName.Clear();
            txt_CourseId.Clear();
            txt_CourseName.Clear();
            txtLecturerID.Clear();
            txtLecturerName.Clear();
        }

        private void txtStudentId_KeyDown(object sender, KeyEventArgs e)
        {
            // find student
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    var student = new Student();
                    student.RefNo = txtStudentId.Text;

                    var record = StudentDataAccess.findStudent(student);

                    // check if record is null
                    if (record == null)
                    {
                        MessageBox.Show("Record not found. Please enter correct Student-ID", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (record.IsRemoved == true)
                    {
                        MessageBox.Show("Inactive Student-ID found", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        txtStudentName.Text = record.Name;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed : " + ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txt_RegistrationId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    var registration = new RegistrationIds();
                    registration.RegistrationId = txt_RegistrationId.Text;

                    var record = RegistrationCodesDataAccess.findStudentByRegistrationId(registration);
                    if (record == null)
                    {
                        MessageBox.Show("Registration ID not found. Please check the registration ID", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        // get parent contact no.
                        var parentInfo = StudentDataAccess.findParentInfo(record.StudentId);
                        if (parentInfo == null)
                        {
                            return;
                        }
                        else if (parentInfo.Mobile == null)
                        {
                            return;
                        }
                        else 
                        {
                            parentContact = parentInfo.Pmobile; // assign phone number
                        }

                        var lecturerInfo = CourseEnrollmentDataAccess.findRegistrationDateByStudentId(record.RegistrationId, record.CourseId);
                        if (lecturerInfo == null)
                        {
                            MessageBox.Show("Unable to locate lecturer details", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                        else
                        {
                            txt_CourseId.Text = record.CourseId;
                            txtStudentId.Text = record.StudentId;
                            txtStudentName.Text = record.StudentName;
                            txt_CourseId.Text = record.CourseId;
                            txt_CourseName.Text = record.CourseName;
                            txtLecturerID.Text = lecturerInfo.LecturerId;
                            txtLecturerName.Text = lecturerInfo.LecturerName;

                            PaymentHistroy(); // call payment history method
                            Submit(); // call mark attendance
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void clearFields()
        {
            try
            {
                txt_RegistrationId.Text = "";
                txtStudentId.Text = "";
                txtStudentName.Text = "";
                txt_CourseId.Text = "";
                txt_CourseName.Text = "";
                txtLecturerID.Text = "";
                txtLecturerName.Text = "";

                gridInvoices.DataSource = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed : " + ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        //public void gridRefresh()
        //{
        //    try
        //    {
        //        var today = DateTime.Today.ToShortDateString();

        //        var source = AttendanceDataAccess.getAttendance()
        //            .Select(x => new
        //            {
        //                indexDate = x.Date,
        //                registrationID = x.RegistrationId,
        //                studentId = x.StudentID,
        //                studentName = x.StudentName,
        //                courseId = x.CourseId,
        //                courseName = x.CourseName,
        //                lecturerId = x.LecturerId,
        //                lecturerName = x.LecturerName,
        //            }).ToList();

        //        gridAttendance.Columns["indexDate"].HeaderText = "Date";
        //        gridAttendance.Columns["registrationID"].HeaderText = "Registation ID";
        //        gridAttendance.Columns["studentId"].HeaderText = "Student ID";
        //        gridAttendance.Columns["studentName"].HeaderText = "Student Name";
        //        gridAttendance.Columns["courseId"].HeaderText = "Course ID";
        //        gridAttendance.Columns["courseName"].HeaderText = "Course Name";
        //        gridAttendance.Columns["lecturerId"].HeaderText = "Lecturer ID";
        //        gridAttendance.Columns["lecturerName"].HeaderText = "Lecturer Name";

        //        // setting gridview column size
        //        gridAttendance.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        //        gridAttendance.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        //        gridAttendance.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Failed : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}
         public void Submit() 
        {
            try
            {
                var registrationId = txt_RegistrationId.Text;
                var courseId = txt_CourseId.Text;

                // get the last paid date 
                var lastRecord = PaymentDataAccess.checkLastRecord(registrationId, courseId);

                if (lastRecord == null)
                {
                    // mark attendance
                    var attendance = new Attendance();

                    attendance.Date = DateTime.Today.ToShortDateString();
                    attendance.RegistrationId = registrationId;
                    attendance.StudentID = txtStudentId.Text;
                    attendance.StudentName = txtStudentName.Text;
                    attendance.CourseId = txt_CourseId.Text;
                    attendance.CourseName = txt_CourseName.Text;
                    attendance.LecturerId = txtLecturerID.Text;
                    attendance.LecturerName = txtLecturerName.Text;

                    var result = AttendanceDataAccess.markAttendance(attendance);
                    if (result == true)
                    {
                        MessageBox.Show("Attendance has been recorded", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        //gridRefresh(); // call grid refresh method
                        //SendMessage(); // call send message method
                        clearFields(); // call clear field method
                    }
                    else
                    {
                        MessageBox.Show("Unable to mark attendance", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }
                else 
                {
                    // if any payment record excists in database
                    var lastPaidDate = Convert.ToDateTime(lastRecord.PaidDate);
                    var currentDate = Convert.ToDateTime(DateTime.Today);
                    var totalDays = (currentDate - lastPaidDate).TotalDays;

                    var totalMonths = Math.Truncate((totalDays % 365) / 28);

                    if (totalMonths > 1) 
                    {
                        DialogResult userInput = MessageBox.Show("Your last payment for " + txt_CourseName.Text + " course has been made on " + lastPaidDate + "\n" + "." + " Do you want to override process ?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (userInput == DialogResult.Yes)
                        {
                            var attendance = new Attendance();

                            attendance.Date = DateTime.Today.ToShortDateString();
                            attendance.RegistrationId = registrationId;
                            attendance.StudentID = txtStudentId.Text ;
                            attendance.StudentName = txtStudentName.Text;
                            attendance.CourseId = txt_CourseId.Text;
                            attendance.CourseName = txt_CourseName.Text;
                            attendance.LecturerId = txtLecturerID.Text;
                            attendance.LecturerName = txtLecturerName.Text;

                            var result = AttendanceDataAccess.markAttendance(attendance);
                            if (result == true)
                            {
                                MessageBox.Show("Attendance has been recorded", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                                //gridRefresh(); // call grid refresh method
                                //SendMessage(); // call send message method
                                clearFields(); // call clear field method
                            }
                            else
                            {
                                MessageBox.Show("Unable to mark attendance", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            }
                        }
                        else 
                        {
                            return;
                        }
                    }
                    else
                    {
                            // mark attendance
                            var attendance = new Attendance();

                            attendance.Date = DateTime.Today.ToShortDateString();
                            attendance.RegistrationId = registrationId;
                            attendance.StudentID = txtStudentId.Text;
                            attendance.StudentName = txtStudentName.Text;
                            attendance.CourseId = txt_CourseId.Text;
                            attendance.CourseName = txt_CourseName.Text;
                            attendance.LecturerId = txtLecturerID.Text;
                            attendance.LecturerName = txtLecturerName.Text;

                            var result = AttendanceDataAccess.markAttendance(attendance);
                            if (result == true)
                            {
                                MessageBox.Show("Attendance has been recorded", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                                //gridRefresh(); // call grid refresh method
                                //SendMessage(); // call send message method
                                clearFields(); // call clear field method
                            }
                            else
                            {
                                MessageBox.Show("Unable to mark attendance", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void SendMessage() 
        {
            try
            {
                var sp = new SerialPort();
                sp.PortName = Port; // port name
                sp.Open(); // open port
                sp.WriteLine("AT" + Environment.NewLine);
                Thread.Sleep(100);
                sp.WriteLine("AT+CMGF=1" + Environment.NewLine);
                Thread.Sleep(100);
                sp.WriteLine("AT+CSCS=\"GSM\"" + Environment.NewLine);
                Thread.Sleep(100);
                sp.WriteLine("AT+CMGS=\"" + parentContact + "\"" + Environment.NewLine);
                Thread.Sleep(100);
                sp.WriteLine(Message + Environment.NewLine);
                Thread.Sleep(100);
                sp.Write(new byte[] { 26 }, 0, 1);
                Thread.Sleep(100);
                var response = sp.ReadExisting();
                if (response.Contains("Error"))
                {
                    //MessageBox.Show("Send failed !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else 
                {
                    //MessageBox.Show("SMS sent !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                sp.Close(); // close port
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed : " + ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        public void PaymentHistroy() 
        {
            // display student payment history
            var paymentHistroy = PaymentDataAccess.getPaymentRecordsById(txt_RegistrationId.Text, txt_CourseId.Text);
            if (paymentHistroy == null)
            {
                return;
            }
            else
            {
                gridInvoices.DataSource = null;
                gridInvoices.DataSource = paymentHistroy.Select(x => new
                {
                    invoiceNo = x.InvoiceNo,
                    registrationId = x.RegistrationId,
                    courseId = x.CourseId,
                    courseName = x.CourseName,
                    paidMonth = x.PaidDate,
                    invoiceDate = x.Invoicedate
                }).ToList();

                // display data in datagrid view
                gridInvoices.Columns["invoiceNo"].HeaderText = "Invoice #.";
                gridInvoices.Columns["registrationId"].HeaderText = "Registration ID";
                gridInvoices.Columns["courseId"].HeaderText = "Course ID";
                gridInvoices.Columns["courseName"].HeaderText = "Course Name";
                gridInvoices.Columns["paidMonth"].HeaderText = "Paid Month";
                gridInvoices.Columns["invoiceDate"].HeaderText = "Invoice Date";

                // setting gridview column size
                gridInvoices.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                gridInvoices.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                gridInvoices.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                gridInvoices.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                gridInvoices.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                gridInvoices.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            }
        }
    }
}
