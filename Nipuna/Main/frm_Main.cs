using Nipuna.Courses;
using Nipuna.Lecturers;
using Nipuna.StudentPaymnet;
using Nipuna.Students;
using Nipuna.Users;
using Nipuna.Barcodes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Nipuna.Reports;
using Nipuna.CourseEnrollments;
using Nipuna.StudentAttendance;

namespace Nipuna.Main
{
    public partial class frm_Main : Form
    {
        public string Role, Username;
        public frm_Main()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public frm_Main(string user, string role)
        {
            this.Role = role;
            this.Username = user;

            InitializeComponent();
        }

        private void frm_Main_Load(object sender, EventArgs e)
        {
            lblUsername.Text = Username;
            lblUserRole.Text = Role;
            lblDate.Text = DateTime.Now.ToShortDateString();
        }

        private void pic_Menu_Click(object sender, EventArgs e)
        {
            // Left panel - menu animation
            if (panel_Left.Width == 235)
            {
                panel_Left.Width = 52;
            }
            else
            {
                panel_Left.Width = 235;
            }
        }

        private void btn_Students_Click(object sender, EventArgs e)
        {
            // Show student form within panel
            panel_Holder.Controls.Clear();
            var student = new frm_Students(Role);
            student.TopLevel = false;
            panel_Holder.Controls.Add(student);
            student.Dock = DockStyle.Fill;
            student.Show();
        }

        private void btn_Lecturers_Click(object sender, EventArgs e)
        {
            // Show lecturers form within panel
            panel_Holder.Controls.Clear();
            var lecturers = new frm_Lecturers(Role);
            lecturers.TopLevel = false;
            panel_Holder.Controls.Add(lecturers);
            lecturers.Dock = DockStyle.Fill;
            lecturers.Show();
        }

        private void btn_Courses_Click(object sender, EventArgs e)
        {
            // Show lecturers form within panel
            panel_Holder.Controls.Clear();
            var lecturers = new frm_Courses(Role);
            lecturers.TopLevel = false;
            panel_Holder.Controls.Add(lecturers);
            lecturers.Dock = DockStyle.Fill;
            lecturers.Show();
        }

        private void btn_AssignCourses_Click(object sender, EventArgs e)
        {
            // Show payments form within panel
            panel_Holder.Controls.Clear();
            var assignCourses = new frm_assignCourses(Role);
            assignCourses.TopLevel = false;
            panel_Holder.Controls.Add(assignCourses);
            assignCourses.Dock = DockStyle.Fill;
            assignCourses.Show();
        }

        private void btn_Reports_Click(object sender, EventArgs e)
        {
            // show report form

            if (Role != "Administrator")
            {
                MessageBox.Show("Access denied", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool isOpen = false;
                foreach (Form f in Application.OpenForms)
                {
                    if (f.Text == "frm_Reports")
                    {
                        isOpen = true;
                        f.BringToFront();
                        break;
                    }
                }
                if (isOpen == false)
                {
                    var report = new frm_Reports();
                    report.Show();
                }
            }
        }

        private void btn_Users_Click(object sender, EventArgs e)
        {
            // Show users form within panel
            panel_Holder.Controls.Clear();
            var users = new frm_UserRegistration(Role);
            users.TopLevel = false;
            panel_Holder.Controls.Add(users);
            users.Dock = DockStyle.Fill;
            users.Show();
        }

        private void btn_CourseRegistration_Click(object sender, EventArgs e)
        {
            // show course registration form
            panel_Holder.Controls.Clear();
            var courseRegistration = new frm_CourseEnrollment(Role);
            courseRegistration.TopLevel = false;
            panel_Holder.Controls.Add(courseRegistration);
            courseRegistration.Dock = DockStyle.Fill;
            courseRegistration.Show();
        }

        private void btn_Payment_Click(object sender, EventArgs e)
        {
            // show payment form
            if (Role == "Checker")
            {
                MessageBox.Show("Access Denied", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else 
            {
                panel_Holder.Controls.Clear();
                var payment = new frm_StudentPayment(Role,Username);
                payment.TopLevel = false;
                panel_Holder.Controls.Add(payment);
                payment.Dock = DockStyle.Fill;
                payment.Show();
            }
        }

        private void btn_Barcode_Click(object sender, EventArgs e)
        {
            // show barcode form
            panel_Holder.Controls.Clear();
            var barcode = new frm_Barcodes();
            barcode.TopLevel = false;
            panel_Holder.Controls.Add(barcode);
            barcode.Dock = DockStyle.Fill;
            barcode.Show();
        }

        private void pic_Close_Click(object sender, EventArgs e)
        {
            // close application
            if (MetroFramework.MetroMessageBox.Show(this, "Do you want to exit the application?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
            // maximize form
            this.WindowState = FormWindowState.Maximized;
        }

        private void pic_Resize_Click(object sender, EventArgs e)
        {
            // resize form
            this.WindowState = FormWindowState.Normal;
        }

        private void pic_Minimize_Click(object sender, EventArgs e)
        {
            // minimize form
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel_Header_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle,0x112,0xf012,0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // show attendance form
            if (Role == "Checker")
            {
                MessageBox.Show("Access Denied", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                panel_Holder.Controls.Clear();
                var attendance = new frm_Attendance();
                attendance.TopLevel = false;
                panel_Holder.Controls.Add(attendance);
                attendance.Dock = DockStyle.Fill;
                attendance.Show();
            }
        }


    }
}
