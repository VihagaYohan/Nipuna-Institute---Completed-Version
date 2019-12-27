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
using Nipuna.DataAccess.Courses;

namespace Nipuna.Courses
{
    public partial class frm_Courses : Form
    {
        public string CourseID, Role;
        public frm_Courses()
        {
            InitializeComponent();
        }

        public frm_Courses(string role)
        {
            InitializeComponent();

            this.Role = role; // Job role
        }

        private void frm_Courses_Load(object sender, EventArgs e)
        {
            try
            {
                gridRefresh(); // call grid refresh method

                // enable controls based on job role
                if (Role == "Checker")
                {
                    panel_Buttons.Enabled = false;
                }
                else if (Role == "Cashier")
                {
                    btnEdit.Enabled = false;
                    btnDelete.Enabled = false;
                }
                else
                {
                    //metroTabControl1.SelectedTab = tab_AllCourses;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // add new course
            try
            {
                var course = new Course();
                course.Title = txtTitle.Text;
                course.Fee = Convert.ToDecimal(txtFee.Text);

                var id = txtTitle.Text.Trim().Substring(0, 3);
                var miliseconds = DateTime.Now.Millisecond.ToString();

                id = miliseconds + id;

                course.RefNo = id; // course id

                var result = CoursesDataAccess.addCourses(course);

                if (result == true)
                {
                    MessageBox.Show("Record has been added successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gridRefresh(); // call grid refresh method
                    clearFields(); // call clear field method
                }
                else
                {
                    MessageBox.Show("Unable to add record", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //private void btnEdit_Click(object sender, EventArgs e)
        //{
        //    // edit course data
        //    if (MessageBox.Show("Do you want to edit thid record ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        //    {
        //        try
        //        {
        //            var course = new Course();
        //            course.RefNo = CourseID;
        //            course.Title = txtTitle.Text;
        //            course.Fee = Convert.ToDecimal(txtFee.Text);

        //            CoursesDataAccess.editCourse(course);
        //            MessageBox.Show("Record has been updated successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            gridRefresh(); // call grid refresh method
        //            clearFields(); // call clear field method
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show("Failed : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //    }
        //    else
        //    {
        //        return;
        //    }
        //}

        //private void btnDelete_Click(object sender, EventArgs e)
        //{
        //    // delete course data
        //    if (MessageBox.Show("Do you want to delete thid record ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        //    {
        //        try
        //        {
        //            var course = new Course();
        //            course.RefNo = CourseID;
        //            course.IsRemoved = true;

        //            CoursesDataAccess.deleteCourse(course);
        //            MessageBox.Show("Record has been deleted successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            gridRefresh(); // call grid refresh method
        //            clearFields(); // call clear field method
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show("Failed : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //    }
        //    else
        //    {
        //        return;
        //    }
        //}

        //private void btnCancel_Click(object sender, EventArgs e)
        //{
        //    clearFields(); // call clear field method
        //}

        private void gridAllCourses_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            
        }

        public void gridRefresh()
        {
            // refresh grid
            try
            {
                // grid all courses
                gridCourses.DataSource = null;
                gridCourses.DataSource = CoursesDataAccess.getCourses()
                    .Select(x => new
                    {
                        RefNo = x.RefNo,
                        Title = x.Title,
                        Fee = x.Fee,
                        isRemoved = x.IsRemoved
                    }).ToList();

                gridCourses.Columns["RefNo"].HeaderText = "Course ID";
                gridCourses.Columns["Title"].HeaderText = "Course Name";
                gridCourses.Columns["Fee"].HeaderText = "Course Fee (Rs.)";
                gridCourses.Columns["isRemoved"].HeaderText = "Inactive";

                // grid course
                gridCourses.DataSource = null;
                gridCourses.DataSource = CoursesDataAccess.getCourses()
                    .Select(x => new
                    {
                        RefNo = x.RefNo,
                        Title = x.Title,
                        Fee = x.Fee,
                        isRemoved = x.IsRemoved
                    }).ToList();

                gridCourses.Columns["RefNo"].HeaderText = "Course ID";
                gridCourses.Columns["Title"].HeaderText = "Course Name";
                gridCourses.Columns["Fee"].HeaderText = "Course Fee (Rs.)";
                gridCourses.Columns["isRemoved"].HeaderText = "Inactive";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void clearFields()
        {
            // clear fields
            try
            {
                txtTitle.Text = "";
                txtFee.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            // add new course
            try
            {
                var course = new Course();
                course.Title = txtTitle.Text;
                course.Fee = Convert.ToDecimal(txtFee.Text);

                var id = txtTitle.Text.Trim().Substring(0, 3);
                var miliseconds = DateTime.Now.Millisecond.ToString();

                id = miliseconds + id;

                course.RefNo = id; // course id

                var result = CoursesDataAccess.addCourses(course);

                if (result == true)
                {
                    MessageBox.Show("Record has been added successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gridRefresh(); // call grid refresh method
                    clearFields(); // call clear field method
                }
                else
                {
                    MessageBox.Show("Unable to add record", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridCourses_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // fill fields
            try
            {
                CourseID = gridCourses.SelectedRows[0].Cells[0].Value.ToString();
                txtTitle.Text = gridCourses.SelectedRows[0].Cells[1].Value.ToString();
                txtFee.Text = gridCourses.SelectedRows[0].Cells[2].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtFind_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                gridCourses.DataSource = null;
                var source = CoursesDataAccess.filterCourses(txtFind.Text);
                gridCourses.DataSource = source
                    .Select(x => new
                    {
                        RefNo = x.RefNo,
                        Title = x.Title,
                        Fee = x.Fee,
                        isRemoved = x.IsRemoved
                    }).ToList();

                gridCourses.Columns["RefNo"].HeaderText = "Course ID";
                gridCourses.Columns["Title"].HeaderText = "Course Name";
                gridCourses.Columns["Fee"].HeaderText = "Course Fee (Rs.)";
                gridCourses.Columns["isRemoved"].HeaderText = "Inactive";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            // edit course data
            if (MessageBox.Show("Do you want to edit thid record ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    var course = new Course();
                    course.RefNo = CourseID;
                    course.Title = txtTitle.Text;
                    course.Fee = Convert.ToDecimal(txtFee.Text);

                    CoursesDataAccess.editCourse(course);
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
            // delete course data
            if (txtTitle.Text != "") 
            {
                if (MessageBox.Show("Do you want to delete thid record ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        var course = new Course();
                        course.RefNo = CourseID;
                        course.IsRemoved = true;

                        CoursesDataAccess.deleteCourse(course);
                        MessageBox.Show("Record has been deleted successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            else
            {
                MessageBox.Show("Please select a course","Message",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            clearFields(); // call clear field method
        }
    }
}
