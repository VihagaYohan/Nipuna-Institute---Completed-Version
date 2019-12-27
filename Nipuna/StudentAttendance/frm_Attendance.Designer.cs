namespace Nipuna.StudentAttendance
{
    partial class frm_Attendance
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel_Buttons = new System.Windows.Forms.Panel();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.txtStudentId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_RegistrationId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_CourseName = new System.Windows.Forms.TextBox();
            this.txt_CourseId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gridInvoices = new System.Windows.Forms.DataGridView();
            this.txtLecturerName = new System.Windows.Forms.TextBox();
            this.txtLecturerID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel_Buttons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridInvoices)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Buttons
            // 
            this.panel_Buttons.Controls.Add(this.btnSubmit);
            this.panel_Buttons.Controls.Add(this.btnCancel);
            this.panel_Buttons.Location = new System.Drawing.Point(136, 158);
            this.panel_Buttons.Name = "panel_Buttons";
            this.panel_Buttons.Size = new System.Drawing.Size(174, 39);
            this.panel_Buttons.TabIndex = 65;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(7, 8);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(88, 8);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(241, 72);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.ReadOnly = true;
            this.txtStudentName.Size = new System.Drawing.Size(330, 21);
            this.txtStudentName.TabIndex = 63;
            // 
            // txtStudentId
            // 
            this.txtStudentId.Location = new System.Drawing.Point(136, 72);
            this.txtStudentId.Name = "txtStudentId";
            this.txtStudentId.ReadOnly = true;
            this.txtStudentId.Size = new System.Drawing.Size(99, 21);
            this.txtStudentId.TabIndex = 59;
            this.txtStudentId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtStudentId_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 57;
            this.label1.Text = "Student ID";
            // 
            // txt_RegistrationId
            // 
            this.txt_RegistrationId.Location = new System.Drawing.Point(136, 43);
            this.txt_RegistrationId.Name = "txt_RegistrationId";
            this.txt_RegistrationId.Size = new System.Drawing.Size(211, 21);
            this.txt_RegistrationId.TabIndex = 68;
            this.txt_RegistrationId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_RegistrationId_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 15);
            this.label4.TabIndex = 67;
            this.label4.Text = "Course Registration ID";
            // 
            // txt_CourseName
            // 
            this.txt_CourseName.Location = new System.Drawing.Point(241, 99);
            this.txt_CourseName.Name = "txt_CourseName";
            this.txt_CourseName.ReadOnly = true;
            this.txt_CourseName.Size = new System.Drawing.Size(330, 21);
            this.txt_CourseName.TabIndex = 72;
            // 
            // txt_CourseId
            // 
            this.txt_CourseId.Location = new System.Drawing.Point(136, 99);
            this.txt_CourseId.Name = "txt_CourseId";
            this.txt_CourseId.ReadOnly = true;
            this.txt_CourseId.Size = new System.Drawing.Size(99, 21);
            this.txt_CourseId.TabIndex = 70;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 15);
            this.label5.TabIndex = 69;
            this.label5.Text = "Course";
            // 
            // gridInvoices
            // 
            this.gridInvoices.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridInvoices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridInvoices.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridInvoices.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridInvoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridInvoices.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridInvoices.EnableHeadersVisualStyles = false;
            this.gridInvoices.GridColor = System.Drawing.Color.White;
            this.gridInvoices.Location = new System.Drawing.Point(14, 206);
            this.gridInvoices.Name = "gridInvoices";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.gridInvoices.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.gridInvoices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridInvoices.Size = new System.Drawing.Size(869, 307);
            this.gridInvoices.TabIndex = 77;
            // 
            // txtLecturerName
            // 
            this.txtLecturerName.Location = new System.Drawing.Point(241, 126);
            this.txtLecturerName.Name = "txtLecturerName";
            this.txtLecturerName.ReadOnly = true;
            this.txtLecturerName.Size = new System.Drawing.Size(330, 21);
            this.txtLecturerName.TabIndex = 80;
            // 
            // txtLecturerID
            // 
            this.txtLecturerID.Location = new System.Drawing.Point(136, 126);
            this.txtLecturerID.Name = "txtLecturerID";
            this.txtLecturerID.ReadOnly = true;
            this.txtLecturerID.Size = new System.Drawing.Size(99, 21);
            this.txtLecturerID.TabIndex = 79;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 78;
            this.label2.Text = "Lecturer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 15);
            this.label3.TabIndex = 81;
            this.label3.Text = "Student Attendance";
            // 
            // frm_Attendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(895, 525);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLecturerName);
            this.Controls.Add(this.txtLecturerID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gridInvoices);
            this.Controls.Add(this.txt_CourseName);
            this.Controls.Add(this.txt_CourseId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_RegistrationId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel_Buttons);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.txtStudentId);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Attendance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Attendance";
            this.Load += new System.EventHandler(this.frm_Attendance_Load);
            this.panel_Buttons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridInvoices)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel_Buttons;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.TextBox txtStudentId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_RegistrationId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_CourseName;
        private System.Windows.Forms.TextBox txt_CourseId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView gridInvoices;
        private System.Windows.Forms.TextBox txtLecturerName;
        private System.Windows.Forms.TextBox txtLecturerID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}