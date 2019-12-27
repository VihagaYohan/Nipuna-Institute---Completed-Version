using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nipuna.DataAccess;
using Nipuna.Model;

namespace Nipuna.Users
{
    public partial class frm_UserRegistration : Form
    {
        public string Role;
        public frm_UserRegistration()
        {
            InitializeComponent();
        }

        public frm_UserRegistration(string role) 
        {
            this.Role = role;
            InitializeComponent();

            // enable controls based on user role
            if (Role == "Administrator")
            {
                panel_Button.Enabled = true;
            }
            else 
            {
                btn_Reset.Enabled = false;
            }
        }

        private void frm_UserRegistration_Load(object sender, EventArgs e)
        {
            try
            {
                gridRefresh(); // call grid refresh method
                btn_Reset.Enabled = false; // disable user account reset button

                metroTabControl1.SelectedTab = metroTabPage1;

                cmbType.DataSource = UserTypeDataAccess.getAllUserRoles();
                cmbType.ValueMember = "Id";
                cmbType.DisplayMember = "Type";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed : " + ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var users = new User();
                users.SurName = txtSurname.Text;
                users.FirstName = txtFirstname.Text;
                users.LastName = txtLastname.Text;
                users.Nic = txtNic.Text;
                users.ContactNo = txtContact.Text;
                users.Password = txtPassword.Text;
                users.Role = cmbType.Text;

                string first = txtFirstname.Text.Trim().Substring(0,3);
                string last = txtLastname.Text.Trim().Substring(0, 2);

                var today = DateTime.Now.ToShortDateString();
                var milisecond = DateTime.Now.Millisecond.ToString();

                var username = first + last + milisecond; // user name

                users.UserName = username; // user name
                users.DateCreated = Convert.ToDateTime(today); // user account created date

                var result = UserDataAccess.addUser(users);

                if (result = true)
                {
                    MessageBox.Show("User has been added succesfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gridRefresh(); // call grid refresh method
                    clearFields(); // call clear field method
                }
                else
                {
                    MessageBox.Show("Unable to add user", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed : " + ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var user = new User();
                user.UserName = gridUsers.SelectedRows[0].Cells[0].Value.ToString();
                user.SurName = txtSurname.Text;
                user.FirstName = txtFirstname.Text;
                user.LastName = txtLastname.Text;
                user.Nic = txtNic.Text;
                user.ContactNo = txtContact.Text;
                user.Role = cmbType.Text;

                UserDataAccess.updateUser(user);
                MessageBox.Show("User profile has been updated successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gridRefresh(); // call grid refresh method
                clearFields(); // call clear fields method
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to remove this record ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                try
                {
                    var user = new User();
                    user.UserName = gridUsers.SelectedRows[0].Cells[0].Value.ToString();
                    user.IsRemoved = true; // set IsRemoved to true

                    UserDataAccess.deleteUser(user);
                    MessageBox.Show("User profile has been deleted successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gridRefresh(); // call grid refresh method
                    clearFields(); // call clear fields method
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

        public void gridRefresh()
        {
            try
            {
                // grid in user management tab
                gridUsers.DataSource = null;
                gridUsers.DataSource = UserDataAccess.getAllUsers()
                    .Select(x => new
                    {
                        Username = x.UserName,
                        Surname  = x.SurName,
                        Firstname = x.FirstName,
                        Lastname = x.LastName,
                        Nic = x.Nic,
                        Contact  = x.ContactNo,
                        Role = x.Role,
                        Date = x.DateCreated,
                        IsRemoved = x.IsRemoved
                    }).ToList();

                gridUsers.Columns["Username"].HeaderText = "User Name";
                gridUsers.Columns["SurName"].HeaderText = "Surname";
                gridUsers.Columns["FirstName"].HeaderText = "First Name";
                gridUsers.Columns["LastName"].HeaderText = "Last Name";
                gridUsers.Columns["Nic"].HeaderText = "NIC #";
                gridUsers.Columns["Contact"].HeaderText = "Contact #";
                gridUsers.Columns["Role"].HeaderText = "User Role";
                gridUsers.Columns["Date"].HeaderText = "Date Created";
                gridUsers.Columns["IsRemoved"].HeaderText = "Inactive ";

                // grid in user reset tab
                var source = UserDataAccess.getAllUsers();
                gridUserAccount.DataSource = null;
                gridUserAccount.DataSource = source
                    .Select(x => new
                    {
                        Username = x.UserName,
                        Surname = x.SurName,
                        Firstname = x.FirstName,
                        Lastname = x.LastName,
                        Nic = x.Nic,
                        Contact = x.ContactNo,
                        Role = x.Role,
                        Date = x.DateCreated,
                        IsRemoved = x.IsRemoved
                    }).ToList();

                gridUserAccount.Columns["Username"].HeaderText = "User Name";
                gridUserAccount.Columns["SurName"].HeaderText = "Surname";
                gridUserAccount.Columns["FirstName"].HeaderText = "First Name";
                gridUserAccount.Columns["LastName"].HeaderText = "Last Name";
                gridUserAccount.Columns["Nic"].HeaderText = "NIC #";
                gridUserAccount.Columns["Contact"].HeaderText = "Contact #";
                gridUserAccount.Columns["Role"].HeaderText = "User Role";
                gridUserAccount.Columns["Date"].HeaderText = "Date Created";
                gridUserAccount.Columns["IsRemoved"].HeaderText = "Inactive ";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void clearFields()
        {
            try
            {
                // clear fields
                txtFind.Text = "";
                txtSurname.Text = "";
                txtFirstname.Text = "";
                txtLastname.Text = "";
                txtNic.Text = "";
                txtContact.Text = "";
                txtPassword.Text = "";
                txtConfimedPassword.Text = "";
                cmbType.Text = "";

                gridRefresh(); // call grid refresh method
                grpPassoword.Enabled = true; // enable password groupbox
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtConfimedPassword_TextChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("");
            try
            {
                if (txtPassword.Text != txtConfimedPassword.Text)
                {
                    lblPasswordStatus.Visible = true;
                    lblPasswordStatus.Text = "Password does not match";
                    lblPasswordStatus.ForeColor = Color.Red;
                }
                else
                {
                    btnAdd.Enabled = true;
                    lblPasswordStatus.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridUsers_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                grpPassoword.Enabled = false; // disable password group box

                txtSurname.Text = gridUsers.SelectedRows[0].Cells[1].Value.ToString();
                txtFirstname.Text = gridUsers.SelectedRows[0].Cells[2].Value.ToString();
                txtLastname.Text = gridUsers.SelectedRows[0].Cells[3].Value.ToString();
                txtNic.Text = gridUsers.SelectedRows[0].Cells[4].Value.ToString();
                txtContact.Text = gridUsers.SelectedRows[0].Cells[5].Value.ToString();
                cmbType.Text = gridUsers.SelectedRows[0].Cells[6].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            try
            {
                var user = new User();
                user.UserName = txtUserName.Text;
                user.Password = "Temp123";

                UserDataAccess.resetUserPassword(user);
                MessageBox.Show("User account has been reset successfully","Message",MessageBoxButtons.OK,MessageBoxIcon.Information);

                // Refresh user account grid
                gridUserAccount.DataSource = null;
                gridUserAccount.DataSource = UserDataAccess.getAllUsers()
                    .Select(x => new
                    {
                        Username = x.UserName,
                        Surname = x.SurName,
                        Firstname = x.FirstName,
                        Lastname = x.LastName,
                        Nic = x.Nic,
                        Contact = x.ContactNo,
                        Role = x.Role,
                        Date = x.DateCreated,
                        IsRemoved = x.IsRemoved
                    }).ToList();

                gridUserAccount.Columns["Username"].HeaderText = "User Name";
                gridUserAccount.Columns["SurName"].HeaderText = "Surname";
                gridUserAccount.Columns["FirstName"].HeaderText = "First Name";
                gridUserAccount.Columns["LastName"].HeaderText = "Last Name";
                gridUserAccount.Columns["Nic"].HeaderText = "NIC #";
                gridUserAccount.Columns["Contact"].HeaderText = "Contact #";
                gridUserAccount.Columns["Role"].HeaderText = "User Role";
                gridUserAccount.Columns["Date"].HeaderText = "Date Created";
                gridUserAccount.Columns["IsRemoved"].HeaderText = "Inactive ";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txtUserName.Text = "";
            gridUserAccount.DataSource = null;
        }

        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    var user = new User();
                    user.UserName = txtUserName.Text;

                    var result = UserDataAccess.findByUserId(user);

                    if (result == null)
                    {
                        MessageBox.Show("User account not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else 
                    {
                        // Refresh user account grid
                        btn_Reset.Enabled = true;

                        gridUserAccount.DataSource = null;
                        var source = UserDataAccess.getAllUsers();

                        gridUserAccount.DataSource = source
                            .Select(x => new
                            {
                                Username = x.UserName,
                                Surname = x.SurName,
                                Firstname = x.FirstName,
                                Lastname = x.LastName,
                                Nic = x.Nic,
                                Contact = x.ContactNo,
                                Role = x.Role,
                                Date = x.DateCreated,
                                IsRemoved = x.IsRemoved
                            }).ToList();

                        gridUserAccount.Columns["Username"].HeaderText = "User Name";
                        gridUserAccount.Columns["SurName"].HeaderText = "Surname";
                        gridUserAccount.Columns["FirstName"].HeaderText = "First Name";
                        gridUserAccount.Columns["LastName"].HeaderText = "Last Name";
                        gridUserAccount.Columns["Nic"].HeaderText = "NIC #";
                        gridUserAccount.Columns["Contact"].HeaderText = "Contact #";
                        gridUserAccount.Columns["Role"].HeaderText = "User Role";
                        gridUserAccount.Columns["Date"].HeaderText = "Date Created";
                        gridUserAccount.Columns["IsRemoved"].HeaderText = "Inactive ";
                    } 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            // finding user profile
            try
            {
                var searchValue = txtUserName.Text;

                var source = UserDataAccess.filterUsers(searchValue);
                gridUserAccount.DataSource = null;
                gridUserAccount.DataSource = source
                    .Select(x => new
                    {
                        Username = x.UserName,
                        Surname = x.SurName,
                        Firstname = x.FirstName,
                        Lastname = x.LastName,
                        Nic = x.Nic,
                        Contact = x.ContactNo,
                        Role = x.Role,
                        Date = x.DateCreated,
                        IsRemoved = x.IsRemoved
                    }).ToList();

                gridUserAccount.Columns["Username"].HeaderText = "User Name";
                gridUserAccount.Columns["SurName"].HeaderText = "Surname";
                gridUserAccount.Columns["FirstName"].HeaderText = "First Name";
                gridUserAccount.Columns["LastName"].HeaderText = "Last Name";
                gridUserAccount.Columns["Nic"].HeaderText = "NIC #";
                gridUserAccount.Columns["Contact"].HeaderText = "Contact #";
                gridUserAccount.Columns["Role"].HeaderText = "User Role";
                gridUserAccount.Columns["Date"].HeaderText = "Date Created";
                gridUserAccount.Columns["IsRemoved"].HeaderText = "Inactive ";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed : " + ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            // find user profile
            try
            {
                // finding user profile
                try
                {
                    var searchValue = txtFind.Text;

                    var source = UserDataAccess.filterUsers(searchValue);
                    gridUsers.DataSource = null;
                    gridUsers.DataSource = source
                        .Select(x => new
                        {
                            Username = x.UserName,
                            Surname = x.SurName,
                            Firstname = x.FirstName,
                            Lastname = x.LastName,
                            Nic = x.Nic,
                            Contact = x.ContactNo,
                            Role = x.Role,
                            Date = x.DateCreated,
                            IsRemoved = x.IsRemoved
                        }).ToList();

                    gridUsers.Columns["Username"].HeaderText = "User Name";
                    gridUsers.Columns["SurName"].HeaderText = "Surname";
                    gridUsers.Columns["FirstName"].HeaderText = "First Name";
                    gridUsers.Columns["LastName"].HeaderText = "Last Name";
                    gridUsers.Columns["Nic"].HeaderText = "NIC #";
                    gridUsers.Columns["Contact"].HeaderText = "Contact #";
                    gridUsers.Columns["Role"].HeaderText = "User Role";
                    gridUsers.Columns["Date"].HeaderText = "Date Created";
                    gridUsers.Columns["IsRemoved"].HeaderText = "Inactive ";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Change_Click(object sender, EventArgs e)
        {
            // change user account password
            try
            {
                var user = new User();
                user.UserName = txt_Username.Text;
                user.Password = txt_ConfirmedPassword.Text;

                var result = UserDataAccess.UpdatePassword(user);
                if (result == true)
                {
                    MessageBox.Show("User account password has been updated succesfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else 
                {
                    MessageBox.Show("Unable to update user account password. Please contact admin","Message",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                }

            }
            catch (Exception ex) 
            {
                MessageBox.Show("Failed : " + ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btn_ClearFields_Click(object sender, EventArgs e)
        {

        }

    }
}
