namespace Nipuna.StudentPaymnet
{
    partial class frm_StudentPayment
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtLecturerName = new System.Windows.Forms.TextBox();
            this.txtLectuerId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtInvoiceNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.gridCourses = new System.Windows.Forms.DataGridView();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.txtCourseId = new System.Windows.Forms.TextBox();
            this.panel_Buttons = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFee = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.txtRegistrationId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gridPayment = new System.Windows.Forms.DataGridView();
            this.txt_Find = new MetroFramework.Controls.MetroTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.datePayment = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_LastPaidMonth = new System.Windows.Forms.TextBox();
            this.chk_AbsentPayment = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridCourses)).BeginInit();
            this.panel_Buttons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPayment)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLecturerName
            // 
            this.txtLecturerName.Location = new System.Drawing.Point(238, 126);
            this.txtLecturerName.Name = "txtLecturerName";
            this.txtLecturerName.ReadOnly = true;
            this.txtLecturerName.Size = new System.Drawing.Size(267, 21);
            this.txtLecturerName.TabIndex = 81;
            // 
            // txtLectuerId
            // 
            this.txtLectuerId.Location = new System.Drawing.Point(118, 126);
            this.txtLectuerId.Name = "txtLectuerId";
            this.txtLectuerId.Size = new System.Drawing.Size(114, 21);
            this.txtLectuerId.TabIndex = 80;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 15);
            this.label8.TabIndex = 79;
            this.label8.Text = "Lecturer";
            // 
            // txtInvoiceNo
            // 
            this.txtInvoiceNo.Location = new System.Drawing.Point(118, 41);
            this.txtInvoiceNo.Name = "txtInvoiceNo";
            this.txtInvoiceNo.ReadOnly = true;
            this.txtInvoiceNo.Size = new System.Drawing.Size(114, 21);
            this.txtInvoiceNo.TabIndex = 78;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 15);
            this.label7.TabIndex = 77;
            this.label7.Text = "Invoice No.";
            // 
            // gridCourses
            // 
            this.gridCourses.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridCourses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridCourses.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridCourses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridCourses.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridCourses.EnableHeadersVisualStyles = false;
            this.gridCourses.GridColor = System.Drawing.Color.White;
            this.gridCourses.Location = new System.Drawing.Point(510, 68);
            this.gridCourses.Name = "gridCourses";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.gridCourses.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.gridCourses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridCourses.Size = new System.Drawing.Size(329, 223);
            this.gridCourses.TabIndex = 76;
            this.gridCourses.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gridCourses_MouseDoubleClick);
            // 
            // txtCourseName
            // 
            this.txtCourseName.Location = new System.Drawing.Point(238, 99);
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.ReadOnly = true;
            this.txtCourseName.Size = new System.Drawing.Size(267, 21);
            this.txtCourseName.TabIndex = 75;
            // 
            // txtCourseId
            // 
            this.txtCourseId.Location = new System.Drawing.Point(118, 99);
            this.txtCourseId.Name = "txtCourseId";
            this.txtCourseId.Size = new System.Drawing.Size(114, 21);
            this.txtCourseId.TabIndex = 74;
            this.txtCourseId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCourseId_KeyDown);
            // 
            // panel_Buttons
            // 
            this.panel_Buttons.Controls.Add(this.btnCancel);
            this.panel_Buttons.Controls.Add(this.btnDelete);
            this.panel_Buttons.Controls.Add(this.btnEdit);
            this.panel_Buttons.Controls.Add(this.btnSave);
            this.panel_Buttons.Location = new System.Drawing.Point(118, 249);
            this.panel_Buttons.Name = "panel_Buttons";
            this.panel_Buttons.Size = new System.Drawing.Size(387, 43);
            this.panel_Buttons.TabIndex = 73;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(290, 7);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(87, 27);
            this.btnCancel.TabIndex = 25;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(196, 7);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(87, 27);
            this.btnDelete.TabIndex = 24;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(101, 7);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(87, 27);
            this.btnEdit.TabIndex = 23;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(7, 7);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(87, 27);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtBalance
            // 
            this.txtBalance.Location = new System.Drawing.Point(337, 155);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.ReadOnly = true;
            this.txtBalance.Size = new System.Drawing.Size(114, 21);
            this.txtBalance.TabIndex = 72;
            this.txtBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(238, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 15);
            this.label6.TabIndex = 71;
            this.label6.Text = "Balance ( Rs. )";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(122, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 15);
            this.label5.TabIndex = 70;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(118, 185);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(114, 21);
            this.txtAmount.TabIndex = 69;
            this.txtAmount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAmount_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 68;
            this.label4.Text = "Amount ( Rs. )";
            // 
            // txtFee
            // 
            this.txtFee.Location = new System.Drawing.Point(118, 155);
            this.txtFee.Name = "txtFee";
            this.txtFee.ReadOnly = true;
            this.txtFee.Size = new System.Drawing.Size(114, 21);
            this.txtFee.TabIndex = 67;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 66;
            this.label3.Text = "Fee ( Rs. )";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 65;
            this.label2.Text = "Course";
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(238, 69);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.ReadOnly = true;
            this.txtStudentName.Size = new System.Drawing.Size(267, 21);
            this.txtStudentName.TabIndex = 64;
            // 
            // txtRegistrationId
            // 
            this.txtRegistrationId.Location = new System.Drawing.Point(118, 69);
            this.txtRegistrationId.Name = "txtRegistrationId";
            this.txtRegistrationId.Size = new System.Drawing.Size(114, 21);
            this.txtRegistrationId.TabIndex = 63;
            this.txtRegistrationId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRegistrationId_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 15);
            this.label1.TabIndex = 62;
            this.label1.Text = "Registration ID";
            // 
            // gridPayment
            // 
            this.gridPayment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridPayment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridPayment.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridPayment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gridPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPayment.EnableHeadersVisualStyles = false;
            this.gridPayment.GridColor = System.Drawing.Color.SteelBlue;
            this.gridPayment.Location = new System.Drawing.Point(10, 297);
            this.gridPayment.Name = "gridPayment";
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.gridPayment.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.gridPayment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridPayment.Size = new System.Drawing.Size(830, 275);
            this.gridPayment.TabIndex = 61;
            this.gridPayment.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gridPayment_MouseDoubleClick);
            // 
            // txt_Find
            // 
            this.txt_Find.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txt_Find.CustomButton.Image = null;
            this.txt_Find.CustomButton.Location = new System.Drawing.Point(307, 1);
            this.txt_Find.CustomButton.Name = "";
            this.txt_Find.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_Find.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_Find.CustomButton.TabIndex = 1;
            this.txt_Find.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_Find.CustomButton.UseSelectable = true;
            this.txt_Find.CustomButton.Visible = false;
            this.txt_Find.Lines = new string[0];
            this.txt_Find.Location = new System.Drawing.Point(510, 38);
            this.txt_Find.MaxLength = 32767;
            this.txt_Find.Name = "txt_Find";
            this.txt_Find.PasswordChar = '\0';
            this.txt_Find.PromptText = "Enter Registration ID / Invoice No. / Course ID/ Lecturer ID";
            this.txt_Find.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_Find.SelectedText = "";
            this.txt_Find.SelectionLength = 0;
            this.txt_Find.SelectionStart = 0;
            this.txt_Find.ShortcutsEnabled = true;
            this.txt_Find.Size = new System.Drawing.Size(329, 23);
            this.txt_Find.TabIndex = 82;
            this.txt_Find.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Find.UseSelectable = true;
            this.txt_Find.WaterMark = "Enter Registration ID / Invoice No. / Course ID/ Lecturer ID";
            this.txt_Find.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_Find.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_Find.TextChanged += new System.EventHandler(this.txtFind_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 221);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 15);
            this.label9.TabIndex = 83;
            this.label9.Text = "Paid Month";
            // 
            // datePayment
            // 
            this.datePayment.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePayment.Location = new System.Drawing.Point(118, 215);
            this.datePayment.Name = "datePayment";
            this.datePayment.Size = new System.Drawing.Size(114, 21);
            this.datePayment.TabIndex = 84;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(238, 188);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 15);
            this.label10.TabIndex = 85;
            this.label10.Text = "Last Paid Month";
            // 
            // txt_LastPaidMonth
            // 
            this.txt_LastPaidMonth.Location = new System.Drawing.Point(337, 188);
            this.txt_LastPaidMonth.Name = "txt_LastPaidMonth";
            this.txt_LastPaidMonth.ReadOnly = true;
            this.txt_LastPaidMonth.Size = new System.Drawing.Size(114, 21);
            this.txt_LastPaidMonth.TabIndex = 86;
            this.txt_LastPaidMonth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chk_AbsentPayment
            // 
            this.chk_AbsentPayment.AutoSize = true;
            this.chk_AbsentPayment.Location = new System.Drawing.Point(337, 221);
            this.chk_AbsentPayment.Name = "chk_AbsentPayment";
            this.chk_AbsentPayment.Size = new System.Drawing.Size(111, 19);
            this.chk_AbsentPayment.TabIndex = 88;
            this.chk_AbsentPayment.Text = "Absent Payment";
            this.chk_AbsentPayment.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label11.Location = new System.Drawing.Point(23, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 15);
            this.label11.TabIndex = 89;
            this.label11.Text = "Payments";
            // 
            // frm_StudentPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(851, 587);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.chk_AbsentPayment);
            this.Controls.Add(this.txt_LastPaidMonth);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.datePayment);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_Find);
            this.Controls.Add(this.txtLecturerName);
            this.Controls.Add(this.txtLectuerId);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtInvoiceNo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.gridCourses);
            this.Controls.Add(this.txtCourseName);
            this.Controls.Add(this.txtCourseId);
            this.Controls.Add(this.panel_Buttons);
            this.Controls.Add(this.txtBalance);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFee);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.txtRegistrationId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridPayment);
            this.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_StudentPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Payment";
            this.Load += new System.EventHandler(this.frm_StudentPayment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridCourses)).EndInit();
            this.panel_Buttons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridPayment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLecturerName;
        private System.Windows.Forms.TextBox txtLectuerId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtInvoiceNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView gridCourses;
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.TextBox txtCourseId;
        private System.Windows.Forms.Panel panel_Buttons;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFee;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.TextBox txtRegistrationId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridPayment;
        private MetroFramework.Controls.MetroTextBox txt_Find;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker datePayment;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_LastPaidMonth;
        private System.Windows.Forms.CheckBox chk_AbsentPayment;
        private System.Windows.Forms.Label label11;
    }
}