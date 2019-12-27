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
using Nipuna.DataAccess.Enrollements;
using Nipuna.DataAccess.Students;
using Nipuna.DataAccess.Courses;
using Nipuna.DataAccess.LecturersCourses;
using Nipuna.DataAccess.RegistrationCodes;

namespace Nipuna.CourseEnrollments
{
    public partial class frm_CourseEnrollment : Form
    {
        public string Role;
        public string Username;
        public string RegistrationBarcodeId;

        public string StudentName, Id;

        public frm_CourseEnrollment()
        {
            InitializeComponent();
        }
        public frm_CourseEnrollment(string role)
        {
            this.Role = role;
            InitializeComponent();
        }

        public frm_CourseEnrollment(string role, string studentName, string id)
        {
            this.Role = role;
            this.StudentName = studentName;
            this.Id = id;
            InitializeComponent();
        }

        public frm_CourseEnrollment(string role, string username)
        {
            InitializeComponent();
            this.Role = role;
            this.Username = username;
            InitializeComponent();
        }

        private void frm_CourseEnrollment_Load(object sender, EventArgs e)
        {
            try
            {
                gridRegistration.ScrollBars = ScrollBars.Both;
                // activate all registrations tab
                metroTabControl1.SelectedTab = tab_AllRegistrations;

                txtStudentId.Text = Id;
                txtStudentName.Text = StudentName;

                gridRefresh(); // call grid refresh method
                showStudents(); // call show students method

                // enables controls based on user role
                if (Role == "Checker")
                {
                    metroTabControl1.SelectedTab = tab_AllRegistrations; // activate all registrations tab
                    panel_Buttons.Enabled = false;
                }
                else if (Role == "Cashier")
                {
                    metroTabControl1.SelectedTab = tab_AllRegistrations; // activate all registrations tab
                    btnEdit.Enabled = false;
                    //btnDelete.Enabled = false;
                }
                else
                {
                    metroTabControl1.SelectedTab = tab_AllRegistrations; // activate all registrations tab
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed : " + ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // add new course registration
            try
            {
                // Course registration barcode
                var year = DateTime.Now.Year.ToString();
                year = year.Substring(2);
                var month = DateTime.Now.Month.ToString();
                var date = DateTime.Now.Day.ToString();
                var hour = DateTime.Now.Hour.ToString();
                var minute = DateTime.Now.Minute.ToString();
                var miliseconds = DateTime.Now.Millisecond.ToString();

                var RegistrationId = year+month+date+hour+minute+miliseconds; // registration id

                var enrollment = new CourseEnrollment();
                enrollment.RegisteredDate = Convert.ToDateTime(dateRegister.Value.ToShortDateString());
                enrollment.StudentId = txtStudentId.Text;
                enrollment.RegistrationId = RegistrationId;
                enrollment.StudentName = txtStudentName.Text;
                enrollment.CourseId = txtCourseId.Text;
                enrollment.CourseName = txtCourseName.Text;
                enrollment.LecturerId = txtLecturerId.Text;
                enrollment.LecturerName = txtLecturerName.Text;

                var result = CourseEnrollmentDataAccess.addEnrollment(enrollment);

                if (result == true)
                {
                    MessageBox.Show("Course registration has been completed successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gridRefresh(); // call grid refresh method

                    var barcodeInfo = new RegistrationIds();
                    barcodeInfo.StudentId = txtStudentId.Text;
                    barcodeInfo.StudentName = txtStudentName.Text;
                    barcodeInfo.CourseId = txtCourseId.Text;
                    barcodeInfo.CourseName = txtCourseName.Text;
                    barcodeInfo.RegistrationId = RegistrationId;
                    barcodeInfo.IssuedDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                    barcodeInfo.IssuedBy = Username;

                    var output = RegistrationCodesDataAccess.add(barcodeInfo);

                    if (output == true)
                    {
                        // show barcode form

                        var Barcode = new frm_CourseRegistrationCode(RegistrationId);
                        Barcode.Show();

                        clearField(); // call clear field method
                    }
                    else
                    {
                        MessageBox.Show("Unable to record registraion data", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }
                else 
                {
                    MessageBox.Show("Course registration has been failed", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                


            //    var record = CourseEnrollmentDataAccess.findLastEntry(txtCourseId.Text);
            //    if (record == null)
            //    {
            //        var lastEntry = 1;
            //        lastEntry += 1; // adding 1 to last entry
            //        var courseId = txtCourseId.Text;

            //        RegistrationBarcodeId = courseId + lastEntry; // registration Id
            //    }
            //    else 
            //    {
            //        var lastEntry = record.Id;
            //        lastEntry += 1; // adding 1 to last entry
            //        var courseId = txtCourseId.Text;

            //        RegistrationBarcodeId = courseId + lastEntry; // registration Id
            //    }
                

            //    var enrollment = new CourseEnrollment();
            //    enrollment.RegisteredDate = Convert.ToDateTime(dateRegister.Value.ToShortDateString());
            //    enrollment.StudentId = txtStudentId.Text;
            //    enrollment.RegistrationId = RegistrationBarcodeId;
            //    enrollment.StudentName = txtStudentName.Text;
            //    enrollment.CourseId = txtCourseId.Text;
            //    enrollment.CourseName = txtCourseName.Text;
            //    enrollment.LecturerId = txtLecturerId.Text;
            //    enrollment.LecturerName = txtLecturerName.Text;

            //    var result = CourseEnrollmentDataAccess.addEnrollment(enrollment);

            //    if (result == true)
            //    {
            //        MessageBox.Show("Course registration has been completed successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        gridRefresh(); // call grid refresh method

            //        var barcodeInfo = new RegistrationIds();
            //        barcodeInfo.StudentId = txtStudentId.Text;
            //        barcodeInfo.StudentName = txtStudentName.Text;
            //        barcodeInfo.CourseId = txtCourseId.Text;
            //        barcodeInfo.CourseName = txtCourseName.Text;
            //        barcodeInfo.RegistrationId = RegistrationBarcodeId;
            //        barcodeInfo.IssuedDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            //        barcodeInfo.IssuedBy = Username;

            //        var output = RegistrationCodesDataAccess.add(barcodeInfo);

            //        if (output == true)
            //        {
            //            // show barcode form

            //            var Barcode = new frm_CourseRegistrationCode(RegistrationBarcodeId);
            //            Barcode.Show();

            //            clearField(); // call clear field method
            //        }
            //        else
            //        {
            //            MessageBox.Show("Unable to record registraion data", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("Course registration has been failed", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            //    }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed : " + ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // edit registration info
            if (MessageBox.Show("Do you want to update this record ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    var enrollment = new CourseEnrollment();
                    enrollment.Id = Convert.ToInt32(gridRegistration.SelectedRows[0].Cells[0].Value.ToString());
                    enrollment.RegistrationId = txtStudentId.Text;
                    enrollment.StudentName = txtStudentName.Text;
                    enrollment.CourseId = txtCourseId.Text;
                    enrollment.CourseName = txtCourseName.Text;
                    enrollment.LecturerId = txtLecturerId.Text;
                    enrollment.LecturerName = txtLecturerName.Text;
                    enrollment.RegisteredDate = Convert.ToDateTime(dateRegister.Value);

                    var result = CourseEnrollmentDataAccess.edit(enrollment);

                    if (result == true)
                    {
                        MessageBox.Show("Record has been updated successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        gridRefresh(); // call grid refresh method
                        clearField(); // call clear field method
                    }
                    else
                    {
                        MessageBox.Show("Unable to update record", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed : " + ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                return;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // delete registration info
            if (MessageBox.Show("Do you want to delete this record ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    var enrollment = new CourseEnrollment();
                    enrollment.Id = Convert.ToInt32(gridRegistration.SelectedRows[0].Cells[0].Value.ToString());

                    var result = CourseEnrollmentDataAccess.delete(enrollment);

                    if (result == true)
                    {
                        MessageBox.Show("Record has been deleted successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        gridRefresh(); // call grid refresh method
                        clearField(); // call clear field method
                    }
                    else
                    {
                        MessageBox.Show("Unable to delete record", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed : " + ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                return;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            clearField(); // call clear field method
        }

        private void txtStudentId_KeyDown(object sender, KeyEventArgs e)
        {
            // find student name
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    var student = new Student();
                    student.RefNo = txtStudentId.Text;
                    var record = StudentDataAccess.findStudent(student);


                    if (record.RefNo == null)
                    {
                        MessageBox.Show("Student-ID not found", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else if (record.IsRemoved == true)
                    {
                        // Detect inactive student id
                        MessageBox.Show("Inactive Student-ID found", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        // fill student name textfield
                        txtStudentName.Text = record.Name;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed : " + ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txtCourseId_KeyDown(object sender, KeyEventArgs e)
        {
            // find course name
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    var course = new Course();
                    course.RefNo = txtCourseId.Text;

                    var record = CoursesDataAccess.findCourseById(course);


                    if (record.RefNo == null)
                    {
                        MessageBox.Show("Course-ID not found", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else if (record.IsRemoved == true)
                    {
                        // Detect inactive student id
                        MessageBox.Show("Inactive Course-ID found", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        // fill course name textfield
                        txtCourseName.Text = record.Title;

                        gridLecturer.DataSource = null;
                        var source = LecturerCoursesDataAccess.findLectuerersByCourseId(txtCourseId.Text);

                        gridLecturer.DataSource = source.Select(x => new
                        {
                            LecturerId = x.LecturerId,
                            LecturerName = x.LecturerName
                        }).ToList();

                        gridLecturer.Columns["LecturerId"].HeaderText = "Lecturer ID";
                        gridLecturer.Columns["LecturerName"].HeaderText = "Lecturer Name";

                        // setting data grid column width
                        gridLecturer.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed : " + ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void gridLecturer_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // fill lecturer name
            try
            {
                txtLecturerId.Text = gridLecturer.SelectedRows[0].Cells[0].Value.ToString();
                txtLecturerName.Text = gridLecturer.SelectedRows[0].Cells[1].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed : " + ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void gridRegistration_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // fill fields
            try
            {
                // activate manage tab
                metroTabControl1.SelectedTab = tab_Registration;

                txtStudentId.Text = gridRegistration.SelectedRows[0].Cells[2].Value.ToString();
                txtStudentName.Text = gridRegistration.SelectedRows[0].Cells[3].Value.ToString();
                txtCourseId.Text = gridRegistration.SelectedRows[0].Cells[4].Value.ToString();
                txtCourseName.Text = gridRegistration.SelectedRows[0].Cells[5].Value.ToString();
                txtLecturerId.Text = gridRegistration.SelectedRows[0].Cells[6].Value.ToString();
                txtLecturerName.Text = gridRegistration.SelectedRows[0].Cells[7].Value.ToString();

                // fill lecturer grid
                gridLecturer.DataSource = null;
                var source = LecturerCoursesDataAccess.findLectuerersByCourseId(txtCourseId.Text);

                gridLecturer.DataSource = source.Select(x => new
                {
                    LecturerId = x.LecturerId,
                    LecturerName = x.LecturerName
                }).ToList();

                gridLecturer.Columns["LecturerId"].HeaderText = "Lecturer ID";
                gridLecturer.Columns["LecturerName"].HeaderText = "Lecturer Name";

                // setting data grid column width
                gridLecturer.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed : " + ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            // filter fields
            try
            {
                gridRegistration.DataSource = null;
                gridRegistration.DataSource = CourseEnrollmentDataAccess.filter(txtFind.Text)
                    .Select(x => new
                    {
                        Id = x.Id,
                        RegisteredDate = x.RegisteredDate,
                        StudentID = x.RegistrationId,
                        StudentName = x.StudentName,
                        CourseID = x.CourseId,
                        CourseName = x.CourseName,
                        IsRemoved = x.IsRemoved,
                    }).ToList();

                gridRegistration.Columns["Id"].HeaderText = "ID";
                gridRegistration.Columns["StudentID"].HeaderText = "Student ID";
                gridRegistration.Columns["StudentName"].HeaderText = "Student Name";
                gridRegistration.Columns["CourseID"].HeaderText = "Course ID";
                gridRegistration.Columns["CourseName"].HeaderText = "Course Name";
                gridRegistration.Columns["IsRemoved"].HeaderText = "Inactive";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed : " + ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void gridRefresh()
        {
            // refresh gridview
            try
            {
                gridRegistration.DataSource = null;
                gridRegistration.DataSource = CourseEnrollmentDataAccess.getEnrollements()
                    .Select(x => new
                    {
                        Id = x.Id,
                        RegisteredDate = x.RegisteredDate,
                        StudentID = x.RegistrationId,
                        StudentName = x.StudentName,
                        CourseID = x.CourseId,
                        CourseName = x.CourseName,
                        LecturerId = x.LecturerId,
                        LecturerName = x.LecturerName,
                    }).ToList();

                gridRegistration.Columns["Id"].HeaderText = "ID";
                gridRegistration.Columns["StudentID"].HeaderText = "Student ID";
                gridRegistration.Columns["StudentName"].HeaderText = "Student Name";
                gridRegistration.Columns["CourseID"].HeaderText = "Course ID";
                gridRegistration.Columns["CourseName"].HeaderText = "Course Name";
                gridRegistration.Columns["LecturerId"].HeaderText = "Lecturer ID";
                gridRegistration.Columns["LecturerName"].HeaderText = "Lecturer Name";

                // setting datagrid column width
                gridRegistration.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                gridRegistration.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                gridRegistration.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                gridRegistration.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed : " + ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void clearField()
        {
            // clear fields
            try
            {
                txtStudentId.Text = "";
                txtStudentName.Text = "";
                txtCourseId.Text = "";
                txtCourseName.Text = "";
                txtLecturerId.Text = "";
                txtLecturerName.Text = "";
                txtFind.Text = "";
                gridLecturer.DataSource = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed : " + ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void showStudents() 
        {
            // show all the students registered with institute - not registered for courses
            try
            {
                var source = StudentDataAccess.getSutdents();
                gridStudents.DataSource = source
                    .Select(x => new
                    {
                        StudentID = x.RefNo,
                        Name = x.Name,
                        NIC = x.Nic,
                        DOB = x.Dob,
                        School = x.School,
                        Home = x.Address,
                        Mobile = x.Mobile,
                        Email = x.Email,
                        Type = x.Type,
                        PersonName = x.Pname,
                        PersonMobile = x.Pmobile,
                        PersonLandline = x.Plandline
                    }).ToList();

                gridStudents.Columns["StudentID"].HeaderText = "Student ID";
                gridStudents.Columns["Name"].HeaderText = "Student Name";
                gridStudents.Columns["NIC"].HeaderText = "NIC #";
                gridStudents.Columns["DOB"].HeaderText = "Date Of Birth";
                gridStudents.Columns["School"].HeaderText = "School";
                gridStudents.Columns["Home"].HeaderText = "Student Address";
                gridStudents.Columns["Mobile"].HeaderText = "Mobile #";
                gridStudents.Columns["Email"].HeaderText = "E-mail";
                gridStudents.Columns["Type"].HeaderText = "Contact Person Type";
                gridStudents.Columns["PersonName"].HeaderText = "Person Name";
                gridStudents.Columns["PersonMobile"].HeaderText = "Mobile #";
                gridStudents.Columns["PersonLandline"].HeaderText = "Landline #";

                // setting column size
                gridStudents.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                gridStudents.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                gridStudents.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                gridStudents.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                gridStudents.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                gridStudents.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                gridStudents.Columns[10].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed : " + ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_FindStudents_TextChanged(object sender, EventArgs e)
        {
            // find student
            try
            {
                var searchValue = txt_FindStudents.Text;
                var source = StudentDataAccess.filterStudent(searchValue);
                gridStudents.DataSource = source
                    .Select(x => new
                    {
                        StudentID = x.RefNo,
                        Name = x.Name,
                        NIC = x.Nic,
                        DOB = x.Dob,
                        School = x.School,
                        Home = x.Address,
                        Mobile = x.Mobile,
                        Email = x.Email,
                        Type = x.Type,
                        PersonName = x.Pname,
                        PersonMobile = x.Pmobile,
                        PersonLandline = x.Plandline
                    }).ToList();

                gridStudents.Columns["StudentID"].HeaderText = "Student ID";
                gridStudents.Columns["Name"].HeaderText = "Student Name";
                gridStudents.Columns["NIC"].HeaderText = "NIC #";
                gridStudents.Columns["DOB"].HeaderText = "Date Of Birth";
                gridStudents.Columns["School"].HeaderText = "School";
                gridStudents.Columns["Home"].HeaderText = "Student Address";
                gridStudents.Columns["Mobile"].HeaderText = "Mobile #";
                gridStudents.Columns["Email"].HeaderText = "E-mail";
                gridStudents.Columns["Type"].HeaderText = "Contact Person Type";
                gridStudents.Columns["PersonName"].HeaderText = "Person Name";
                gridStudents.Columns["PersonMobile"].HeaderText = "Mobile #";
                gridStudents.Columns["PersonLandline"].HeaderText = "Landline #";

                // setting column size
                gridStudents.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                gridStudents.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                gridStudents.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                gridStudents.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                gridStudents.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                gridStudents.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                gridStudents.Columns[10].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed : " + ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridStudents_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // fill student id and name
            try
            {
                var studentId = gridStudents.SelectedRows[0].Cells[0].Value.ToString();
                var studentName = gridStudents.SelectedRows[0].Cells[1].Value.ToString();

                txtStudentId.Text = studentId;
                txtStudentName.Text = studentName;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed : " + ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Delete_1_Click(object sender, EventArgs e)
        {
            this.Close(); // close course registration form
        }

        private void btn_Delete_2_Click(object sender, EventArgs e)
        {
            this.Close(); // close course registration form
        }


    }
}
