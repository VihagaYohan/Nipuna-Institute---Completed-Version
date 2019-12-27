namespace Nipuna.StudentPaymnet
{
    partial class frm_printInvoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_printInvoice));
            this.viewer_Invoice = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dbInvoice1 = new Nipuna.StudentPaymnet.dbInvoice();
            this.PaymentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paymentsTableAdapter1 = new Nipuna.StudentPaymnet.dbInvoiceTableAdapters.PaymentsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dbInvoice1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaymentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // viewer_Invoice
            // 
            this.viewer_Invoice.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "InvoiceDataSet";
            reportDataSource1.Value = this.PaymentBindingSource;
            this.viewer_Invoice.LocalReport.DataSources.Add(reportDataSource1);
            this.viewer_Invoice.LocalReport.ReportEmbeddedResource = "Nipuna.StudentPaymnet.rep_Invoice.rdlc";
            this.viewer_Invoice.Location = new System.Drawing.Point(0, 0);
            this.viewer_Invoice.Name = "viewer_Invoice";
            this.viewer_Invoice.Size = new System.Drawing.Size(488, 419);
            this.viewer_Invoice.TabIndex = 0;
            // 
            // dbInvoice1
            // 
            this.dbInvoice1.DataSetName = "dbInvoice";
            this.dbInvoice1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PaymentBindingSource
            // 
            this.PaymentBindingSource.DataMember = "Payments";
            this.PaymentBindingSource.DataSource = this.dbInvoice1;
            // 
            // paymentsTableAdapter1
            // 
            this.paymentsTableAdapter1.ClearBeforeFill = true;
            // 
            // frm_printInvoice
            // 
            this.ClientSize = new System.Drawing.Size(488, 419);
            this.Controls.Add(this.viewer_Invoice);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_printInvoice";
            this.Load += new System.EventHandler(this.frm_printInvoice_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dbInvoice1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaymentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource paymentsBindingSource;
        private dbInvoice dbInvoice;
        private dbInvoiceTableAdapters.PaymentsTableAdapter paymentsTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer viewer_Invoice;
        private dbInvoice dbInvoice1;
        private System.Windows.Forms.BindingSource PaymentBindingSource;
        private dbInvoiceTableAdapters.PaymentsTableAdapter paymentsTableAdapter1;

    }
}