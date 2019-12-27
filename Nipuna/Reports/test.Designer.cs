namespace Nipuna.Main
{
    partial class MainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.pic_Close = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.attendanceHistroyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentHistroyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lecturerDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.courseDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enrolledCoursesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lecturerPaymentDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentAttendanceDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pic_Minimize = new System.Windows.Forms.PictureBox();
            this.pic_Maximize = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Close)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Maximize)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_Close
            // 
            this.pic_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_Close.Image = ((System.Drawing.Image)(resources.GetObject("pic_Close.Image")));
            this.pic_Close.Location = new System.Drawing.Point(742, 2);
            this.pic_Close.Name = "pic_Close";
            this.pic_Close.Size = new System.Drawing.Size(22, 19);
            this.pic_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Close.TabIndex = 1;
            this.pic_Close.TabStop = false;
            this.pic_Close.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pic_Close_MouseClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fToolStripMenuItem,
            this.fToolStripMenuItem1,
            this.fToolStripMenuItem2,
            this.paymentToolStripMenuItem,
            this.userToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(766, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fToolStripMenuItem
            // 
            this.fToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentDetailsToolStripMenuItem,
            this.attendanceHistroyToolStripMenuItem,
            this.paymentHistroyToolStripMenuItem,
            this.paymentHistoryToolStripMenuItem});
            this.fToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("fToolStripMenuItem.Image")));
            this.fToolStripMenuItem.Name = "fToolStripMenuItem";
            this.fToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.fToolStripMenuItem.Text = "Student";
            // 
            // fToolStripMenuItem1
            // 
            this.fToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lecturerDetailsToolStripMenuItem,
            this.enrolledCoursesToolStripMenuItem,
            this.lecturerPaymentDetailsToolStripMenuItem,
            this.studentAttendanceDetailsToolStripMenuItem});
            this.fToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("fToolStripMenuItem1.Image")));
            this.fToolStripMenuItem1.Name = "fToolStripMenuItem1";
            this.fToolStripMenuItem1.Size = new System.Drawing.Size(78, 20);
            this.fToolStripMenuItem1.Text = "Lecturer";
            // 
            // fToolStripMenuItem2
            // 
            this.fToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.courseDetailsToolStripMenuItem});
            this.fToolStripMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("fToolStripMenuItem2.Image")));
            this.fToolStripMenuItem2.Name = "fToolStripMenuItem2";
            this.fToolStripMenuItem2.Size = new System.Drawing.Size(72, 20);
            this.fToolStripMenuItem2.Text = "Course";
            // 
            // paymentToolStripMenuItem
            // 
            this.paymentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paymentDetailsToolStripMenuItem});
            this.paymentToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("paymentToolStripMenuItem.Image")));
            this.paymentToolStripMenuItem.Name = "paymentToolStripMenuItem";
            this.paymentToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.paymentToolStripMenuItem.Text = "Payment";
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userDetailsToolStripMenuItem});
            this.userToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("userToolStripMenuItem.Image")));
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.userToolStripMenuItem.Text = "User";
            // 
            // studentDetailsToolStripMenuItem
            // 
            this.studentDetailsToolStripMenuItem.Name = "studentDetailsToolStripMenuItem";
            this.studentDetailsToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.studentDetailsToolStripMenuItem.Text = "Student Details";
            // 
            // attendanceHistroyToolStripMenuItem
            // 
            this.attendanceHistroyToolStripMenuItem.Name = "attendanceHistroyToolStripMenuItem";
            this.attendanceHistroyToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.attendanceHistroyToolStripMenuItem.Text = "Student Contact Details";
            // 
            // paymentHistroyToolStripMenuItem
            // 
            this.paymentHistroyToolStripMenuItem.Name = "paymentHistroyToolStripMenuItem";
            this.paymentHistroyToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.paymentHistroyToolStripMenuItem.Text = "Attendance Report";
            // 
            // lecturerDetailsToolStripMenuItem
            // 
            this.lecturerDetailsToolStripMenuItem.Name = "lecturerDetailsToolStripMenuItem";
            this.lecturerDetailsToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.lecturerDetailsToolStripMenuItem.Text = "Lecturer Details";
            // 
            // paymentHistoryToolStripMenuItem
            // 
            this.paymentHistoryToolStripMenuItem.Name = "paymentHistoryToolStripMenuItem";
            this.paymentHistoryToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.paymentHistoryToolStripMenuItem.Text = "Payment History";
            // 
            // courseDetailsToolStripMenuItem
            // 
            this.courseDetailsToolStripMenuItem.Name = "courseDetailsToolStripMenuItem";
            this.courseDetailsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.courseDetailsToolStripMenuItem.Text = "Course Details";
            // 
            // enrolledCoursesToolStripMenuItem
            // 
            this.enrolledCoursesToolStripMenuItem.Name = "enrolledCoursesToolStripMenuItem";
            this.enrolledCoursesToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.enrolledCoursesToolStripMenuItem.Text = "Enrolled Courses";
            // 
            // paymentDetailsToolStripMenuItem
            // 
            this.paymentDetailsToolStripMenuItem.Name = "paymentDetailsToolStripMenuItem";
            this.paymentDetailsToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.paymentDetailsToolStripMenuItem.Text = "Payment Details";
            // 
            // lecturerPaymentDetailsToolStripMenuItem
            // 
            this.lecturerPaymentDetailsToolStripMenuItem.Name = "lecturerPaymentDetailsToolStripMenuItem";
            this.lecturerPaymentDetailsToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.lecturerPaymentDetailsToolStripMenuItem.Text = "Lecturer Payment Details";
            // 
            // studentAttendanceDetailsToolStripMenuItem
            // 
            this.studentAttendanceDetailsToolStripMenuItem.Name = "studentAttendanceDetailsToolStripMenuItem";
            this.studentAttendanceDetailsToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.studentAttendanceDetailsToolStripMenuItem.Text = "Student Attendance Details";
            // 
            // userDetailsToolStripMenuItem
            // 
            this.userDetailsToolStripMenuItem.Name = "userDetailsToolStripMenuItem";
            this.userDetailsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.userDetailsToolStripMenuItem.Text = "User Details";
            // 
            // pic_Minimize
            // 
            this.pic_Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_Minimize.Image = ((System.Drawing.Image)(resources.GetObject("pic_Minimize.Image")));
            this.pic_Minimize.Location = new System.Drawing.Point(686, 2);
            this.pic_Minimize.Name = "pic_Minimize";
            this.pic_Minimize.Size = new System.Drawing.Size(22, 19);
            this.pic_Minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Minimize.TabIndex = 3;
            this.pic_Minimize.TabStop = false;
            this.pic_Minimize.Click += new System.EventHandler(this.pic_Minimize_Click_1);
            // 
            // pic_Maximize
            // 
            this.pic_Maximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_Maximize.Image = ((System.Drawing.Image)(resources.GetObject("pic_Maximize.Image")));
            this.pic_Maximize.Location = new System.Drawing.Point(714, 2);
            this.pic_Maximize.Name = "pic_Maximize";
            this.pic_Maximize.Size = new System.Drawing.Size(22, 19);
            this.pic_Maximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Maximize.TabIndex = 4;
            this.pic_Maximize.TabStop = false;
            this.pic_Maximize.Click += new System.EventHandler(this.pic_Maximize_Click_1);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 413);
            this.Controls.Add(this.pic_Maximize);
            this.Controls.Add(this.pic_Minimize);
            this.Controls.Add(this.pic_Close);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nipuna Institue";
            this.Load += new System.EventHandler(this.MainScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Close)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Maximize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_Close;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem studentDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem attendanceHistroyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paymentHistroyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paymentHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lecturerDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enrolledCoursesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lecturerPaymentDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentAttendanceDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem courseDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paymentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paymentDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userDetailsToolStripMenuItem;
        private System.Windows.Forms.PictureBox pic_Minimize;
        private System.Windows.Forms.PictureBox pic_Maximize;


    }
}