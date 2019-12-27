using System;
using System.Collections.Generic;
using System.Globalization;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nipuna.Model;
using Nipuna.DataAccess;
using Nipuna.DataAccess.Students;
using Nipuna.CourseEnrollments;

namespace Nipuna.Students
{
    public partial class frm_Students : Form
    {
        public string StudentId, Role;

        public frm_Students()
        {
            InitializeComponent();
        }
        public frm_Students(string role)
        {
            InitializeComponent();
            this.Role = role; // job role
        }

        private void frm_Students_Load(object sender, EventArgs e)
        {
            try
            {
                gridAllStudent.DataSource = null;
                gridRefresh(); // call grid refresh method

                // enable controls based on job role
                if (Role == "Checker")
                {
                    metroTabControl1.SelectedTab = metroTabPage1;
                    metroTabPage2.Hide();
                    panel_Buttons.Enabled = false;
                }
                else if (Role == "Cashier")
                {
                    metroTabControl1.SelectedTab = metroTabPage1;
                    btnEdit.Enabled = false;
                    btnDelete.Enabled = false;
                }
                else
                {
                    metroTabControl1.SelectedTab = metroTabPage1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // adding student
            // check whether NIC textbox is empty
            if (!string.IsNullOrWhiteSpace(txtNic.Text))
            {
                // find excisting student record
                var Nic = txtNic.Text;
                var record = StudentDataAccess.findStudentByNic(Nic);

                if (record == null)
                {
                    registerStudent(); // call register student method
                    gridRefresh();
                }   
                else
                {
                    var students = StudentDataAccess.getStudentsByNic(Nic);
                    gridStudent.DataSource = null;
                    gridStudent.DataSource = students
                        .Select(x => new
                        {
                            StudentId = x.RefNo,
                            StudentName = x.Name,
                            Nic = x.Nic
                        }).ToList();

                    gridStudent.Columns["StudentId"].HeaderText = "Student ID";
                    gridStudent.Columns["StudentName"].HeaderText = "Student Name";
                    gridStudent.Columns["Nic"].HeaderText = "NIC #";

                    // setting grid column width
                    gridStudent.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                    // Display message box
                    MessageBox.Show("Excisting student", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            else
            {
                registerStudent(); // call register student method
                gridRefresh(); // call grid refresh method
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Edit student records
            if (MessageBox.Show("Do you want to edit this record ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    var student = new Student();
                    student.RefNo = lbl_StudentID.Text;
                    student.Name = txtName.Text;
                    student.Nic = txtNic.Text;
                    student.Dob = dateDob.Value;
                    student.School = txtSchool.Text;
                    student.Address = txtAddress.Text;
                    student.Mobile = txtMobile.Text;
                    student.Email = txtEmail.Text;
                    student.Type = cmbType.Text;
                    student.Pname = txtPName.Text;
                    student.Pmobile = txtPMobile.Text;
                    student.Plandline = txtPLandline.Text;

                    StudentDataAccess.editStudent(student);

                    MessageBox.Show("Record has been updated successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gridRefresh(); // call grid refresh method
                    clearFields(); // call clear field method
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
            // Delete student records
            if (MessageBox.Show("Do you want to delete this record ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    var student = new Student();
                    student.RefNo = lbl_StudentID.Text;
                    student.IsRemoved = true;

                    StudentDataAccess.deleteStudent(student);

                    MessageBox.Show("Record has been Removed successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gridRefresh(); // call grid refresh method
                    clearFields(); // call clear field method
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
            clearFields(); // call clear field method
        }

        private void txt_Find_TextChanged(object sender, EventArgs e)
        {
            // find students - filter 
            try
            {
                gridAllStudent.DataSource = null;
                var source = StudentDataAccess.filterStudent(txt_Find.Text);
                gridAllStudent.DataSource = source
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

                gridAllStudent.Columns["StudentID"].HeaderText = "Student ID";
                gridAllStudent.Columns["Name"].HeaderText = "Student Name";
                gridAllStudent.Columns["NIC"].HeaderText = "NIC #";
                gridAllStudent.Columns["DOB"].HeaderText = "Date Of Birth";
                gridAllStudent.Columns["School"].HeaderText = "School";
                gridAllStudent.Columns["Home"].HeaderText = "Student Address";
                gridAllStudent.Columns["Mobile"].HeaderText = "Mobile #";
                gridAllStudent.Columns["Email"].HeaderText = "E-mail";
                gridAllStudent.Columns["Type"].HeaderText = "Contact Person Type";
                gridAllStudent.Columns["PersonName"].HeaderText = "Person Name";
                gridAllStudent.Columns["PersonMobile"].HeaderText = "Mobile #";
                gridAllStudent.Columns["PersonLandline"].HeaderText = "Landline #";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridAllStudent_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                //grp_StudentID.Visible = true; // visible student ID label/groupbox

                metroTabControl1.SelectedTab = metroTabPage2; // Activate edit tab

                btnAdd.Enabled = false; // disable student add button

                // Fill fields
                lbl_StudentID.Text = gridAllStudent.SelectedRows[0].Cells[0].Value.ToString();
                txtName.Text = gridAllStudent.SelectedRows[0].Cells[1].Value.ToString();
                txtNic.Text = gridAllStudent.SelectedRows[0].Cells[2].Value.ToString();
                dateDob.Text = gridAllStudent.SelectedRows[0].Cells[3].Value.ToString();
                txtSchool.Text = gridAllStudent.SelectedRows[0].Cells[4].Value.ToString();
                txtAddress.Text = gridAllStudent.SelectedRows[0].Cells[5].Value.ToString();
                txtMobile.Text = gridAllStudent.SelectedRows[0].Cells[6].Value.ToString();
                txtEmail.Text = gridAllStudent.SelectedRows[0].Cells[7].Value.ToString();
                cmbType.Text = gridAllStudent.SelectedRows[0].Cells[8].Value.ToString();
                txtPName.Text = gridAllStudent.SelectedRows[0].Cells[9].Value.ToString();
                txtPMobile.Text = gridAllStudent.SelectedRows[0].Cells[10].Value.ToString();
                txtPLandline.Text = gridAllStudent.SelectedRows[0].Cells[11].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void registerStudent()
        {
            // add new student record
            try
            {
                if (string.IsNullOrWhiteSpace(txtNic.Text)||
                    string.IsNullOrWhiteSpace(txtSchool.Text) ||
                    string.IsNullOrWhiteSpace(txtAddress.Text)||
                    string.IsNullOrWhiteSpace(txtMobile.Text)||
                    string.IsNullOrWhiteSpace(txtPLandline.Text))
                {
                    MessageBox.Show("Please add student information","Message", MessageBoxButtons.OK);
                }
                else 
                {
                    var student = new Student();
                    student.Name = txtName.Text;
                    student.Nic = txtNic.Text;
                    student.Dob = Convert.ToDateTime(dateDob.Value.ToShortDateString());
                    student.School = txtSchool.Text;
                    student.Address = txtAddress.Text;
                    student.Mobile = txtMobile.Text;
                    student.Email = txtEmail.Text;
                    student.Type = cmbType.Text;
                    student.Pname = txtPName.Text;
                    student.Pmobile = txtPMobile.Text;
                    student.Plandline = txtPLandline.Text;
                    student.Registereddate = Convert.ToDateTime(DateTime.Today.ToShortDateString());

                    // Student ID
                    var month = DateTime.Now.Month.ToString(); // current month
                    var year = DateTime.Now.Year.ToString(); // current year
                    var day = DateTime.Now.Day.ToString(); // current day
                    var hour = DateTime.Now.Hour.ToString(); // current hour
                    var minutes = DateTime.Now.Minute.ToString(); // current minutes
                    var miliseconds = DateTime.Now.Millisecond.ToString(); // current miliseconds

                    StudentId = year + month + day + hour + minutes + miliseconds;

                    student.RefNo = StudentId;

                    var result = StudentDataAccess.addStudent(student);

                    if (result == true)
                    {
                        MessageBox.Show("New student has been added sucessfully", "Messasge", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        gridRefresh(); // call grid refresh method
                        clearFields(); // call clear field method

                        // show student course enrollment form
                        if (MessageBox.Show("Do you want to register student for a subject ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            var courseEnrollment = new frm_CourseEnrollment(Role,student.Name,StudentId);
                            courseEnrollment.Show();
                        }
                        else
                        {
                            return;
                        }

                    }
                    else
                    {
                        MessageBox.Show("Unable to proceed with registration", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void gridRefresh()
        {
            // refresh grid
            try
            {
                gridAllStudent.DataSource = null;
                var source = StudentDataAccess.getSutdents();
                gridAllStudent.DataSource = source
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
                        PersonLandline = x.Plandline,
                        RegisteredDate = x.Registereddate,
                        isRemove = x.IsRemoved
                    }).Where(x => x.isRemove != true).ToList();

                gridAllStudent.Columns["StudentID"].HeaderText = "Student ID";
                gridAllStudent.Columns["Name"].HeaderText = "Student Name";
                gridAllStudent.Columns["NIC"].HeaderText = "NIC #";
                gridAllStudent.Columns["DOB"].HeaderText = "Date Of Birth";
                gridAllStudent.Columns["School"].HeaderText = "School";
                gridAllStudent.Columns["Home"].HeaderText = "Student Address";
                gridAllStudent.Columns["Mobile"].HeaderText = "Mobile #";
                gridAllStudent.Columns["Email"].HeaderText = "E-mail";
                gridAllStudent.Columns["Type"].HeaderText = "Contact Person Type";
                gridAllStudent.Columns["PersonName"].HeaderText = "Person Name";
                gridAllStudent.Columns["PersonMobile"].HeaderText = "Mobile #";
                gridAllStudent.Columns["PersonLandline"].HeaderText = "Landline #";
                gridAllStudent.Columns["RegisteredDate"].HeaderText = "Registered Date";
                gridAllStudent.Columns["isRemove"].HeaderText = "Inactive";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void clearFields()
        {
            // clear fields
            txtName.Text = "";
            txtNic.Text = "";
            dateDob.Text = "";
            txtSchool.Text = "";
            txtAddress.Text = "";
            txtMobile.Text = "";
            txtEmail.Text = "";
            cmbType.Text = "";
            txtPName.Text = "";
            txtPMobile.Text = "";
            txtPLandline.Text = "";

            btnAdd.Enabled = true;

            gridStudent.DataSource = null; // empty grid student
            
        }

        private void metroTabPage2_Click(object sender, EventArgs e)
        {

        }

    }
}
