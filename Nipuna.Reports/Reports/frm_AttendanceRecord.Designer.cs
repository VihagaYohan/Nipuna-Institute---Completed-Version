namespace Nipuna.Reports.Reports
{
    partial class frm_AttendanceRecord
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
            this.attendancesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.attendanceRecord = new Nipuna.Reports.DataSets.AttendanceRecord();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Generate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.date_To = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.date_From = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.attendancesTableAdapter = new Nipuna.Reports.DataSets.AttendanceRecordTableAdapters.AttendancesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.attendancesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceRecord)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // attendancesBindingSource
            // 
            this.attendancesBindingSource.DataMember = "Attendances";
            this.attendancesBindingSource.DataSource = this.attendanceRecord;
            // 
            // attendanceRecord
            // 
            this.attendanceRecord.DataSetName = "AttendanceRecord";
            this.attendanceRecord.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Generate);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.date_To);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.date_From);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(603, 52);
            this.panel1.TabIndex = 0;
            // 
            // btn_Generate
            // 
            this.btn_Generate.Location = new System.Drawing.Point(455, 12);
            this.btn_Generate.Name = "btn_Generate";
            this.btn_Generate.Size = new System.Drawing.Size(124, 23);
            this.btn_Generate.TabIndex = 4;
            this.btn_Generate.Text = "Generate Report";
            this.btn_Generate.UseVisualStyleBackColor = true;
            this.btn_Generate.Click += new System.EventHandler(this.btn_Generate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(266, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "To";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // date_To
            // 
            this.date_To.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_To.Location = new System.Drawing.Point(307, 12);
            this.date_To.Name = "date_To";
            this.date_To.Size = new System.Drawing.Size(117, 21);
            this.date_To.TabIndex = 2;
            this.date_To.ValueChanged += new System.EventHandler(this.date_To_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "From";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // date_From
            // 
            this.date_From.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_From.Location = new System.Drawing.Point(88, 12);
            this.date_From.Name = "date_From";
            this.date_From.Size = new System.Drawing.Size(117, 21);
            this.date_From.TabIndex = 0;
            this.date_From.ValueChanged += new System.EventHandler(this.date_From_ValueChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.reportViewer1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(603, 400);
            this.panel2.TabIndex = 1;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "StudentAttendanceMatrix";
            reportDataSource1.Value = this.attendancesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Nipuna.Reports.Reports.rep_AttendanceReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(603, 400);
            this.reportViewer1.TabIndex = 2;
            // 
            // attendancesTableAdapter
            // 
            this.attendancesTableAdapter.ClearBeforeFill = true;
            // 
            // frm_AttendanceRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 452);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frm_AttendanceRecord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Attendance Report ";
            this.Load += new System.EventHandler(this.frm_AttendanceRecord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.attendancesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceRecord)).EndInit();
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker date_To;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker date_From;
        private System.Windows.Forms.BindingSource attendancesBindingSource;
        private DataSets.AttendanceRecord attendanceRecord;
        private DataSets.AttendanceRecordTableAdapters.AttendancesTableAdapter attendancesTableAdapter;
    }
}