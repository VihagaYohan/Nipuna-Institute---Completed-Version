namespace Nipuna.Reports.Reports
{
    partial class frm_CourseEnrollment
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.studentCourseEnrollmentDataSet = new Nipuna.Reports.DataSets.StudentCourseEnrollmentDataSet();
            this.courseEnrollmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.courseEnrollmentsTableAdapter = new Nipuna.Reports.DataSets.StudentCourseEnrollmentDataSetTableAdapters.CourseEnrollmentsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.studentCourseEnrollmentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseEnrollmentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "StudentCourseEnrollmentDataSet";
            reportDataSource1.Value = this.courseEnrollmentsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Nipuna.Reports.Reports.rep_StudentEnrollment.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(518, 489);
            this.reportViewer1.TabIndex = 0;
            // 
            // studentCourseEnrollmentDataSet
            // 
            this.studentCourseEnrollmentDataSet.DataSetName = "StudentCourseEnrollmentDataSet";
            this.studentCourseEnrollmentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // courseEnrollmentsBindingSource
            // 
            this.courseEnrollmentsBindingSource.DataMember = "CourseEnrollments";
            this.courseEnrollmentsBindingSource.DataSource = this.studentCourseEnrollmentDataSet;
            // 
            // courseEnrollmentsTableAdapter
            // 
            this.courseEnrollmentsTableAdapter.ClearBeforeFill = true;
            // 
            // frm_CourseEnrollmentByStudentId
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 489);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frm_CourseEnrollmentByStudentId";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Course Enrollment Report By Student ID";
            this.Load += new System.EventHandler(this.frm_CourseEnrollmentByStudentId_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentCourseEnrollmentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseEnrollmentsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataSets.StudentCourseEnrollmentDataSet studentCourseEnrollmentDataSet;
        private System.Windows.Forms.BindingSource courseEnrollmentsBindingSource;
        private DataSets.StudentCourseEnrollmentDataSetTableAdapters.CourseEnrollmentsTableAdapter courseEnrollmentsTableAdapter;
    }
}