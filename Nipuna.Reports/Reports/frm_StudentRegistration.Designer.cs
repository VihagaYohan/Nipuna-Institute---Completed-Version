namespace Nipuna.Reports.Reports
{
    partial class frm_StudentRegistration
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
            this.studentRegistrationsDataSet = new Nipuna.Reports.DataSets.StudentRegistrationsDataSet();
            this.courseEnrollmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.courseEnrollmentsTableAdapter = new Nipuna.Reports.DataSets.StudentRegistrationsDataSetTableAdapters.CourseEnrollmentsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.studentRegistrationsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseEnrollmentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "StudentRegistrationDataSet";
            reportDataSource1.Value = this.courseEnrollmentsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Nipuna.Reports.Reports.rep_StudentRegistration.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(602, 443);
            this.reportViewer1.TabIndex = 0;
            // 
            // studentRegistrationsDataSet
            // 
            this.studentRegistrationsDataSet.DataSetName = "StudentRegistrationsDataSet";
            this.studentRegistrationsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // courseEnrollmentsBindingSource
            // 
            this.courseEnrollmentsBindingSource.DataMember = "CourseEnrollments";
            this.courseEnrollmentsBindingSource.DataSource = this.studentRegistrationsDataSet;
            // 
            // courseEnrollmentsTableAdapter
            // 
            this.courseEnrollmentsTableAdapter.ClearBeforeFill = true;
            // 
            // frm_StudentRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 443);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frm_StudentRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Registrations Report";
            this.Load += new System.EventHandler(this.frm_StudentRegistration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentRegistrationsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseEnrollmentsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataSets.StudentRegistrationsDataSet studentRegistrationsDataSet;
        private System.Windows.Forms.BindingSource courseEnrollmentsBindingSource;
        private DataSets.StudentRegistrationsDataSetTableAdapters.CourseEnrollmentsTableAdapter courseEnrollmentsTableAdapter;
    }
}