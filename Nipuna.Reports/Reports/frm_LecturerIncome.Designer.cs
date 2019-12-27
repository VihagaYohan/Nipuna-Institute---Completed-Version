namespace Nipuna.Reports.Reports
{
    partial class frm_LecturerIncome
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
            this.label2 = new System.Windows.Forms.Label();
            this.date_To = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.date_From = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.lecturerPaymentDataSet = new Nipuna.Reports.DataSets.LecturerPaymentDataSet();
            this.paymentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paymentsTableAdapter = new Nipuna.Reports.DataSets.LecturerPaymentDataSetTableAdapters.PaymentsTableAdapter();
            this.paymentsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lecturerPaymentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsBindingSource1)).BeginInit();
            this.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(608, 43);
            this.panel1.TabIndex = 0;
            // 
            // btn_Generate
            // 
            this.btn_Generate.Location = new System.Drawing.Point(446, 10);
            this.btn_Generate.Name = "btn_Generate";
            this.btn_Generate.Size = new System.Drawing.Size(124, 23);
            this.btn_Generate.TabIndex = 9;
            this.btn_Generate.Text = "Generate Report";
            this.btn_Generate.UseVisualStyleBackColor = true;
            this.btn_Generate.Click += new System.EventHandler(this.btn_Generate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(257, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "To";
            // 
            // date_To
            // 
            this.date_To.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_To.Location = new System.Drawing.Point(298, 10);
            this.date_To.Name = "date_To";
            this.date_To.Size = new System.Drawing.Size(117, 20);
            this.date_To.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "From";
            // 
            // date_From
            // 
            this.date_From.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_From.Location = new System.Drawing.Point(79, 10);
            this.date_From.Name = "date_From";
            this.date_From.Size = new System.Drawing.Size(117, 20);
            this.date_From.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.reportViewer1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(608, 375);
            this.panel2.TabIndex = 1;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.paymentsBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Nipuna.Reports.Reports.rep_LecturerTotal.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(608, 375);
            this.reportViewer1.TabIndex = 0;
            // 
            // lecturerPaymentDataSet
            // 
            this.lecturerPaymentDataSet.DataSetName = "LecturerPaymentDataSet";
            this.lecturerPaymentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // paymentsBindingSource
            // 
            this.paymentsBindingSource.DataMember = "Payments";
            this.paymentsBindingSource.DataSource = this.lecturerPaymentDataSet;
            // 
            // paymentsTableAdapter
            // 
            this.paymentsTableAdapter.ClearBeforeFill = true;
            // 
            // paymentsBindingSource1
            // 
            this.paymentsBindingSource1.DataMember = "Payments";
            this.paymentsBindingSource1.DataSource = this.lecturerPaymentDataSet;
            // 
            // frm_LecturerIncome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 418);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frm_LecturerIncome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lecturer Income";
            this.Load += new System.EventHandler(this.frm_LecturerIncome_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lecturerPaymentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Generate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker date_To;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker date_From;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource paymentsBindingSource;
        private DataSets.LecturerPaymentDataSet lecturerPaymentDataSet;
        private DataSets.LecturerPaymentDataSetTableAdapters.PaymentsTableAdapter paymentsTableAdapter;
        private System.Windows.Forms.BindingSource paymentsBindingSource1;
    }
}