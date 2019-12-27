namespace Nipuna.Reports.Reports
{
    partial class frm_AttendanceFilterLecturerId
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Generate = new System.Windows.Forms.Button();
            this.txt_RegistrationId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.attendanceFilterLecturerId = new Nipuna.Reports.DataSets.AttendanceFilterLecturerId();
            this.attendancesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.attendancesTableAdapter = new Nipuna.Reports.DataSets.AttendanceFilterLecturerIdTableAdapters.AttendancesTableAdapter();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceFilterLecturerId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendancesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Generate);
            this.panel1.Controls.Add(this.txt_RegistrationId);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(565, 39);
            this.panel1.TabIndex = 1;
            // 
            // btn_Generate
            // 
            this.btn_Generate.Location = new System.Drawing.Point(407, 11);
            this.btn_Generate.Name = "btn_Generate";
            this.btn_Generate.Size = new System.Drawing.Size(108, 23);
            this.btn_Generate.TabIndex = 3;
            this.btn_Generate.Text = "Generate Report";
            this.btn_Generate.UseVisualStyleBackColor = true;
            this.btn_Generate.Click += new System.EventHandler(this.btn_Generate_Click);
            // 
            // txt_RegistrationId
            // 
            this.txt_RegistrationId.Location = new System.Drawing.Point(180, 11);
            this.txt_RegistrationId.Name = "txt_RegistrationId";
            this.txt_RegistrationId.Size = new System.Drawing.Size(221, 21);
            this.txt_RegistrationId.TabIndex = 1;
            this.txt_RegistrationId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Registration ID";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.reportViewer1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(565, 282);
            this.panel2.TabIndex = 2;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "AttendanceFilterLecturerId";
            reportDataSource1.Value = this.attendancesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Nipuna.Reports.Reports.rep_AttendanceFilterLecturerId.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(565, 282);
            this.reportViewer1.TabIndex = 0;
            // 
            // attendanceFilterLecturerId
            // 
            this.attendanceFilterLecturerId.DataSetName = "AttendanceFilterLecturerId";
            this.attendanceFilterLecturerId.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // attendancesBindingSource
            // 
            this.attendancesBindingSource.DataMember = "Attendances";
            this.attendancesBindingSource.DataSource = this.attendanceFilterLecturerId;
            // 
            // attendancesTableAdapter
            // 
            this.attendancesTableAdapter.ClearBeforeFill = true;
            // 
            // frm_AttendanceFilterLecturerId
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 321);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frm_AttendanceFilterLecturerId";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Attendance Report";
            this.Load += new System.EventHandler(this.frm_AttendanceFilterLecturerId_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.attendanceFilterLecturerId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendancesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Generate;
        private System.Windows.Forms.TextBox txt_RegistrationId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource attendancesBindingSource;
        private DataSets.AttendanceFilterLecturerId attendanceFilterLecturerId;
        private DataSets.AttendanceFilterLecturerIdTableAdapters.AttendancesTableAdapter attendancesTableAdapter;
    }
}