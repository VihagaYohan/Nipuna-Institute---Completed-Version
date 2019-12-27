namespace Nipuna.Reports.Reports
{
    partial class frm_LecturerDetailsFilterLecturerId
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
            this.txt_LecturerId = new System.Windows.Forms.TextBox();
            this.btn_Generate = new System.Windows.Forms.Button();
            this.lecturerDetailsFilterLectuerId = new Nipuna.Reports.DataSets.LecturerDetailsFilterLectuerId();
            this.lecturersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lecturersTableAdapter = new Nipuna.Reports.DataSets.LecturerDetailsFilterLectuerIdTableAdapters.LecturersTableAdapter();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lecturerDetailsFilterLectuerId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Generate);
            this.panel1.Controls.Add(this.txt_LecturerId);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(538, 33);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.reportViewer1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(538, 413);
            this.panel2.TabIndex = 1;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "LecturerDetailsFilterLecturerId";
            reportDataSource2.Value = this.lecturersBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Nipuna.Reports.Reports.rep_LecturerDetailsFilterLectuererId.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(538, 413);
            this.reportViewer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lecturer ID";
            // 
            // txt_LecturerId
            // 
            this.txt_LecturerId.Location = new System.Drawing.Point(134, 6);
            this.txt_LecturerId.Name = "txt_LecturerId";
            this.txt_LecturerId.Size = new System.Drawing.Size(249, 21);
            this.txt_LecturerId.TabIndex = 1;
            this.txt_LecturerId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_Generate
            // 
            this.btn_Generate.Location = new System.Drawing.Point(389, 6);
            this.btn_Generate.Name = "btn_Generate";
            this.btn_Generate.Size = new System.Drawing.Size(107, 23);
            this.btn_Generate.TabIndex = 2;
            this.btn_Generate.Text = "Generate Report";
            this.btn_Generate.UseVisualStyleBackColor = true;
            this.btn_Generate.Click += new System.EventHandler(this.btn_Generate_Click);
            // 
            // lecturerDetailsFilterLectuerId
            // 
            this.lecturerDetailsFilterLectuerId.DataSetName = "LecturerDetailsFilterLectuerId";
            this.lecturerDetailsFilterLectuerId.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lecturersBindingSource
            // 
            this.lecturersBindingSource.DataMember = "Lecturers";
            this.lecturersBindingSource.DataSource = this.lecturerDetailsFilterLectuerId;
            // 
            // lecturersTableAdapter
            // 
            this.lecturersTableAdapter.ClearBeforeFill = true;
            // 
            // frm_LecturerDetailsFilterLecturerId
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 446);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frm_LecturerDetailsFilterLecturerId";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lecturer Details Report";
            this.Load += new System.EventHandler(this.frm_LecturerDetailsFilterLecturerId_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lecturerDetailsFilterLectuerId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button btn_Generate;
        private System.Windows.Forms.TextBox txt_LecturerId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource lecturersBindingSource;
        private DataSets.LecturerDetailsFilterLectuerId lecturerDetailsFilterLectuerId;
        private DataSets.LecturerDetailsFilterLectuerIdTableAdapters.LecturersTableAdapter lecturersTableAdapter;
    }
}