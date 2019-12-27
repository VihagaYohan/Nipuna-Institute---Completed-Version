using Nipuna.CourseEnrollments;
using Nipuna.DataAccess.RegistrationCodes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nipuna.Barcodes
{
    public partial class frm_Barcodes : Form
    {
        public string Role;
        public frm_Barcodes()
        {
            InitializeComponent();
        }

        public frm_Barcodes(string role)
        {
            this.Role = role;
            InitializeComponent();

            // check user role
            if (Role == "Checker")
            {
                MessageBox.Show("Access Denied","Alert",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else 
            {
                return;
            }
        }

        private void frm_Barcordes_Load(object sender, EventArgs e)
        {
            // load all student course registration IDs
            try
            {
                gridBarcode.DataSource = null;
                var source = RegistrationCodesDataAccess.getBarcodes();
                //gridBarcode.DataSource = source
                //    .Select(x => new
                //    {
                //        StudentID = x.StudentId,
                //        StudentName = x.StudentName,
                //        CourseId = x.CourseId,
                //        CourseName = x.CourseName,
                //        RegistrationId = x.RegistrationId,
                //        IssuedDate = x.IssuedDate,
                //        IssuedBy = x.IssuedBy
                //    });

                gridBarcode.DataSource = source;

                gridBarcode.Columns["StudentId"].HeaderText = "Student ID";
                gridBarcode.Columns["StudentName"].HeaderText = "Student Name";
                gridBarcode.Columns["CourseId"].HeaderText = "Course ID";
                gridBarcode.Columns["CourseName"].HeaderText = "Course Name";
                gridBarcode.Columns["RegistrationId"].HeaderText = "Course Registration ID";
                gridBarcode.Columns["IssuedDate"].HeaderText = "Issued Date";
                gridBarcode.Columns["IssuedBy"].HeaderText = "Issued By";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_Find_TextChanged(object sender, EventArgs e)
        {
            // filter registration code
            try
            {
                gridBarcode.DataSource = null;
                var source = RegistrationCodesDataAccess.filterRegistrationId(txt_Find.Text);

                gridBarcode.DataSource = source;

                gridBarcode.Columns["StudentId"].HeaderText = "Student ID";
                gridBarcode.Columns["StudentName"].HeaderText = "Student Name";
                gridBarcode.Columns["CourseId"].HeaderText = "Course ID";
                gridBarcode.Columns["CourseName"].HeaderText = "Course Name";
                gridBarcode.Columns["RegistrationId"].HeaderText = "Course Registration ID";
                gridBarcode.Columns["IssuedDate"].HeaderText = "Issued Date";
                gridBarcode.Columns["IssuedBy"].HeaderText = "Issued By";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridBarcode_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // field text fields
            try
            {
                txt_StudentId.Text = gridBarcode.SelectedRows[0].Cells[1].Value.ToString();
                txt_StudentName.Text = gridBarcode.SelectedRows[0].Cells[2].Value.ToString();
                txt_RegistrationId.Text = gridBarcode.SelectedRows[0].Cells[5].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Proceed_Click(object sender, EventArgs e)
        {
            // open print box
            try
            {
                var print = new frm_CourseRegistrationCode(txt_RegistrationId.Text);
                print.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            // clear fields
            try
            {
                txt_StudentId.Text = "";
                txt_StudentName.Text = "";
                txt_RegistrationId.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
