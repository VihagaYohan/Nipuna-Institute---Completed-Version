namespace Nipuna.Reports
{
    partial class frm_Reports
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Reports));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentRegistrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allStudentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.singleRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentAttendanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.attendanceByLecturerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.attendanceByStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allRecordsToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.studentRecordsMatrixToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lecturerDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allRecordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byLecturerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enrollmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allRecordsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lecturerEnrollmentByLecturerIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lecturerEnrollmentByCourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.courseDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.courseEnrollmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentPaymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentPaymnetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentByLecturerIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentByStudentIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.singleRecordToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentByLecturerIDToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentByStudentIDToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userProfileReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentsByDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Gainsboro;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fToolStripMenuItem,
            this.fToolStripMenuItem1,
            this.fToolStripMenuItem2,
            this.paymentToolStripMenuItem,
            this.userToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(20, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(792, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fToolStripMenuItem
            // 
            this.fToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentRegistrationToolStripMenuItem,
            this.studentDetailsToolStripMenuItem,
            this.studentAttendanceToolStripMenuItem});
            this.fToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("fToolStripMenuItem.Image")));
            this.fToolStripMenuItem.Name = "fToolStripMenuItem";
            this.fToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.fToolStripMenuItem.Text = "Student";
            // 
            // studentRegistrationToolStripMenuItem
            // 
            this.studentRegistrationToolStripMenuItem.Name = "studentRegistrationToolStripMenuItem";
            this.studentRegistrationToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.studentRegistrationToolStripMenuItem.Text = "Student Registration";
            this.studentRegistrationToolStripMenuItem.Click += new System.EventHandler(this.studentRegistrationToolStripMenuItem_Click);
            // 
            // studentDetailsToolStripMenuItem
            // 
            this.studentDetailsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allStudentsToolStripMenuItem,
            this.singleRecordToolStripMenuItem});
            this.studentDetailsToolStripMenuItem.Name = "studentDetailsToolStripMenuItem";
            this.studentDetailsToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.studentDetailsToolStripMenuItem.Text = "Student Details";
            this.studentDetailsToolStripMenuItem.Click += new System.EventHandler(this.studentDetailsToolStripMenuItem_Click);
            // 
            // allStudentsToolStripMenuItem
            // 
            this.allStudentsToolStripMenuItem.Name = "allStudentsToolStripMenuItem";
            this.allStudentsToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.allStudentsToolStripMenuItem.Text = "All Records";
            this.allStudentsToolStripMenuItem.Click += new System.EventHandler(this.allStudentsToolStripMenuItem_Click);
            // 
            // singleRecordToolStripMenuItem
            // 
            this.singleRecordToolStripMenuItem.Name = "singleRecordToolStripMenuItem";
            this.singleRecordToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.singleRecordToolStripMenuItem.Text = "Single Record";
            this.singleRecordToolStripMenuItem.Click += new System.EventHandler(this.singleRecordToolStripMenuItem_Click);
            // 
            // studentAttendanceToolStripMenuItem
            // 
            this.studentAttendanceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.attendanceByLecturerToolStripMenuItem,
            this.attendanceByStudentToolStripMenuItem,
            this.allRecordsToolStripMenuItem2,
            this.studentRecordsMatrixToolStripMenuItem});
            this.studentAttendanceToolStripMenuItem.Name = "studentAttendanceToolStripMenuItem";
            this.studentAttendanceToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.studentAttendanceToolStripMenuItem.Text = "Student Attendance";
            // 
            // attendanceByLecturerToolStripMenuItem
            // 
            this.attendanceByLecturerToolStripMenuItem.Name = "attendanceByLecturerToolStripMenuItem";
            this.attendanceByLecturerToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.attendanceByLecturerToolStripMenuItem.Text = "Attendance By Lecturer";
            this.attendanceByLecturerToolStripMenuItem.Click += new System.EventHandler(this.attendanceByLecturerToolStripMenuItem_Click);
            // 
            // attendanceByStudentToolStripMenuItem
            // 
            this.attendanceByStudentToolStripMenuItem.Name = "attendanceByStudentToolStripMenuItem";
            this.attendanceByStudentToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.attendanceByStudentToolStripMenuItem.Text = "Attendance By Student";
            this.attendanceByStudentToolStripMenuItem.Click += new System.EventHandler(this.attendanceByStudentToolStripMenuItem_Click);
            // 
            // allRecordsToolStripMenuItem2
            // 
            this.allRecordsToolStripMenuItem2.Name = "allRecordsToolStripMenuItem2";
            this.allRecordsToolStripMenuItem2.Size = new System.Drawing.Size(205, 22);
            this.allRecordsToolStripMenuItem2.Text = "All Records";
            this.allRecordsToolStripMenuItem2.Click += new System.EventHandler(this.allRecordsToolStripMenuItem2_Click);
            // 
            // studentRecordsMatrixToolStripMenuItem
            // 
            this.studentRecordsMatrixToolStripMenuItem.Name = "studentRecordsMatrixToolStripMenuItem";
            this.studentRecordsMatrixToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.studentRecordsMatrixToolStripMenuItem.Text = "Student Records (Matrix)";
            this.studentRecordsMatrixToolStripMenuItem.Click += new System.EventHandler(this.studentRecordsMatrixToolStripMenuItem_Click);
            // 
            // fToolStripMenuItem1
            // 
            this.fToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lecturerDetailsToolStripMenuItem,
            this.enrollmentsToolStripMenuItem});
            this.fToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("fToolStripMenuItem1.Image")));
            this.fToolStripMenuItem1.Name = "fToolStripMenuItem1";
            this.fToolStripMenuItem1.Size = new System.Drawing.Size(78, 20);
            this.fToolStripMenuItem1.Text = "Lecturer";
            // 
            // lecturerDetailsToolStripMenuItem
            // 
            this.lecturerDetailsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allRecordsToolStripMenuItem,
            this.byLecturerToolStripMenuItem});
            this.lecturerDetailsToolStripMenuItem.Name = "lecturerDetailsToolStripMenuItem";
            this.lecturerDetailsToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.lecturerDetailsToolStripMenuItem.Text = "Lecturer Details";
            // 
            // allRecordsToolStripMenuItem
            // 
            this.allRecordsToolStripMenuItem.Name = "allRecordsToolStripMenuItem";
            this.allRecordsToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.allRecordsToolStripMenuItem.Text = "All Records";
            this.allRecordsToolStripMenuItem.Click += new System.EventHandler(this.allRecordsToolStripMenuItem_Click);
            // 
            // byLecturerToolStripMenuItem
            // 
            this.byLecturerToolStripMenuItem.Name = "byLecturerToolStripMenuItem";
            this.byLecturerToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.byLecturerToolStripMenuItem.Text = "By Lecturer ";
            this.byLecturerToolStripMenuItem.Click += new System.EventHandler(this.byLecturerToolStripMenuItem_Click);
            // 
            // enrollmentsToolStripMenuItem
            // 
            this.enrollmentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allRecordsToolStripMenuItem1,
            this.lecturerEnrollmentByLecturerIDToolStripMenuItem,
            this.lecturerEnrollmentByCourseToolStripMenuItem});
            this.enrollmentsToolStripMenuItem.Name = "enrollmentsToolStripMenuItem";
            this.enrollmentsToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.enrollmentsToolStripMenuItem.Text = "Enrollments";
            // 
            // allRecordsToolStripMenuItem1
            // 
            this.allRecordsToolStripMenuItem1.Name = "allRecordsToolStripMenuItem1";
            this.allRecordsToolStripMenuItem1.Size = new System.Drawing.Size(275, 22);
            this.allRecordsToolStripMenuItem1.Text = "All Records";
            this.allRecordsToolStripMenuItem1.Click += new System.EventHandler(this.allRecordsToolStripMenuItem1_Click);
            // 
            // lecturerEnrollmentByLecturerIDToolStripMenuItem
            // 
            this.lecturerEnrollmentByLecturerIDToolStripMenuItem.Name = "lecturerEnrollmentByLecturerIDToolStripMenuItem";
            this.lecturerEnrollmentByLecturerIDToolStripMenuItem.Size = new System.Drawing.Size(275, 22);
            this.lecturerEnrollmentByLecturerIDToolStripMenuItem.Text = "Lecturer Enrollment By Lecturer Name";
            this.lecturerEnrollmentByLecturerIDToolStripMenuItem.Click += new System.EventHandler(this.lecturerEnrollmentByLecturerIDToolStripMenuItem_Click);
            // 
            // lecturerEnrollmentByCourseToolStripMenuItem
            // 
            this.lecturerEnrollmentByCourseToolStripMenuItem.Name = "lecturerEnrollmentByCourseToolStripMenuItem";
            this.lecturerEnrollmentByCourseToolStripMenuItem.Size = new System.Drawing.Size(275, 22);
            this.lecturerEnrollmentByCourseToolStripMenuItem.Text = "Lecturer Enrollment By Course";
            this.lecturerEnrollmentByCourseToolStripMenuItem.Click += new System.EventHandler(this.lecturerEnrollmentByCourseToolStripMenuItem_Click);
            // 
            // fToolStripMenuItem2
            // 
            this.fToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.courseDetailsToolStripMenuItem,
            this.courseEnrollmentToolStripMenuItem});
            this.fToolStripMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("fToolStripMenuItem2.Image")));
            this.fToolStripMenuItem2.Name = "fToolStripMenuItem2";
            this.fToolStripMenuItem2.Size = new System.Drawing.Size(72, 20);
            this.fToolStripMenuItem2.Text = "Course";
            // 
            // courseDetailsToolStripMenuItem
            // 
            this.courseDetailsToolStripMenuItem.Name = "courseDetailsToolStripMenuItem";
            this.courseDetailsToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.courseDetailsToolStripMenuItem.Text = "Course Details";
            this.courseDetailsToolStripMenuItem.Click += new System.EventHandler(this.courseDetailsToolStripMenuItem_Click);
            // 
            // courseEnrollmentToolStripMenuItem
            // 
            this.courseEnrollmentToolStripMenuItem.Name = "courseEnrollmentToolStripMenuItem";
            this.courseEnrollmentToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.courseEnrollmentToolStripMenuItem.Text = "Course Enrollment";
            this.courseEnrollmentToolStripMenuItem.Click += new System.EventHandler(this.courseEnrollmentToolStripMenuItem_Click);
            // 
            // paymentToolStripMenuItem
            // 
            this.paymentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentPaymentToolStripMenuItem,
            this.singleRecordToolStripMenuItem1});
            this.paymentToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("paymentToolStripMenuItem.Image")));
            this.paymentToolStripMenuItem.Name = "paymentToolStripMenuItem";
            this.paymentToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.paymentToolStripMenuItem.Text = "Payment";
            // 
            // studentPaymentToolStripMenuItem
            // 
            this.studentPaymentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentPaymnetToolStripMenuItem,
            this.paymentByLecturerIDToolStripMenuItem,
            this.paymentByStudentIDToolStripMenuItem,
            this.paymentsByDateToolStripMenuItem});
            this.studentPaymentToolStripMenuItem.Name = "studentPaymentToolStripMenuItem";
            this.studentPaymentToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.studentPaymentToolStripMenuItem.Text = "Payments";
            // 
            // studentPaymnetToolStripMenuItem
            // 
            this.studentPaymnetToolStripMenuItem.Name = "studentPaymnetToolStripMenuItem";
            this.studentPaymnetToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.studentPaymnetToolStripMenuItem.Text = "Student Paymnet";
            this.studentPaymnetToolStripMenuItem.Click += new System.EventHandler(this.studentPaymnetToolStripMenuItem_Click);
            // 
            // paymentByLecturerIDToolStripMenuItem
            // 
            this.paymentByLecturerIDToolStripMenuItem.Name = "paymentByLecturerIDToolStripMenuItem";
            this.paymentByLecturerIDToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.paymentByLecturerIDToolStripMenuItem.Text = "Payment By Lecturer ID";
            this.paymentByLecturerIDToolStripMenuItem.Click += new System.EventHandler(this.paymentByLecturerIDToolStripMenuItem_Click);
            // 
            // paymentByStudentIDToolStripMenuItem
            // 
            this.paymentByStudentIDToolStripMenuItem.Name = "paymentByStudentIDToolStripMenuItem";
            this.paymentByStudentIDToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.paymentByStudentIDToolStripMenuItem.Text = "Payment By Student ID";
            this.paymentByStudentIDToolStripMenuItem.Click += new System.EventHandler(this.paymentByStudentIDToolStripMenuItem_Click);
            // 
            // singleRecordToolStripMenuItem1
            // 
            this.singleRecordToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paymentByLecturerIDToolStripMenuItem1,
            this.paymentByStudentIDToolStripMenuItem1});
            this.singleRecordToolStripMenuItem1.Name = "singleRecordToolStripMenuItem1";
            this.singleRecordToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.singleRecordToolStripMenuItem1.Text = "Single Record";
            // 
            // paymentByLecturerIDToolStripMenuItem1
            // 
            this.paymentByLecturerIDToolStripMenuItem1.Name = "paymentByLecturerIDToolStripMenuItem1";
            this.paymentByLecturerIDToolStripMenuItem1.Size = new System.Drawing.Size(197, 22);
            this.paymentByLecturerIDToolStripMenuItem1.Text = "Payment By Lecturer ID";
            this.paymentByLecturerIDToolStripMenuItem1.Click += new System.EventHandler(this.paymentByLecturerIDToolStripMenuItem1_Click);
            // 
            // paymentByStudentIDToolStripMenuItem1
            // 
            this.paymentByStudentIDToolStripMenuItem1.Name = "paymentByStudentIDToolStripMenuItem1";
            this.paymentByStudentIDToolStripMenuItem1.Size = new System.Drawing.Size(197, 22);
            this.paymentByStudentIDToolStripMenuItem1.Text = "Payment By Student ID";
            this.paymentByStudentIDToolStripMenuItem1.Click += new System.EventHandler(this.paymentByStudentIDToolStripMenuItem1_Click);
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userProfileReportToolStripMenuItem});
            this.userToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("userToolStripMenuItem.Image")));
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.userToolStripMenuItem.Text = "User";
            // 
            // userProfileReportToolStripMenuItem
            // 
            this.userProfileReportToolStripMenuItem.Name = "userProfileReportToolStripMenuItem";
            this.userProfileReportToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.userProfileReportToolStripMenuItem.Text = "User Profile Report";
            this.userProfileReportToolStripMenuItem.Click += new System.EventHandler(this.userProfileReportToolStripMenuItem_Click);
            // 
            // paymentsByDateToolStripMenuItem
            // 
            this.paymentsByDateToolStripMenuItem.Name = "paymentsByDateToolStripMenuItem";
            this.paymentsByDateToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.paymentsByDateToolStripMenuItem.Text = "Payments By Date";
            this.paymentsByDateToolStripMenuItem.Click += new System.EventHandler(this.paymentsByDateToolStripMenuItem_Click);
            // 
            // frm_Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 590);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_Reports";
            this.Text = "Nipuna Institute - Reports";
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.Load += new System.EventHandler(this.frm_Reports_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paymentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem studentRegistrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allStudentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem singleRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentAttendanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem attendanceByLecturerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem attendanceByStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lecturerDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allRecordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byLecturerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enrollmentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allRecordsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem lecturerEnrollmentByLecturerIDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lecturerEnrollmentByCourseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem courseDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem courseEnrollmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentPaymentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentPaymnetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paymentByLecturerIDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paymentByStudentIDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem singleRecordToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem paymentByLecturerIDToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem paymentByStudentIDToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem allRecordsToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem userProfileReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentRecordsMatrixToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paymentsByDateToolStripMenuItem;
    }
}