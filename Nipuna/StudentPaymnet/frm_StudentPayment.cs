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
using Nipuna.DataAccess.Payments;
using Nipuna.DataAccess.Enrollements;
using Nipuna.DataAccess.Courses;
using Nipuna.DataAccess.RegistrationCodes;

namespace Nipuna.StudentPaymnet
{
    public partial class frm_StudentPayment : Form
    {
        public string InvoiceNo = null;
        public string Role;
        public string Username;
        public DateTime paymentDate;
        public string studentId;

        public frm_StudentPayment()
        {
            InitializeComponent();
        }

        public frm_StudentPayment(string role, string username)
        {
            InitializeComponent();
            this.Username = username;
            this.Role = role;
        }

        private void frm_StudentPayment_Load(object sender, EventArgs e)
        {
            try
            {
                gridRefresh(); // call grid refresh method

                // enable controls based on job role
                if (Role == "Checker")
                {
                    panel_Buttons.Enabled = false;
                }
                else
                {
                    panel_Buttons.Enabled = true;
                }

                generateInvoiceNo(); // call generate invoice number method
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // add payment details
            try
            {
                var absentPayment = false;

                if (chk_AbsentPayment.Checked)
                {
                    var registrationId = txtRegistrationId.Text;
                    var courseId = txtCourseId.Text;

                    absentPayment = true;

                    var payment = new Payment();
                    payment.InvoiceNo = txtInvoiceNo.Text;
                    payment.RegistrationId = txtRegistrationId.Text;
                    payment.StudentName = txtStudentName.Text;
                    payment.CourseId = txtCourseId.Text;
                    payment.CourseName = txtCourseName.Text;
                    payment.Fee = Convert.ToDecimal(txtFee.Text);
                    payment.Amount = 0;
                    payment.Balance = 0;
                    payment.LecturerId = txtLectuerId.Text;
                    payment.LectuerName = txtLecturerName.Text;
                    payment.PaidDate = datePayment.Value;
                    payment.Invoicedate = Convert.ToDateTime(DateTime.Today.ToShortDateString());
                    payment.AbsentPayment = absentPayment;
                    payment.Username = Username;


                    var record = PaymentDataAccess.addPayment(payment);

                    if (record == true)
                    {
                        MessageBox.Show("Payment record has been saved successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        gridRefresh(); // call grid refresh method
                        clearField(); // call clear field method

                        // show invoice
                        var invoice = new frm_printInvoice(payment);
                        invoice.Show();

                        generateInvoiceNo(); // call generate invoice number method
                    }
                    else
                    {
                        MessageBox.Show("Unable to save payment record", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }
                else
                {
                    var registrationId = txtRegistrationId.Text;
                    var courseId = txtCourseId.Text;

                    absentPayment = false;

                    var payment = new Payment();
                    payment.InvoiceNo = txtInvoiceNo.Text;
                    payment.RegistrationId = txtRegistrationId.Text;
                    payment.StudentName = txtStudentName.Text;
                    payment.CourseId = txtCourseId.Text;
                    payment.CourseName = txtCourseName.Text;
                    payment.Fee = Convert.ToDecimal(txtFee.Text);
                    payment.Amount = Convert.ToDecimal(txtAmount.Text);
                    payment.Balance = Convert.ToDecimal(txtBalance.Text);
                    payment.LecturerId = txtLectuerId.Text;
                    payment.LectuerName = txtLecturerName.Text;
                    payment.PaidDate = datePayment.Value;
                    payment.Invoicedate = Convert.ToDateTime(DateTime.Today.ToShortDateString());
                    payment.AbsentPayment = absentPayment;
                    payment.Username = Username;


                    var record = PaymentDataAccess.addPayment(payment);

                    if (record == true)
                    {
                        MessageBox.Show("Payment record has been saved successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        gridRefresh(); // call grid refresh method
                        clearField(); // call clear field method

                        // show invoice
                        var invoice = new frm_printInvoice(payment);
                        invoice.Show();

                        generateInvoiceNo(); // call generate invoice number method
                    }
                    else
                    {
                        MessageBox.Show("Unable to save payment record", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }
                //var courseRecord = CourseEnrollmentDataAccess.findRegistrationDateByStudentId(registrationId, courseId);
                //paymentDate = courseRecord.RegisteredDate; // get course registered date as the payment required date

                //// check whether there's already payment records available for subject student id and course id
                //var result = PaymentDataAccess.checkRegistrationId(registrationId);
                
                //if (result == null)
                //{
                //    var payment = new Payment();
                //    payment.InvoiceNo = txtInvoiceNo.Text;
                //    payment.RegistrationId = txtRegistrationId.Text;
                //    payment.StudentName = txtStudentName.Text;
                //    payment.CourseId = txtCourseId.Text;
                //    payment.CourseName = txtCourseName.Text;
                //    payment.Fee = Convert.ToDecimal(txtFee.Text);
                //    payment.Amount = Convert.ToDecimal(txtAmount.Text);
                //    payment.Balance = Convert.ToDecimal(txtBalance.Text);
                //    payment.LecturerId = txtLectuerId.Text;
                //    payment.LectuerName = txtLecturerName.Text;
                //    payment.PaidDate = paymentDate;
                //    payment.Invoicedate = Convert.ToDateTime(DateTime.Today.ToShortDateString());
                //    payment.Username = Username;

                    
                //}
                //else
                //{
                //    // get the last paid date 
                //    var lastRecord = PaymentDataAccess.getLastRecord(registrationId, courseId);

                //    var lastPaidDate = Convert.ToDateTime(lastRecord.PaidDate);
                //    var currentDate = Convert.ToDateTime(DateTime.Today);
                //    var totalDays = (currentDate - lastPaidDate).TotalDays;

                //    var totalMonths = Math.Truncate((totalDays % 365) / 28);

                //    if (totalMonths == 1)
                //    {
                //        // payment
                //        var payment = new Payment();
                //        payment.InvoiceNo = txtInvoiceNo.Text;
                //        payment.RegistrationId = txtRegistrationId.Text;
                //        payment.StudentName = txtStudentName.Text;
                //        payment.CourseId = txtCourseId.Text;
                //        payment.CourseName = txtCourseName.Text;
                //        payment.Fee = Convert.ToDecimal(txtFee.Text);
                //        payment.Amount = Convert.ToDecimal(txtAmount.Text);
                //        payment.Balance = Convert.ToDecimal(txtBalance.Text);
                //        payment.LecturerId = txtLectuerId.Text;
                //        payment.LectuerName = txtLecturerName.Text;
                //        payment.PaidDate = lastPaidDate.AddMonths(1);
                //        payment.Invoicedate = Convert.ToDateTime(DateTime.Today.ToShortDateString());
                //        payment.Username = Username;

                //        var record = PaymentDataAccess.addPayment(payment);

                //        if (record == true)
                //        {
                //            MessageBox.Show("Payment record has been saved successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //            gridRefresh(); // call grid refresh method
                //            clearField(); // call clear field method

                //            // show invoice 
                //            var invoice = new frm_printInvoice(payment);
                //            invoice.Show();

                //            generateInvoiceNo(); // call generate invoice number method
                //        }
                //        else
                //        {
                //            MessageBox.Show("Unable to save payment record", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                //        }
                //    }
                //    else
                //    {
                //        DialogResult userInput = MessageBox.Show("Your last payment for " + txtCourseName.Text + " course has been made on " + lastPaidDate + "\n" + "." + " Do you want to continue with payment process ?", "Alert", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                //        if (userInput == DialogResult.Yes)
                //        {
                //            // Yes - add a month to last paid date and save payment record
                //            var payment = new Payment();
                //            payment.InvoiceNo = txtInvoiceNo.Text;
                //            payment.RegistrationId = txtRegistrationId.Text;
                //            payment.StudentName = txtStudentName.Text;
                //            payment.CourseId = txtCourseId.Text;
                //            payment.CourseName = txtCourseName.Text;
                //            payment.Fee = Convert.ToDecimal(txtFee.Text);
                //            payment.Amount = Convert.ToDecimal(txtAmount.Text);
                //            payment.Balance = Convert.ToDecimal(txtBalance.Text);
                //            payment.LecturerId = txtLectuerId.Text;
                //            payment.LectuerName = txtLecturerName.Text;
                //            payment.PaidDate = lastPaidDate.AddMonths(1);
                //            payment.Invoicedate = Convert.ToDateTime(DateTime.Today.ToShortDateString());
                //            payment.Username = Username;

                //            var record = PaymentDataAccess.addPayment(payment);

                //            if (record == true)
                //            {
                //                MessageBox.Show("Payment record has been saved successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //                gridRefresh(); // call grid refresh method
                //                clearField(); // call clear field method

                //                // show invoice 
                //                var invoice = new frm_printInvoice(payment);
                //                invoice.Show();

                //                generateInvoiceNo(); // call generate invoice number method
                //            }
                //            else
                //            {
                //                MessageBox.Show("Unable to save payment record", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                //            }
                //        }
                //        else if (userInput == DialogResult.No)
                //        {
                //            // No - start a new payment flow and set the paid date to the current date
                //            var payment = new Payment();
                //            payment.InvoiceNo = txtInvoiceNo.Text;
                //            payment.RegistrationId = txtRegistrationId.Text;
                //            payment.StudentName = txtStudentName.Text;
                //            payment.CourseId = txtCourseId.Text;
                //            payment.CourseName = txtCourseName.Text;
                //            payment.Fee = Convert.ToDecimal(txtFee.Text);
                //            payment.Amount = Convert.ToDecimal(txtAmount.Text);
                //            payment.Balance = Convert.ToDecimal(txtBalance.Text);
                //            payment.LecturerId = txtLectuerId.Text;
                //            payment.LectuerName = txtLecturerName.Text;
                //            payment.PaidDate = Convert.ToDateTime(DateTime.Today.ToShortDateString());
                //            payment.Invoicedate = Convert.ToDateTime(DateTime.Today.ToShortDateString());
                //            payment.Username = Username;

                //            var record = PaymentDataAccess.addPayment(payment);

                //            if (record == true)
                //            {
                //                MessageBox.Show("Payment record has been saved successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //                gridRefresh(); // call grid refresh method
                //                clearField(); // call clear field method

                //                // show invoice 
                //                var invoice = new frm_printInvoice(payment);
                //                invoice.Show();

                //                generateInvoiceNo(); // call generate invoice number method
                //            }
                //            else
                //            {
                //                MessageBox.Show("Unable to save payment record", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                //            }
                //        }
                //        else
                //        {
                //            clearField(); // call clear field method;
                //            return;
                //        }                    
                //    }
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // edit payments
            if (txtInvoiceNo.Text != null)
            {
                if (MessageBox.Show("Do you want to edit thid record ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        var absentPayment = false;
                        if(chk_AbsentPayment.Checked)
                        {
                            absentPayment = true;

                        }else
                        {
                            absentPayment = false;
                        }

                        var payment = new Payment();
                        payment.InvoiceNo = txtInvoiceNo.Text;
                        payment.RegistrationId = txtRegistrationId.Text;
                        payment.StudentName = txtStudentName.Text;
                        payment.CourseId = txtCourseId.Text;
                        payment.CourseName = txtCourseName.Text;
                        payment.LecturerId = txtLectuerId.Text;
                        payment.LectuerName = txtLecturerName.Text;
                        payment.Fee = Convert.ToDecimal(txtFee.Text);
                        payment.Amount = Convert.ToDecimal(txtAmount.Text);
                        payment.Balance = Convert.ToDecimal(txtBalance.Text);
                        payment.PaidDate = datePayment.Value;
                        payment.AbsentPayment = absentPayment;

                        var result = PaymentDataAccess.editPayment(payment);

                        if (result == true)
                        {
                            MessageBox.Show("Payment record has been updated successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            gridRefresh(); // call grid refresh method
                            clearField(); // call clear field method
                        }
                        else
                        {
                            MessageBox.Show("Unable to updated payment record", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    return;
                }
            }
            else 
            {
                MessageBox.Show("Enter invoice number to proceed with edit process","Message",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // delete payments
            if (txtInvoiceNo.Text != null)
            {
                if (MessageBox.Show("Do you want to delete thid record ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        var payment = new Payment();
                        payment.InvoiceNo = txtInvoiceNo.Text;
                        payment.IsRemoved = true;

                        var result = PaymentDataAccess.deletePayment(payment);

                        if (result == true)
                        {
                            MessageBox.Show("Payment record has been deleted successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            gridRefresh(); // call grid refresh method
                            clearField(); // call clear field method
                        }
                        else
                        {
                            MessageBox.Show("Unable to delete payment record ", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Enter invoice no. to proceed with delete process","Message",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            clearField(); // clear field method
        }

        private void txtRegistrationId_KeyDown(object sender, KeyEventArgs e)
        {
            // fill student name and enrolled courses in dropdown
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    var registrationCode = new RegistrationIds();
                    registrationCode.RegistrationId = txtRegistrationId.Text;

                    var record = RegistrationCodesDataAccess.findStudentByRegistrationId(registrationCode);

                    if (record == null)
                    {
                        MessageBox.Show("Registration ID not found. Please check the ID", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        txtStudentName.Text = record.StudentName; // student name
                        gridCourses.DataSource = null;

                        //var source = CourseEnrollmentDataAccess.findCourseByStudentId(record.StudentId).Where(x => x.IsRemoved == false);
                        var source = CourseEnrollmentDataAccess.findCourseByStudentId(record.RegistrationId).Where(x => x.IsRemoved == false);
                        gridCourses.DataSource = source
                             .Select(x => new
                             {
                                 CourseId = x.CourseId,
                                 CourseName = x.CourseName,
                                 LecturerId = x.LecturerId,
                                 LecturerName = x.LecturerName

                             }).ToList();

                        gridCourses.Columns["CourseId"].HeaderText = "Course ID";
                        gridCourses.Columns["CourseName"].HeaderText = "Course Name";
                        gridCourses.Columns["LecturerId"].HeaderText = "Lecturer ID";
                        gridCourses.Columns["LecturerName"].HeaderText = "Lecturer Name";

                        

                        // setting column width
                        gridCourses.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCourseId_KeyDown(object sender, KeyEventArgs e)
        {
            // Display course info
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    var course = new Course();
                    course.RefNo = txtCourseId.Text;

                    var record = CoursesDataAccess.findCourseById(course);
                    if (record == null)
                    {
                        MessageBox.Show("Course ID not found. Please check the Course-ID", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        // display course fee and course name
                        txtCourseName.Text = record.Title;
                        txtFee.Text = record.Fee.ToString();

                        // display lecturer Id and name
                        var lecturer = CourseEnrollmentDataAccess.findCourseByCourseId(txtCourseId.Text);
                        if (lecturer == null)
                        {
                            MessageBox.Show("Course lecturer details not found. Please check the course-ID", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                        else
                        {
                            // display lecturer info
                            txtLectuerId.Text = lecturer.LecturerId;
                            txtLecturerName.Text = lecturer.LecturerName;

                            // find student id
                            var registration = new RegistrationIds();
                            registration.RegistrationId = txtRegistrationId.Text;

                            var studentRecords = RegistrationCodesDataAccess.findStudentByRegistrationId(registration);

                            if (studentRecords == null)
                            {
                                MessageBox.Show("Unable to locate student ID. Please check the registration ID", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            }
                            else
                            {
                                studentId = studentRecords.StudentId;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtAmount_KeyDown(object sender, KeyEventArgs e)
        {
            // find balance
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    // variable declaration
                    decimal fee, amount, balance = 0;

                    fee = Convert.ToDecimal(txtFee.Text);
                    amount = Convert.ToDecimal(txtAmount.Text);

                    balance = amount - fee;

                    if (balance == 0)
                    {
                        txtBalance.Text = "0.00";
                    }
                    else
                    {
                        txtBalance.Text = balance.ToString(); // display balance
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void gridCourses_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // fill course, lecturer fields and find student Id
            try
            {
                // find course info and lecturer info
                txtCourseId.Text = gridCourses.SelectedRows[0].Cells[0].Value.ToString();
                txtCourseName.Text = gridCourses.SelectedRows[0].Cells[1].Value.ToString();
                txtLectuerId.Text = gridCourses.SelectedRows[0].Cells[2].Value.ToString();
                txtLecturerName.Text = gridCourses.SelectedRows[0].Cells[3].Value.ToString();

                // find course fee
                var course = new Course();
                course.RefNo = txtCourseId.Text;

                var record = CoursesDataAccess.findCourseById(course);
                if (record == null)
                {
                    MessageBox.Show("Course ID not found. Please check the Course-ID", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    // display course fee
                    txtFee.Text = record.Fee.ToString();

                    // find student id
                    var registration = new RegistrationIds();
                    registration.RegistrationId = txtRegistrationId.Text;

                    var studentRecords = RegistrationCodesDataAccess.findStudentByRegistrationId(registration);

                    if (studentRecords == null)
                    {
                        MessageBox.Show("Unable to locate student ID. Please check the registration ID", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        studentId = studentRecords.StudentId;
                    }

                    // display last paid month
                    var lastRecord = PaymentDataAccess.getLastRecord(txtRegistrationId.Text, txtCourseId.Text);
                    if (lastRecord == null)
                    {

                    }
                    else 
                    {
                        txt_LastPaidMonth.Text = lastRecord.PaidDate.ToShortDateString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridPayment_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // fill text fields 
            try
            {
                // disable add payment button
                btnSave.Enabled = false;

                txtInvoiceNo.Text = gridPayment.SelectedRows[0].Cells[0].Value.ToString();
                txtRegistrationId.Text = gridPayment.SelectedRows[0].Cells[1].Value.ToString();
                txtStudentName.Text = gridPayment.SelectedRows[0].Cells[2].Value.ToString();
                txtCourseId.Text = gridPayment.SelectedRows[0].Cells[3].Value.ToString();
                txtCourseName.Text = gridPayment.SelectedRows[0].Cells[4].Value.ToString();
                txtLectuerId.Text = gridPayment.SelectedRows[0].Cells[5].Value.ToString();
                txtLecturerName.Text = gridPayment.SelectedRows[0].Cells[6].Value.ToString();
                txtFee.Text = gridPayment.SelectedRows[0].Cells[7].Value.ToString();
                txtAmount.Text = gridPayment.SelectedRows[0].Cells[8].Value.ToString();
                txtBalance.Text = gridPayment.SelectedRows[0].Cells[9].Value.ToString();
                datePayment.Value = Convert.ToDateTime(gridPayment.SelectedRows[0].Cells[10].Value.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed : " + ex.Message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // find students - filter 
                try
                {
                    gridPayment.DataSource = null;
                    gridPayment.DataSource = PaymentDataAccess.filterPayment(txt_Find.Text)
                        .Select(x => new
                        {
                            InvoiceNo = x.InvoiceNo,
                            RegistrationId = x.RegistrationId,
                            StudentName = x.StudentName,
                            CourseId = x.CourseId,
                            CourseName = x.CourseName,
                            LecturerId = x.LecturerId,
                            txtLecturerName = x.LectuerName,
                            Fee = x.Fee,
                            Amount = x.Amount,
                            Balance = x.Balance,
                            PaidDate = x.PaidDate,
                            InvoiceDate = x.Invoicedate,
                            Username = x.Username,
                            Deleted = x.IsRemoved
                        }).ToList();

                    gridPayment.Columns["InvoiceNo"].HeaderText = "Invoice #";
                    gridPayment.Columns["RegistrationId"].HeaderText = "Registration ID";
                    gridPayment.Columns["StudentName"].HeaderText = "Student Name";
                    gridPayment.Columns["CourseId"].HeaderText = "Course ID";
                    gridPayment.Columns["CourseName"].HeaderText = "Course Name";
                    gridPayment.Columns["Fee"].HeaderText = "Course Fee (Rs.)";
                    gridPayment.Columns["Amount"].HeaderText = "Paid Amount (Rs.)";
                    gridPayment.Columns["PaidDate"].HeaderText = "Paid Date";
                    gridPayment.Columns["InvoiceDate"].HeaderText = "Invoice Date";
                    gridPayment.Columns["Username"].HeaderText = "User Name";
                    gridPayment.Columns["Deleted"].HeaderText = "Cancel Payment"; ;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed : " + ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        public void gridRefresh()
        {
            // refresh payment gridview
            try
            {
                gridPayment.DataSource = null;
                var source = PaymentDataAccess.getPayment();

                if (source == null)
                {
                    gridPayment.DataSource = null;
                }
                else
                {
                    gridPayment.DataSource = source
                    .Select(x => new
                    {
                        InvoiceNo = x.InvoiceNo,
                        RegistrationId = x.RegistrationId,
                        StudentName = x.StudentName,
                        CourseId = x.CourseId,
                        CourseName = x.CourseName,
                        LecturerId = x.LecturerId,
                        LecturerName = x.LectuerName,
                        Fee = x.Fee,
                        Amount = x.Amount,
                        Balance = x.Balance,
                        PaidDate = x.PaidDate,
                        InvoiceDate=x.Invoicedate,
                        Username = x.Username,
                        Deleted = x.IsRemoved
                    }).ToList();

                    gridPayment.Columns["InvoiceNo"].HeaderText = "Invoice #";
                    gridPayment.Columns["RegistrationId"].HeaderText = "Registration ID";
                    gridPayment.Columns["StudentName"].HeaderText = "Student Name";
                    gridPayment.Columns["CourseId"].HeaderText = "Course ID";
                    gridPayment.Columns["CourseName"].HeaderText = "Course Name";
                    gridPayment.Columns["LecturerId"].HeaderText = "Lecturer ID";
                    gridPayment.Columns["LecturerName"].HeaderText = "Lecturer Name";
                    gridPayment.Columns["Fee"].HeaderText = "Course Fee (Rs.)";
                    gridPayment.Columns["Amount"].HeaderText = "Paid Amount (Rs.)";
                    gridPayment.Columns["Balance"].HeaderText = "Balance";
                    gridPayment.Columns["PaidDate"].HeaderText = "Paid Month";
                    gridPayment.Columns["InvoiceDate"].HeaderText = "Invoice Date";
                    gridPayment.Columns["Username"].HeaderText = "User Name";
                    gridPayment.Columns["Deleted"].HeaderText = "Canceled Payment";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void clearField()
        {
            // clear fields
            try
            {
                // enable add payment button
                btnSave.Enabled = true;

                txtRegistrationId.Text = "";
                txtStudentName.Text = "";
                txtCourseId.Text = "";
                txtCourseName.Text = "";
                txtLectuerId.Text = "";
                txtLecturerName.Text = "";
                txtFee.Text = "";
                txtAmount.Text = "";
                txtBalance.Text = "";
                txt_LastPaidMonth.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void generateInvoiceNo()
        {
            // generate and show invoice number
            var result = PaymentDataAccess.generateInvoiceId();
            var value = Convert.ToInt32(result.Substring(3)) + 1;

            if (value < 100)
            {
                var num = value.ToString().PadLeft(3, '0');
                var InvoiceNo = "INV" + num;
                txtInvoiceNo.Text = InvoiceNo; // Display invoice number
            }
            else
            {
                var num = value.ToString();
                var InvoiceNo = "INV" + num;
                txtInvoiceNo.Text = InvoiceNo; // Display inovice number
            }
        }
    }
}
