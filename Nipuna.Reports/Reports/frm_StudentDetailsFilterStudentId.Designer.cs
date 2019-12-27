namespace Nipuna.Reports.Reports
{
    partial class frm_StudentDetailsFilterStudentId
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Registration = new System.Windows.Forms.TextBox();
            this.btn_Generate = new System.Windows.Forms.Button();
            this.studentDetailsFilterStudentId = new Nipuna.Reports.DataSets.StudentDetailsFilterStudentId();
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentsTableAdapter = new Nipuna.Reports.DataSets.StudentDetailsFilterStudentIdTableAdapters.StudentsTableAdapter();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentDetailsFilterStudentId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Generate);
            this.panel1.Controls.Add(this.txt_Registration);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(658, 40);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.reportViewer1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(658, 470);
            this.panel2.TabIndex = 1;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "StudentDetailsFilterStudentId";
            reportDataSource2.Value = this.studentsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Nipuna.Reports.Reports.rep_StudentDetailsFilterStudentId.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(658, 470);
            this.reportViewer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Registration ID";
            // 
            // txt_Registration
            // 
            this.txt_Registration.Location = new System.Drawing.Point(205, 9);
            this.txt_Registration.Name = "txt_Registration";
            this.txt_Registration.Size = new System.Drawing.Size(250, 21);
            this.txt_Registration.TabIndex = 1;
            this.txt_Registration.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_Generate
            // 
            this.btn_Generate.Location = new System.Drawing.Point(461, 8);
            this.btn_Generate.Name = "btn_Generate";
            this.btn_Generate.Size = new System.Drawing.Size(110, 23);
            this.btn_Generate.TabIndex = 2;
            this.btn_Generate.Text = "Generate Report";
            this.btn_Generate.UseVisualStyleBackColor = true;
            this.btn_Generate.Click += new System.EventHandler(this.btn_Generate_Click);
            // 
            // studentDetailsFilterStudentId
            // 
            this.studentDetailsFilterStudentId.DataSetName = "StudentDetailsFilterStudentId";
            this.studentDetailsFilterStudentId.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentsBindingSource
            // 
            this.studentsBindingSource.DataMember = "Students";
            this.studentsBindingSource.DataSource = this.studentDetailsFilterStudentId;
            // 
            // studentsTableAdapter
            // 
            this.studentsTableAdapter.ClearBeforeFill = true;
            // 
            // frm_StudentDetailsFilterStudentId
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 510);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frm_StudentDetailsFilterStudentId";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Details Report";
            this.Load += new System.EventHandler(this.frm_StudentDetailsFilterStudentId_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.studentDetailsFilterStudentId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Generate;
        private System.Windows.Forms.TextBox txt_Registration;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource studentsBindingSource;
        private DataSets.StudentDetailsFilterStudentId studentDetailsFilterStudentId;
        private DataSets.StudentDetailsFilterStudentIdTableAdapters.StudentsTableAdapter studentsTableAdapter;
    }
}