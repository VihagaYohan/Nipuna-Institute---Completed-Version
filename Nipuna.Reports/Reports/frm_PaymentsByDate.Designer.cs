namespace Nipuna.Reports.Reports
{
    partial class frm_PaymentsByDate
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
            this.date_To = new System.Windows.Forms.DateTimePicker();
            this.date_From = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Generate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.paymentsByDateDataSet = new Nipuna.Reports.DataSets.PaymentsByDateDataSet();
            this.paymentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paymentsTableAdapter = new Nipuna.Reports.DataSets.PaymentsByDateDataSetTableAdapters.PaymentsTableAdapter();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsByDateDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.date_To);
            this.panel1.Controls.Add(this.date_From);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btn_Generate);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(592, 42);
            this.panel1.TabIndex = 0;
            // 
            // date_To
            // 
            this.date_To.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_To.Location = new System.Drawing.Point(265, 10);
            this.date_To.Name = "date_To";
            this.date_To.Size = new System.Drawing.Size(117, 20);
            this.date_To.TabIndex = 12;
            // 
            // date_From
            // 
            this.date_From.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_From.Location = new System.Drawing.Point(96, 9);
            this.date_From.Name = "date_From";
            this.date_From.Size = new System.Drawing.Size(117, 20);
            this.date_From.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(228, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "To";
            // 
            // btn_Generate
            // 
            this.btn_Generate.Location = new System.Drawing.Point(413, 10);
            this.btn_Generate.Name = "btn_Generate";
            this.btn_Generate.Size = new System.Drawing.Size(124, 23);
            this.btn_Generate.TabIndex = 14;
            this.btn_Generate.Text = "Generate Report";
            this.btn_Generate.UseVisualStyleBackColor = true;
            this.btn_Generate.Click += new System.EventHandler(this.btn_Generate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "From";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.reportViewer1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(592, 334);
            this.panel2.TabIndex = 1;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "PaymentsByDate";
            reportDataSource1.Value = this.paymentsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Nipuna.Reports.Reports.rep_PaymentByDate.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(592, 334);
            this.reportViewer1.TabIndex = 0;
            // 
            // paymentsByDateDataSet
            // 
            this.paymentsByDateDataSet.DataSetName = "PaymentsByDateDataSet";
            this.paymentsByDateDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // paymentsBindingSource
            // 
            this.paymentsBindingSource.DataMember = "Payments";
            this.paymentsBindingSource.DataSource = this.paymentsByDateDataSet;
            // 
            // paymentsTableAdapter
            // 
            this.paymentsTableAdapter.ClearBeforeFill = true;
            // 
            // frm_Sample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 376);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frm_Sample";
            this.Text = "frm_Sample";
            this.Load += new System.EventHandler(this.frm_Sample_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.paymentsByDateDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.DateTimePicker date_To;
        private System.Windows.Forms.DateTimePicker date_From;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Generate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource paymentsBindingSource;
        private DataSets.PaymentsByDateDataSet paymentsByDateDataSet;
        private DataSets.PaymentsByDateDataSetTableAdapters.PaymentsTableAdapter paymentsTableAdapter;
    }
}