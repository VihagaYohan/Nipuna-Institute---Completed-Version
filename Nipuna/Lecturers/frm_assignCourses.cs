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
using Nipuna.DataAccess.LecturersCourses;
using Nipuna.DataAccess.Lecturers;
using Nipuna.DataAccess.Courses;

namespace Nipuna.Lecturers
{
    public partial class frm_assignCourses : Form
    {
        public string recordId, Role, LecturerId, LecturerName;
        public frm_assignCourses()
        {
            InitializeComponent();
        }

        public frm_assignCourses(string role)
        {
            InitializeComponent();
            this.Role = role;
        }

        public frm_assignCourses(string lecturerId, string lecturerName, string role)
        {
            InitializeComponent();
            this.LecturerId = lecturerId;
            this.LecturerName = lecturerName;
            this.Role = role;
        }

        private void frm_assignCourses_Load(object sender, EventArgs e)
        {
            try
            {
                gridCourseAssignments.DataSource = null;
                gridRefresh(); // call grid refresh method

                // enable controls based on job role
                if (Role == "Checker")
                {
                    panel_Buttons.Enabled = false;

                    txtLecturerId.Text = LecturerId;
                    txtLecturerName.Text = LecturerName;

                    DisplayCourses(); // call display course method
                    showLecturers(); // call show lecturers method
                }
                else if (Role == "Cashier")
                {
                    btnEdit.Enabled = false;
                    btnDelete.Enabled = false;
                    DisplayCourses(); // call display course method
                    showLecturers(); // call show lecturers method
                }
                else
                {
                    panel_Buttons.Enabled = true;
                    DisplayCourses(); // call display course method
                    showLecturers(); // call show lecturers method
                }

                // show lecturer id and name
                txtLecturerId.Text = LecturerId;
                txtLecturerName.Text = LecturerName;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // assign courses 
            if (txtLecturerId.Text == "" || txtLecturerName.Text == "" || txtCourseId.Text == "" || txtCourseName.Text == "")
            {
                MessageBox.Show("Please check the fields", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                try
                {
                    var assign = new LecturerCourses();
                    assign.LecturerId = txtLecturerId.Text;
                    assign.LecturerName = txtLecturerName.Text;
                    assign.CourseId = txtCourseId.Text;
                    assign.CourseName = txtCourseName.Text;

                    var result = LecturerCoursesDataAccess.assignCourse(assign);

                    if (result == true)
                    {
                        MessageBox.Show("Lecturer has been added successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        gridRefresh(); // call grid refresh method
                        clearFileds(); // call clear field method
                    }
                    else
                    {
                        MessageBox.Show("Unable to add lecturer", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed : " + ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                } 
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // edit lecturer course assign data
            if (MessageBox.Show("Do you want to update this record ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    var assign = new LecturerCourses();
                    assign.Id = Convert.ToInt32(recordId);
                    assign.LecturerId = txtLecturerId.Text;
                    assign.LecturerName = txtLecturerName.Text;
                    assign.CourseId = txtCourseId.Text;
                    assign.CourseName = txtCourseName.Text;

                    var result = LecturerCoursesDataAccess.edit(assign);

                    if (result == true)
                    {
                        MessageBox.Show("Data have been updated sucessfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        gridRefresh(); // call grid refresh method
                        clearFileds(); // call clear field method
                    }
                    else
                    {
                        MessageBox.Show("Unable to update data", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete this record ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    var assign = new LecturerCourses();
                    assign.Id = Convert.ToInt32(recordId);

                    var result = LecturerCoursesDataAccess.delete(assign);

                    if (result == true)
                    {
                        MessageBox.Show("Record has been removed successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        gridRefresh(); // call grid refresh method
                        clearFileds(); // call clear field method
                    }
                    else
                    {
                        MessageBox.Show("Unable to delete record", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            clearFileds(); // call clear fields method
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            // filter datagrid
            try
            {
                gridCourseAssignments.DataSource = null;
                 var source = gridCourseAssignments.DataSource = LecturerCoursesDataAccess.filter(txtFind.Text)
                    .Select(x => new
                    {
                        IndexNo = x.Id,
                        LecturerId = x.LecturerId,
                        LecturerName = x.LecturerName,
                        CourseId = x.CourseId,
                        CourseName = x.CourseName
                    }).ToList();

                gridCourseAssignments.DataSource = null;
                gridCourseAssignments.DataSource = source;

                gridCourseAssignments.Columns["IndexNo"].HeaderText = "Index #";
                gridCourseAssignments.Columns["LecturerId"].HeaderText = "Lecturer ID";
                gridCourseAssignments.Columns["LecturerName"].HeaderText = "Lecturer Name";
                gridCourseAssignments.Columns["CourseId"].HeaderText = "Course ID";
                gridCourseAssignments.Columns["CourseName"].HeaderText = "Course Name";

                // setting grid column size
                gridCourseAssignments.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                gridCourseAssignments.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                gridCourseAssignments.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtLecturerId_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    var lecturer = new Lecturer();
                    lecturer.LecturerId = txtLecturerId.Text;

                    var record = LecturerDataAccess.findLecturerById(lecturer);
                    if (record == null)
                    {
                        MessageBox.Show("Unable to locate lecturer. Please check lecturer-ID", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        txtLecturerName.Text = record.FirstName + " " + record.LastName;
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed : " + ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void txtCourseId_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    var course = new Course();
                    course.RefNo = txtCourseId.Text;

                    var record = CoursesDataAccess.findCourseById(course);
                    if (record == null)
                    {
                        MessageBox.Show("Unable to locate course. Please check course-ID", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        txtCourseName.Text = record.Title;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed : " + ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void gridRegistration_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                recordId = gridCourseAssignments.SelectedRows[0].Cells[0].Value.ToString();
                txtLecturerId.Text = gridCourseAssignments.SelectedRows[0].Cells[1].Value.ToString();
                txtLecturerName.Text = gridCourseAssignments.SelectedRows[0].Cells[2].Value.ToString();
                txtCourseId.Text = gridCourseAssignments.SelectedRows[0].Cells[3].Value.ToString();
                txtCourseName.Text = gridCourseAssignments.SelectedRows[0].Cells[4].Value.ToString();

                metroTabControl1.SelectedTab = tab_Manage;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed : " + ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void gridCourse_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                // shows course id and course name in field
                txtCourseId.Text = gridCourse.SelectedRows[0].Cells[0].Value.ToString();
                txtCourseName.Text = gridCourse.SelectedRows[0].Cells[1].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txtFindLecturer_TextChanged(object sender, EventArgs e)
        {
            findLecturers(); // call show lecturers method
        }
        private void gridLecturer_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // select lecturer row and fill the lecturer id and name
            try
            {
                var lecturerId = gridLecturer.SelectedRows[0].Cells[0].Value.ToString();
                var firstname = gridLecturer.SelectedRows[0].Cells[2].Value.ToString();
                var lastname = gridLecturer.SelectedRows[0].Cells[3].Value.ToString();

                var fullName = firstname + " " + lastname;

                txtLecturerId.Text = lecturerId;
                txtLecturerName.Text = fullName;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void DisplayCourses() 
        {
            try
            {
                var source = CoursesDataAccess.getCourses()
                    .Select(x => new
                    {
                        CourseId = x.RefNo,
                        Title = x.Title,
                        IsRemoved = x.IsRemoved
                    }).Where(y => y.IsRemoved == false).ToList();

                gridCourse.DataSource = null;
                gridCourse.DataSource = source;

                gridCourse.Columns["CourseId"].HeaderText = "Course ID";
                gridCourse.Columns["Title"].HeaderText = "Course Name";
                gridCourse.Columns["IsRemoved"].HeaderText = "Course Removed";

                // set column widith
                gridCourse.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void gridRefresh()
        {
            try
            {
                var source = LecturerCoursesDataAccess.getCourses()
                    .Select(x => new
                    {
                        IndexNo = x.Id,
                        LecturerId = x.LecturerId,
                        LecturerName = x.LecturerName,
                        CourseId = x.CourseId,
                        CourseName = x.CourseName
                    }).ToList();

                gridCourseAssignments.DataSource = null;
                gridCourseAssignments.DataSource = source;

                gridCourseAssignments.Columns["IndexNo"].HeaderText = "Index #";
                gridCourseAssignments.Columns["LecturerId"].HeaderText = "Lecturer ID";
                gridCourseAssignments.Columns["LecturerName"].HeaderText = "Lecturer Name";
                gridCourseAssignments.Columns["CourseId"].HeaderText = "Course ID";
                gridCourseAssignments.Columns["CourseName"].HeaderText = "Course Name";

                // setting grid column size
                gridCourseAssignments.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                gridCourseAssignments.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                gridCourseAssignments.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void clearFileds()
        {
            try
            {
                txtLecturerId.Text = "";
                txtLecturerName.Text = "";
                txtCourseId.Text = "";
                txtCourseName.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void findLecturers() 
        {
            // filter lecturers based on search keyword
            try
            {
                var searchValue = txtFindLecturer.Text;
                var source = LecturerDataAccess.filterLecturers(searchValue);
                gridLecturer.DataSource = source
                    .Select(x => new
                    {
                        LecturerId = x.LecturerId,
                        Surname = x.SurName,
                        Firstname = x.FirstName,
                        Lastname = x.LastName,
                        Nic = x.Nic,
                        Email = x.Email,
                        Mobile = x.Mobile,
                        Address = x.Address,
                        IsRemoved = x.IsRemoved
                    }).Where(x => x.IsRemoved == false).ToList();

                gridLecturer.Columns["LecturerId"].HeaderText = "Lecturer ID";
                gridLecturer.Columns["Surname"].HeaderText = "Surname";
                gridLecturer.Columns["Firstname"].HeaderText = "Firstname";
                gridLecturer.Columns["Lastname"].HeaderText = "Lastname";
                gridLecturer.Columns["Nic"].HeaderText = "NIC #";
                gridLecturer.Columns["Email"].HeaderText = "E-mail";
                gridLecturer.Columns["Mobile"].HeaderText = "Mobile";
                gridLecturer.Columns["Address"].HeaderText = "Address";
                gridLecturer.Columns["IsRemoved"].HeaderText = "Status";

                gridLecturer.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                gridLecturer.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                gridLecturer.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                gridLecturer.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                gridLecturer.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void showLecturers() 
        {
            // show all lecturers
            try
            {
                var searchValue = txtFindLecturer.Text;
                var source = LecturerDataAccess.getLecturers();
                gridLecturer.DataSource = source
                    .Select(x => new
                    {
                        LecturerId = x.LecturerId,
                        Surname = x.SurName,
                        Firstname = x.FirstName,
                        Lastname = x.LastName,
                        Nic = x.Nic,
                        Email = x.Email,
                        Mobile = x.Mobile,
                        Address = x.Address,
                        IsRemoved = x.IsRemoved
                    }).Where(x => x.IsRemoved == false).ToList();

                gridLecturer.Columns["LecturerId"].HeaderText = "Lecturer ID";
                gridLecturer.Columns["Surname"].HeaderText = "Surname";
                gridLecturer.Columns["Firstname"].HeaderText = "Firstname";
                gridLecturer.Columns["Lastname"].HeaderText = "Lastname";
                gridLecturer.Columns["Nic"].HeaderText = "NIC #";
                gridLecturer.Columns["Email"].HeaderText = "E-mail";
                gridLecturer.Columns["Mobile"].HeaderText = "Mobile";
                gridLecturer.Columns["Address"].HeaderText = "Address";
                gridLecturer.Columns["IsRemoved"].HeaderText = "Status";

                gridLecturer.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                gridLecturer.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                gridLecturer.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                gridLecturer.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                gridLecturer.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // hide assign forms
            //var assign = new frm_assignCourses();
            //assign.Hide();
            this.Close();
        }
    }
}
