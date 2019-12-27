namespace Nipuna.CourseEnrollments
{
    partial class frm_CourseEnrollment
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.tab_AllRegistrations = new MetroFramework.Controls.MetroTabPage();
            this.btn_Delete_1 = new System.Windows.Forms.Button();
            this.gridRegistration = new System.Windows.Forms.DataGridView();
            this.txtFind = new MetroFramework.Controls.MetroTextBox();
            this.tab_Registration = new MetroFramework.Controls.MetroTabPage();
            this.btn_Delete_2 = new System.Windows.Forms.Button();
            this.txt_FindStudents = new MetroFramework.Controls.MetroTextBox();
            this.gridStudents = new System.Windows.Forms.DataGridView();
            this.gridLecturer = new System.Windows.Forms.DataGridView();
            this.txtLecturerId = new System.Windows.Forms.TextBox();
            this.txtLecturerName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateRegister = new System.Windows.Forms.DateTimePicker();
            this.txtCourseId = new System.Windows.Forms.TextBox();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.panel_Buttons = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtStudentId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.Student = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.metroTabControl1.SuspendLayout();
            this.tab_AllRegistrations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridRegistration)).BeginInit();
            this.tab_Registration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLecturer)).BeginInit();
            this.panel_Buttons.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.tab_AllRegistrations);
            this.metroTabControl1.Controls.Add(this.tab_Registration);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(0, 0);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(933, 519);
            this.metroTabControl1.TabIndex = 3;
            this.metroTabControl1.UseSelectable = true;
            // 
            // tab_AllRegistrations
            // 
            this.tab_AllRegistrations.Controls.Add(this.btn_Delete_1);
            this.tab_AllRegistrations.Controls.Add(this.gridRegistration);
            this.tab_AllRegistrations.Controls.Add(this.txtFind);
            this.tab_AllRegistrations.HorizontalScrollbarBarColor = true;
            this.tab_AllRegistrations.HorizontalScrollbarHighlightOnWheel = false;
            this.tab_AllRegistrations.HorizontalScrollbarSize = 3;
            this.tab_AllRegistrations.Location = new System.Drawing.Point(4, 38);
            this.tab_AllRegistrations.Name = "tab_AllRegistrations";
            this.tab_AllRegistrations.Size = new System.Drawing.Size(925, 477);
            this.tab_AllRegistrations.TabIndex = 0;
            this.tab_AllRegistrations.Text = "Registrations";
            this.tab_AllRegistrations.VerticalScrollbarBarColor = true;
            this.tab_AllRegistrations.VerticalScrollbarHighlightOnWheel = false;
            this.tab_AllRegistrations.VerticalScrollbarSize = 3;
            // 
            // btn_Delete_1
            // 
            this.btn_Delete_1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Delete_1.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete_1.ForeColor = System.Drawing.Color.Red;
            this.btn_Delete_1.Location = new System.Drawing.Point(881, 3);
            this.btn_Delete_1.Name = "btn_Delete_1";
            this.btn_Delete_1.Size = new System.Drawing.Size(36, 23);
            this.btn_Delete_1.TabIndex = 5;
            this.btn_Delete_1.Text = "X";
            this.btn_Delete_1.UseVisualStyleBackColor = true;
            this.btn_Delete_1.Click += new System.EventHandler(this.btn_Delete_1_Click);
            // 
            // gridRegistration
            // 
            this.gridRegistration.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridRegistration.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridRegistration.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridRegistration.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridRegistration.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridRegistration.EnableHeadersVisualStyles = false;
            this.gridRegistration.GridColor = System.Drawing.Color.SteelBlue;
            this.gridRegistration.Location = new System.Drawing.Point(8, 65);
            this.gridRegistration.Name = "gridRegistration";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.gridRegistration.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.gridRegistration.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridRegistration.Size = new System.Drawing.Size(909, 404);
            this.gridRegistration.TabIndex = 4;
            this.gridRegistration.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gridRegistration_MouseDoubleClick);
            // 
            // txtFind
            // 
            this.txtFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtFind.CustomButton.Image = null;
            this.txtFind.CustomButton.Location = new System.Drawing.Point(193, 1);
            this.txtFind.CustomButton.Name = "";
            this.txtFind.CustomButton.Size = new System.Drawing.Size(18, 18);
            this.txtFind.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFind.CustomButton.TabIndex = 1;
            this.txtFind.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFind.CustomButton.UseSelectable = true;
            this.txtFind.CustomButton.Visible = false;
            this.txtFind.Lines = new string[0];
            this.txtFind.Location = new System.Drawing.Point(670, 32);
            this.txtFind.MaxLength = 32767;
            this.txtFind.Name = "txtFind";
            this.txtFind.PasswordChar = '\0';
            this.txtFind.PromptText = "Enter Course ID / Name";
            this.txtFind.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFind.SelectedText = "";
            this.txtFind.SelectionLength = 0;
            this.txtFind.SelectionStart = 0;
            this.txtFind.ShortcutsEnabled = true;
            this.txtFind.Size = new System.Drawing.Size(247, 23);
            this.txtFind.TabIndex = 2;
            this.txtFind.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFind.UseSelectable = true;
            this.txtFind.WaterMark = "Enter Course ID / Name";
            this.txtFind.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFind.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtFind.TextChanged += new System.EventHandler(this.txtFind_TextChanged);
            // 
            // tab_Registration
            // 
            this.tab_Registration.BackColor = System.Drawing.Color.White;
            this.tab_Registration.Controls.Add(this.label4);
            this.tab_Registration.Controls.Add(this.btn_Delete_2);
            this.tab_Registration.Controls.Add(this.txt_FindStudents);
            this.tab_Registration.Controls.Add(this.gridStudents);
            this.tab_Registration.Controls.Add(this.gridLecturer);
            this.tab_Registration.Controls.Add(this.txtLecturerId);
            this.tab_Registration.Controls.Add(this.txtLecturerName);
            this.tab_Registration.Controls.Add(this.label1);
            this.tab_Registration.Controls.Add(this.label3);
            this.tab_Registration.Controls.Add(this.dateRegister);
            this.tab_Registration.Controls.Add(this.txtCourseId);
            this.tab_Registration.Controls.Add(this.txtCourseName);
            this.tab_Registration.Controls.Add(this.panel_Buttons);
            this.tab_Registration.Controls.Add(this.txtStudentId);
            this.tab_Registration.Controls.Add(this.label2);
            this.tab_Registration.Controls.Add(this.txtStudentName);
            this.tab_Registration.Controls.Add(this.Student);
            this.tab_Registration.HorizontalScrollbarBarColor = true;
            this.tab_Registration.HorizontalScrollbarHighlightOnWheel = false;
            this.tab_Registration.HorizontalScrollbarSize = 3;
            this.tab_Registration.Location = new System.Drawing.Point(4, 38);
            this.tab_Registration.Name = "tab_Registration";
            this.tab_Registration.Size = new System.Drawing.Size(925, 477);
            this.tab_Registration.TabIndex = 1;
            this.tab_Registration.Text = "Manage";
            this.tab_Registration.VerticalScrollbarBarColor = true;
            this.tab_Registration.VerticalScrollbarHighlightOnWheel = false;
            this.tab_Registration.VerticalScrollbarSize = 3;
            // 
            // btn_Delete_2
            // 
            this.btn_Delete_2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Delete_2.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete_2.ForeColor = System.Drawing.Color.Red;
            this.btn_Delete_2.Location = new System.Drawing.Point(881, 3);
            this.btn_Delete_2.Name = "btn_Delete_2";
            this.btn_Delete_2.Size = new System.Drawing.Size(36, 24);
            this.btn_Delete_2.TabIndex = 59;
            this.btn_Delete_2.Text = "X";
            this.btn_Delete_2.UseVisualStyleBackColor = true;
            this.btn_Delete_2.Click += new System.EventHandler(this.btn_Delete_2_Click);
            // 
            // txt_FindStudents
            // 
            this.txt_FindStudents.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txt_FindStudents.CustomButton.Image = null;
            this.txt_FindStudents.CustomButton.Location = new System.Drawing.Point(259, 1);
            this.txt_FindStudents.CustomButton.Name = "";
            this.txt_FindStudents.CustomButton.Size = new System.Drawing.Size(18, 18);
            this.txt_FindStudents.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_FindStudents.CustomButton.TabIndex = 1;
            this.txt_FindStudents.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_FindStudents.CustomButton.UseSelectable = true;
            this.txt_FindStudents.CustomButton.Visible = false;
            this.txt_FindStudents.Lines = new string[0];
            this.txt_FindStudents.Location = new System.Drawing.Point(6, 219);
            this.txt_FindStudents.MaxLength = 32767;
            this.txt_FindStudents.Name = "txt_FindStudents";
            this.txt_FindStudents.PasswordChar = '\0';
            this.txt_FindStudents.PromptText = "Enter Name / Student ID";
            this.txt_FindStudents.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_FindStudents.SelectedText = "";
            this.txt_FindStudents.SelectionLength = 0;
            this.txt_FindStudents.SelectionStart = 0;
            this.txt_FindStudents.ShortcutsEnabled = true;
            this.txt_FindStudents.Size = new System.Drawing.Size(324, 23);
            this.txt_FindStudents.TabIndex = 58;
            this.txt_FindStudents.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_FindStudents.UseSelectable = true;
            this.txt_FindStudents.WaterMark = "Enter Name / Student ID";
            this.txt_FindStudents.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_FindStudents.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_FindStudents.TextChanged += new System.EventHandler(this.txt_FindStudents_TextChanged);
            // 
            // gridStudents
            // 
            this.gridStudents.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridStudents.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridStudents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridStudents.EnableHeadersVisualStyles = false;
            this.gridStudents.GridColor = System.Drawing.Color.White;
            this.gridStudents.Location = new System.Drawing.Point(8, 251);
            this.gridStudents.Name = "gridStudents";
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.gridStudents.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gridStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridStudents.Size = new System.Drawing.Size(909, 218);
            this.gridStudents.TabIndex = 57;
            this.gridStudents.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gridStudents_MouseDoubleClick);
            // 
            // gridLecturer
            // 
            this.gridLecturer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridLecturer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridLecturer.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridLecturer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.gridLecturer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridLecturer.EnableHeadersVisualStyles = false;
            this.gridLecturer.GridColor = System.Drawing.Color.White;
            this.gridLecturer.Location = new System.Drawing.Point(569, 53);
            this.gridLecturer.Name = "gridLecturer";
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.gridLecturer.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.gridLecturer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridLecturer.Size = new System.Drawing.Size(344, 189);
            this.gridLecturer.TabIndex = 56;
            this.gridLecturer.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gridLecturer_MouseDoubleClick);
            // 
            // txtLecturerId
            // 
            this.txtLecturerId.Location = new System.Drawing.Point(120, 90);
            this.txtLecturerId.Name = "txtLecturerId";
            this.txtLecturerId.ReadOnly = true;
            this.txtLecturerId.Size = new System.Drawing.Size(123, 21);
            this.txtLecturerId.TabIndex = 20;
            // 
            // txtLecturerName
            // 
            this.txtLecturerName.Location = new System.Drawing.Point(249, 90);
            this.txtLecturerName.Name = "txtLecturerName";
            this.txtLecturerName.ReadOnly = true;
            this.txtLecturerName.Size = new System.Drawing.Size(304, 21);
            this.txtLecturerName.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "Lecturer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "Registered Date";
            // 
            // dateRegister
            // 
            this.dateRegister.CustomFormat = "dd/MM/yyyy";
            this.dateRegister.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateRegister.Location = new System.Drawing.Point(120, 117);
            this.dateRegister.Name = "dateRegister";
            this.dateRegister.Size = new System.Drawing.Size(123, 21);
            this.dateRegister.TabIndex = 16;
            // 
            // txtCourseId
            // 
            this.txtCourseId.Location = new System.Drawing.Point(120, 63);
            this.txtCourseId.Name = "txtCourseId";
            this.txtCourseId.Size = new System.Drawing.Size(123, 21);
            this.txtCourseId.TabIndex = 14;
            this.txtCourseId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCourseId_KeyDown);
            // 
            // txtCourseName
            // 
            this.txtCourseName.Location = new System.Drawing.Point(249, 63);
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.ReadOnly = true;
            this.txtCourseName.Size = new System.Drawing.Size(304, 21);
            this.txtCourseName.TabIndex = 13;
            // 
            // panel_Buttons
            // 
            this.panel_Buttons.Controls.Add(this.btnCancel);
            this.panel_Buttons.Controls.Add(this.btnAdd);
            this.panel_Buttons.Controls.Add(this.btnEdit);
            this.panel_Buttons.Controls.Add(this.btnDelete);
            this.panel_Buttons.Location = new System.Drawing.Point(120, 144);
            this.panel_Buttons.Name = "panel_Buttons";
            this.panel_Buttons.Size = new System.Drawing.Size(352, 37);
            this.panel_Buttons.TabIndex = 12;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(261, 7);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(18, 7);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(99, 7);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(180, 7);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtStudentId
            // 
            this.txtStudentId.Location = new System.Drawing.Point(120, 36);
            this.txtStudentId.Name = "txtStudentId";
            this.txtStudentId.Size = new System.Drawing.Size(123, 21);
            this.txtStudentId.TabIndex = 5;
            this.txtStudentId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtStudentId_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Course";
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(249, 36);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(304, 21);
            this.txtStudentName.TabIndex = 3;
            // 
            // Student
            // 
            this.Student.AutoSize = true;
            this.Student.Location = new System.Drawing.Point(4, 36);
            this.Student.Name = "Student";
            this.Student.Size = new System.Drawing.Size(48, 15);
            this.Student.TabIndex = 2;
            this.Student.Text = "Student";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(8, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 15);
            this.label4.TabIndex = 60;
            this.label4.Text = "Course Enrollment";
            // 
            // frm_CourseEnrollment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.metroTabControl1);
            this.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_CourseEnrollment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Course Registration";
            this.Load += new System.EventHandler(this.frm_CourseEnrollment_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.tab_AllRegistrations.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridRegistration)).EndInit();
            this.tab_Registration.ResumeLayout(false);
            this.tab_Registration.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLecturer)).EndInit();
            this.panel_Buttons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage tab_AllRegistrations;
        private System.Windows.Forms.DataGridView gridRegistration;
        private MetroFramework.Controls.MetroTextBox txtFind;
        private MetroFramework.Controls.MetroTabPage tab_Registration;
        private System.Windows.Forms.DataGridView gridLecturer;
        private System.Windows.Forms.TextBox txtLecturerId;
        private System.Windows.Forms.TextBox txtLecturerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateRegister;
        private System.Windows.Forms.TextBox txtCourseId;
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.Panel panel_Buttons;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtStudentId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Label Student;
        private System.Windows.Forms.DataGridView gridStudents;
        private MetroFramework.Controls.MetroTextBox txt_FindStudents;
        private System.Windows.Forms.Button btn_Delete_1;
        private System.Windows.Forms.Button btn_Delete_2;
        private System.Windows.Forms.Label label4;
    }
}