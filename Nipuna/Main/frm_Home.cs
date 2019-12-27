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
using System.Threading;
using Nipuna.Students;
using Nipuna.Lecturers;
using Nipuna.Courses;
using Nipuna.StudentPaymnet;
using Nipuna.Reports;
using Nipuna.Users;

namespace Nipuna.Main
{
    public partial class frm_Home : Form
    {
        public string Role, Username;
        public frm_Home()
        {
            InitializeComponent();
        }

        public frm_Home(string user, string role)
        {
            this.Role = role;
            this.Username = user;

            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void frm_Home_Load(object sender, EventArgs e)
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

        private void panel_Header_Paint(object sender, PaintEventArgs e)
        {
            //ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0x012, 0);
        }

        private void panel_Header_MouseDown(object sender, MouseEventArgs e)
        {
            //ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pic_Close_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "Do you want to exit ?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
            // Maximize window
            this.WindowState = FormWindowState.Maximized;
        }

        private void pic_Resize_Click(object sender, EventArgs e)
        {
            // Resize
            this.WindowState = FormWindowState.Normal;
        }

        private void pic_Minimize_Click(object sender, EventArgs e)
        {
            // Minimize window
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_Students_Click(object sender, EventArgs e)
        {
            // Show student form within panel
            //panel_Holder.Controls.Clear();
            //var student = new frm_Students();
            //student.TopLevel = false;
            //panel_Holder.Controls.Add(student);
            //student.Dock = DockStyle.Fill;
            //student.Show();
            panel_Holder.Controls.Clear();
            var student = new frm_Students();
            student.TopLevel = false;
            panel_Holder.Controls.Add(student);
            student.Dock = DockStyle.Fill;
            student.Show();
        }

        private void btn_Lecturers_Click(object sender, EventArgs e)
        {
            // Show lecturers form within panel
            panel_Holder.Controls.Clear();
            var lecturers = new frm_Lecturers();
            lecturers.TopLevel = false;
            panel_Holder.Controls.Add(lecturers);
            lecturers.Dock = DockStyle.Fill;
            lecturers.Show();
        }

        private void btn_Courses_Click(object sender, EventArgs e)
        {
            // Show lecturers form within panel
            panel_Holder.Controls.Clear();
            var lecturers = new frm_Lecturers();
            lecturers.TopLevel = false;
            panel_Holder.Controls.Add(lecturers);
            lecturers.Dock = DockStyle.Fill;
            lecturers.Show();
        }

        private void btn_Payments_Click(object sender, EventArgs e)
        {
            // Show payments form within panel
            panel_Holder.Controls.Clear();
            var payments = new frm_StudentPayment();
            payments.TopLevel = false;
            panel_Holder.Controls.Add(payments);
            payments.Dock = DockStyle.Fill;
            payments.Show();
        }

        private void btn_Reports_Click(object sender, EventArgs e)
        {
            // Show reports form within panel
            var reports = new frm_Reports();
            reports.Show();
            //panel_Holder.Controls.Clear();
            //var reports = new frm_Reports();
            //reports.TopLevel = false;
            //panel_Holder.Controls.Add(reports);
            //reports.Dock = DockStyle.Fill;
            //reports.Show();
        }

        private void btn_Users_Click(object sender, EventArgs e)
        {
            // Show users form within panel
            panel_Holder.Controls.Clear();
            var users = new frm_UserRegistration();
            users.TopLevel = false;
            panel_Holder.Controls.Add(users);
            users.Dock = DockStyle.Fill;
            users.Show();
        }
    }
}
