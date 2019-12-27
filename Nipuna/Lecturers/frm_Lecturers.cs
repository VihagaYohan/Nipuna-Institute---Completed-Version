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
using Nipuna.DataAccess.Lecturers;

namespace Nipuna.Lecturers
{
    public partial class frm_Lecturers : Form
    {
        // Lecturer Id
        public string LecturerId, Role;

        public frm_Lecturers()
        {
            InitializeComponent();
        }

        public frm_Lecturers(string role)
        {
            InitializeComponent();
            this.Role = role;
        }

        private void frm_Lecturers_Load(object sender, EventArgs e)
        {
            try
            {
                gridLecturers.DataSource = null;
                gridRefresh(); // call grid refresh method

                // enable controls based on job role
                if (Role == "Checker")
                {
                    panel_Button.Enabled = false;
                }
                else if (Role == "Cashier")
                {
                    btnEdit.Enabled = false;
                    btnDelete.Enabled = false;
                }
                else
                {
                    panel_Button.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // add new lecturer
            try
            {
                var lecturer = new Lecturer();
                lecturer.SurName = txtSurName.Text;
                lecturer.FirstName = txtFirstName.Text;
                lecturer.LastName = txtLastName.Text;
                lecturer.Nic = txtNic.Text;
                lecturer.Mobile = txtMobile.Text;
                lecturer.Email = txtEmail.Text;
                lecturer.Address = txtAddress.Text;

                var miliseconds = DateTime.Now.Millisecond.ToString();
                var first = txtFirstName.Text.Trim().Substring(0, 3);

                var lecId = miliseconds + first;

                lecturer.LecturerId = lecId; // lecturer id

                var result = LecturerDataAccess.addLecturer(lecturer);

                if (result == true)
                {
                    MessageBox.Show("Lecturer has been added successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gridRefresh(); // call grid refresh method
                    clearField(); // call clear field method

                    // assign courses
                    if (MessageBox.Show("Do you want to assign courses for lecturer ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        var fullname = lecturer.FirstName + " " + lecturer.LastName;
                        var assign = new frm_assignCourses(lecId,fullname,Role);

                        var record = assign.ShowDialog();
                        if (record == DialogResult.OK)
                        {
                            assign.Show();
                        }
                        else
                        {

                        }
                    }
                    else 
                    {
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // edit lecturer data
            if (MessageBox.Show("Do you want to edit this record ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    var lecturer = new Lecturer();
                    lecturer.LecturerId = LecturerId;
                    lecturer.SurName = txtSurName.Text;
                    lecturer.FirstName = txtFirstName.Text;
                    lecturer.LastName = txtLastName.Text;
                    lecturer.Nic = txtNic.Text;
                    lecturer.Address = txtAddress.Text;
                    lecturer.Mobile = txtMobile.Text;
                    lecturer.Email = txtEmail.Text;

                    LecturerDataAccess.editLecturer(lecturer);

                    MessageBox.Show("Record has been updated successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gridRefresh(); // call grid refresh method
                    clearField(); // call clear field method
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
            // edit lecturer data
            if (MessageBox.Show("Do you want to delete this record ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    var lecturer = new Lecturer();
                    lecturer.LecturerId = LecturerId;
                    lecturer.IsRemoved = true;

                    LecturerDataAccess.deleteLecturer(lecturer);

                    MessageBox.Show("Record has been deleted successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gridRefresh(); // call grid refresh method
                    clearField(); // call clear field method
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
            clearField(); // call clear field
        }

        private void gridLecturers_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // fill fields
            try
            {
                LecturerId = gridLecturers.SelectedRows[0].Cells[0].Value.ToString();
                txtSurName.Text = gridLecturers.SelectedRows[0].Cells[1].Value.ToString();
                txtFirstName.Text = gridLecturers.SelectedRows[0].Cells[2].Value.ToString();
                txtLastName.Text = gridLecturers.SelectedRows[0].Cells[3].Value.ToString();
                txtNic.Text = gridLecturers.SelectedRows[0].Cells[4].Value.ToString();
                txtMobile.Text = gridLecturers.SelectedRows[0].Cells[5].Value.ToString();
                txtEmail.Text = gridLecturers.SelectedRows[0].Cells[6].Value.ToString();
                txtAddress.Text = gridLecturers.SelectedRows[0].Cells[7].Value.ToString();

                // disable add button
                btnAdd.Enabled = false;
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
                gridLecturers.DataSource = null;
                gridLecturers.DataSource = LecturerDataAccess.getLecturers()
                    .Select(x => new
                    {
                        LecturerID = x.LecturerId,
                        Surname = x.SurName,
                        Firstname = x.FirstName,
                        Lastname = x.LastName,
                        Nic = x.Nic,
                        Mobile = x.Mobile,
                        Email = x.Email,
                        Address = x.Address,
                        isRemoved = x.IsRemoved
                    }).ToList();

                gridLecturers.Columns["LecturerID"].HeaderText = "Lecturer ID";
                gridLecturers.Columns["Surname"].HeaderText = "Surname";
                gridLecturers.Columns["Firstname"].HeaderText = "First Name";
                gridLecturers.Columns["Lastname"].HeaderText = "Last Name";
                gridLecturers.Columns["Nic"].HeaderText = "NIC #";
                gridLecturers.Columns["Mobile"].HeaderText = "Mobile #";
                gridLecturers.Columns["Email"].HeaderText = "E-mail";
                gridLecturers.Columns["Address"].HeaderText = "Address";
                gridLecturers.Columns["isRemoved"].HeaderText = "Inactive";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void clearField()
        {
            // clear filds
            try
            {
                txtSurName.Text = "";
                txtFirstName.Text = "";
                txtLastName.Text = "";
                txtNic.Text = "";
                txtMobile.Text = "";
                txtEmail.Text = "";
                txtAddress.Text = "";

                btnAdd.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            // filter datagrid
            try
            {
                gridLecturers.DataSource = null;
                gridLecturers.DataSource = LecturerDataAccess.filterLecturers(txtFind.Text)
                    .Select(x => new
                    {
                        LecturerID = x.LecturerId,
                        Surname = x.SurName,
                        Firstname = x.FirstName,
                        Lastname = x.LastName,
                        Nic = x.Nic,
                        Mobile = x.Mobile,
                        Email = x.Email,
                        Address = x.Address,
                        isRemoved = x.IsRemoved
                    }).ToList();

                gridLecturers.Columns["LecturerID"].HeaderText = "Lecturer ID";
                gridLecturers.Columns["Surname"].HeaderText = "Surname";
                gridLecturers.Columns["Firstname"].HeaderText = "First Name";
                gridLecturers.Columns["Lastname"].HeaderText = "Last Name";
                gridLecturers.Columns["Nic"].HeaderText = "NIC #";
                gridLecturers.Columns["Mobile"].HeaderText = "Mobile #";
                gridLecturers.Columns["Email"].HeaderText = "E-mail";
                gridLecturers.Columns["Address"].HeaderText = "Address";
                gridLecturers.Columns["isRemoved"].HeaderText = "Inactive"; ;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
