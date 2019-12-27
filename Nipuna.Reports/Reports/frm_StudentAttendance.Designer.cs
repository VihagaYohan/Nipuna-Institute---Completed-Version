namespace Nipuna.Reports.Reports
{
    partial class frm_StudentAttendance
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
            this.studentAttendanceDataSet = new Nipuna.Reports.DataSets.StudentAttendanceDataSet();
            this.attendancesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.attendancesTableAdapter = new Nipuna.Reports.DataSets.StudentAttendanceDataSetTableAdapters.AttendancesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.studentAttendanceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendancesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "StudentAttendanceDataSet";
            reportDataSource1.Value = this.attendancesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Nipuna.Reports.Reports.rep_StudentAttendance.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(533, 495);
            this.reportViewer1.TabIndex = 0;
            // 
            // studentAttendanceDataSet
            // 
            this.studentAttendanceDataSet.DataSetName = "StudentAttendanceDataSet";
            this.studentAttendanceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // attendancesBindingSource
            // 
            this.attendancesBindingSource.DataMember = "Attendances";
            this.attendancesBindingSource.DataSource = this.studentAttendanceDataSet;
            // 
            // attendancesTableAdapter
            // 
            this.attendancesTableAdapter.ClearBeforeFill = true;
            // 
            // frm_StudentAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 495);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frm_StudentAttendance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Attendance";
            this.Load += new System.EventHandler(this.frm_StudentAttendance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentAttendanceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendancesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataSets.StudentAttendanceDataSet studentAttendanceDataSet;
        private System.Windows.Forms.BindingSource attendancesBindingSource;
        private DataSets.StudentAttendanceDataSetTableAdapters.AttendancesTableAdapter attendancesTableAdapter;
    }
}