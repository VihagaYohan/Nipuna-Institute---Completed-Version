namespace Nipuna.Reports.Reports
{
    partial class frm_LecturerEnrollment
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
            this.lecturerCourseEnrollmentDataSet = new Nipuna.Reports.DataSets.LecturerCourseEnrollmentDataSet();
            this.lecturerCoursesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lecturerCoursesTableAdapter = new Nipuna.Reports.DataSets.LecturerCourseEnrollmentDataSetTableAdapters.LecturerCoursesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.lecturerCourseEnrollmentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturerCoursesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "LecturerCourseEnrollmentDataSet";
            reportDataSource1.Value = this.lecturerCoursesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Nipuna.Reports.Reports.rep_LecturerEnrollment.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(586, 449);
            this.reportViewer1.TabIndex = 0;
            // 
            // lecturerCourseEnrollmentDataSet
            // 
            this.lecturerCourseEnrollmentDataSet.DataSetName = "LecturerCourseEnrollmentDataSet";
            this.lecturerCourseEnrollmentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lecturerCoursesBindingSource
            // 
            this.lecturerCoursesBindingSource.DataMember = "LecturerCourses";
            this.lecturerCoursesBindingSource.DataSource = this.lecturerCourseEnrollmentDataSet;
            // 
            // lecturerCoursesTableAdapter
            // 
            this.lecturerCoursesTableAdapter.ClearBeforeFill = true;
            // 
            // frm_LecturerEnrollment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 449);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frm_LecturerEnrollment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lecturer Enrollment Report";
            this.Load += new System.EventHandler(this.frm_LecturerEnrollment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lecturerCourseEnrollmentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturerCoursesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataSets.LecturerCourseEnrollmentDataSet lecturerCourseEnrollmentDataSet;
        private System.Windows.Forms.BindingSource lecturerCoursesBindingSource;
        private DataSets.LecturerCourseEnrollmentDataSetTableAdapters.LecturerCoursesTableAdapter lecturerCoursesTableAdapter;
    }
}