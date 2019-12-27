namespace Nipuna.Reports.Reports
{
    partial class frm_AttendanceFilterStudentId
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.attendancesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.attendanceFilterStudentId = new Nipuna.Reports.DataSets.AttendanceFilterStudentId();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Generate = new System.Windows.Forms.Button();
            this.txt_RegistrationId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.attendancesTableAdapter = new Nipuna.Reports.DataSets.AttendanceFilterStudentIdTableAdapters.AttendancesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.attendancesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceFilterStudentId)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // attendancesBindingSource
            // 
            this.attendancesBindingSource.DataMember = "Attendances";
            this.attendancesBindingSource.DataSource = this.attendanceFilterStudentId;
            // 
            // attendanceFilterStudentId
            // 
            this.attendanceFilterStudentId.DataSetName = "AttendanceFilterStudentId";
            this.attendanceFilterStudentId.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Generate);
            this.panel1.Controls.Add(this.txt_RegistrationId);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(562, 39);
            this.panel1.TabIndex = 0;
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
            this.panel2.Size = new System.Drawing.Size(562, 329);
            this.panel2.TabIndex = 1;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "AttendanceFilterStudentId";
            reportDataSource2.Value = this.attendancesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Nipuna.Reports.Reports.rep_AttendanceFilterStudentId.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(562, 329);
            this.reportViewer1.TabIndex = 2;
            // 
            // attendancesTableAdapter
            // 
            this.attendancesTableAdapter.ClearBeforeFill = true;
            // 
            // frm_AttendanceFilterStudentId
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 368);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frm_AttendanceFilterStudentId";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Attendance Report";
            this.Load += new System.EventHandler(this.frm_AttendanceFilterStudentId_Load);
            ((System.ComponentModel.ISupportInitialize)(this.attendancesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceFilterStudentId)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button btn_Generate;
        private System.Windows.Forms.TextBox txt_RegistrationId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource attendancesBindingSource;
        private DataSets.AttendanceFilterStudentId attendanceFilterStudentId;
        private DataSets.AttendanceFilterStudentIdTableAdapters.AttendancesTableAdapter attendancesTableAdapter;
    }
}