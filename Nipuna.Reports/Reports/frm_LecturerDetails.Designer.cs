namespace Nipuna.Reports.Reports
{
    partial class frm_LecturerDetails
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
            this.lectuerDetailsDataSet = new Nipuna.Reports.DataSets.LectuerDetailsDataSet();
            this.lecturersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lecturersTableAdapter = new Nipuna.Reports.DataSets.LectuerDetailsDataSetTableAdapters.LecturersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.lectuerDetailsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "LecturerDetailsDataSet";
            reportDataSource1.Value = this.lecturersBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Nipuna.Reports.Reports.rep_LectuerDetails.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(638, 514);
            this.reportViewer1.TabIndex = 0;
            // 
            // lectuerDetailsDataSet
            // 
            this.lectuerDetailsDataSet.DataSetName = "LectuerDetailsDataSet";
            this.lectuerDetailsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lecturersBindingSource
            // 
            this.lecturersBindingSource.DataMember = "Lecturers";
            this.lecturersBindingSource.DataSource = this.lectuerDetailsDataSet;
            // 
            // lecturersTableAdapter
            // 
            this.lecturersTableAdapter.ClearBeforeFill = true;
            // 
            // frm_LecturerDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 514);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frm_LecturerDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lectuer Details Report";
            this.Load += new System.EventHandler(this.frm_LecturerDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lectuerDetailsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataSets.LectuerDetailsDataSet lectuerDetailsDataSet;
        private System.Windows.Forms.BindingSource lecturersBindingSource;
        private DataSets.LectuerDetailsDataSetTableAdapters.LecturersTableAdapter lecturersTableAdapter;
    }
}