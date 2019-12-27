namespace Nipuna.Reports.Reports
{
    partial class frm_CourseDetails
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
            this.courseDetailsDataSet = new Nipuna.Reports.DataSets.CourseDetailsDataSet();
            this.coursesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coursesTableAdapter = new Nipuna.Reports.DataSets.CourseDetailsDataSetTableAdapters.CoursesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.courseDetailsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "CourseDetailsDataSet";
            reportDataSource1.Value = this.coursesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Nipuna.Reports.Reports.rep_CourseDetails.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(702, 469);
            this.reportViewer1.TabIndex = 0;
            // 
            // courseDetailsDataSet
            // 
            this.courseDetailsDataSet.DataSetName = "CourseDetailsDataSet";
            this.courseDetailsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // coursesBindingSource
            // 
            this.coursesBindingSource.DataMember = "Courses";
            this.coursesBindingSource.DataSource = this.courseDetailsDataSet;
            // 
            // coursesTableAdapter
            // 
            this.coursesTableAdapter.ClearBeforeFill = true;
            // 
            // frm_CourseDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 469);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frm_CourseDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Course Details Report";
            this.Load += new System.EventHandler(this.frm_CourseDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.courseDetailsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataSets.CourseDetailsDataSet courseDetailsDataSet;
        private System.Windows.Forms.BindingSource coursesBindingSource;
        private DataSets.CourseDetailsDataSetTableAdapters.CoursesTableAdapter coursesTableAdapter;
    }
}