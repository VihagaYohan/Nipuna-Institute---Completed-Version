namespace Nipuna.Reports.Reports
{
    partial class frm_PaymentFilterLecturerId
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Generate = new System.Windows.Forms.Button();
            this.txt_LecturerId = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.paymentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paymentFilterLecturerId = new Nipuna.Reports.DataSets.PaymentFilterLecturerId();
            this.paymentsTableAdapter = new Nipuna.Reports.DataSets.PaymentFilterLecturerIdTableAdapters.PaymentsTableAdapter();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentFilterLecturerId)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "PaymentFilterLecturerIdDataSet";
            reportDataSource1.Value = this.paymentsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Nipuna.Reports.Reports.rep_PaymentFilterLecturerId.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(599, 468);
            this.reportViewer1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_Generate);
            this.panel1.Controls.Add(this.txt_LecturerId);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(599, 50);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lecturer ID";
            // 
            // btn_Generate
            // 
            this.btn_Generate.Location = new System.Drawing.Point(379, 13);
            this.btn_Generate.Name = "btn_Generate";
            this.btn_Generate.Size = new System.Drawing.Size(112, 23);
            this.btn_Generate.TabIndex = 1;
            this.btn_Generate.Text = "Generate Report";
            this.btn_Generate.UseVisualStyleBackColor = true;
            this.btn_Generate.Click += new System.EventHandler(this.btn_Generate_Click);
            // 
            // txt_LecturerId
            // 
            this.txt_LecturerId.Location = new System.Drawing.Point(184, 14);
            this.txt_LecturerId.Name = "txt_LecturerId";
            this.txt_LecturerId.Size = new System.Drawing.Size(189, 21);
            this.txt_LecturerId.TabIndex = 0;
            this.txt_LecturerId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.reportViewer1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(599, 468);
            this.panel2.TabIndex = 2;
            // 
            // paymentsBindingSource
            // 
            this.paymentsBindingSource.DataMember = "Payments";
            this.paymentsBindingSource.DataSource = this.paymentFilterLecturerId;
            // 
            // paymentFilterLecturerId
            // 
            this.paymentFilterLecturerId.DataSetName = "PaymentFilterLecturerId";
            this.paymentFilterLecturerId.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // paymentsTableAdapter
            // 
            this.paymentsTableAdapter.ClearBeforeFill = true;
            // 
            // frm_PaymentFilterLecturerId
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 518);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frm_PaymentFilterLecturerId";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment Report ";
            this.Load += new System.EventHandler(this.frm_PaymentFilterLecturerId_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.paymentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentFilterLecturerId)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource paymentsBindingSource;
        private DataSets.PaymentFilterLecturerId paymentFilterLecturerId;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Generate;
        private System.Windows.Forms.TextBox txt_LecturerId;
        private System.Windows.Forms.Panel panel2;
        private DataSets.PaymentFilterLecturerIdTableAdapters.PaymentsTableAdapter paymentsTableAdapter;
        private System.Windows.Forms.Label label1;
    }
}