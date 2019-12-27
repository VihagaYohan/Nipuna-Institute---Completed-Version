namespace Nipuna.Lecturers
{
    partial class frm_assignCourses
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.tab_AllRegistrations = new MetroFramework.Controls.MetroTabPage();
            this.gridCourseAssignments = new System.Windows.Forms.DataGridView();
            this.txtFind = new MetroFramework.Controls.MetroTextBox();
            this.tab_Manage = new MetroFramework.Controls.MetroTabPage();
            this.btnClose = new System.Windows.Forms.Button();
            this.gridLecturer = new System.Windows.Forms.DataGridView();
            this.txtFindLecturer = new MetroFramework.Controls.MetroTextBox();
            this.gridCourse = new System.Windows.Forms.DataGridView();
            this.txtCourseId = new System.Windows.Forms.TextBox();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.panel_Buttons = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtLecturerId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLecturerName = new System.Windows.Forms.TextBox();
            this.Student = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.metroTabControl1.SuspendLayout();
            this.tab_AllRegistrations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCourseAssignments)).BeginInit();
            this.tab_Manage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLecturer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCourse)).BeginInit();
            this.panel_Buttons.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.tab_AllRegistrations);
            this.metroTabControl1.Controls.Add(this.tab_Manage);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(0, 0);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(1054, 434);
            this.metroTabControl1.TabIndex = 4;
            this.metroTabControl1.UseSelectable = true;
            // 
            // tab_AllRegistrations
            // 
            this.tab_AllRegistrations.Controls.Add(this.gridCourseAssignments);
            this.tab_AllRegistrations.Controls.Add(this.txtFind);
            this.tab_AllRegistrations.HorizontalScrollbarBarColor = true;
            this.tab_AllRegistrations.HorizontalScrollbarHighlightOnWheel = false;
            this.tab_AllRegistrations.HorizontalScrollbarSize = 3;
            this.tab_AllRegistrations.Location = new System.Drawing.Point(4, 38);
            this.tab_AllRegistrations.Name = "tab_AllRegistrations";
            this.tab_AllRegistrations.Size = new System.Drawing.Size(1046, 392);
            this.tab_AllRegistrations.TabIndex = 0;
            this.tab_AllRegistrations.Text = "Courses";
            this.tab_AllRegistrations.VerticalScrollbarBarColor = true;
            this.tab_AllRegistrations.VerticalScrollbarHighlightOnWheel = false;
            this.tab_AllRegistrations.VerticalScrollbarSize = 3;
            // 
            // gridCourseAssignments
            // 
            this.gridCourseAssignments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridCourseAssignments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridCourseAssignments.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridCourseAssignments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridCourseAssignments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridCourseAssignments.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridCourseAssignments.EnableHeadersVisualStyles = false;
            this.gridCourseAssignments.GridColor = System.Drawing.Color.SteelBlue;
            this.gridCourseAssignments.Location = new System.Drawing.Point(9, 60);
            this.gridCourseAssignments.Name = "gridCourseAssignments";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.gridCourseAssignments.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.gridCourseAssignments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridCourseAssignments.Size = new System.Drawing.Size(1026, 316);
            this.gridCourseAssignments.TabIndex = 4;
            this.gridCourseAssignments.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gridRegistration_MouseDoubleClick);
            // 
            // txtFind
            // 
            this.txtFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtFind.CustomButton.Image = null;
            this.txtFind.CustomButton.Location = new System.Drawing.Point(225, 1);
            this.txtFind.CustomButton.Name = "";
            this.txtFind.CustomButton.Size = new System.Drawing.Size(21, 22);
            this.txtFind.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFind.CustomButton.TabIndex = 1;
            this.txtFind.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFind.CustomButton.UseSelectable = true;
            this.txtFind.CustomButton.Visible = false;
            this.txtFind.Lines = new string[0];
            this.txtFind.Location = new System.Drawing.Point(748, 18);
            this.txtFind.MaxLength = 32767;
            this.txtFind.Name = "txtFind";
            this.txtFind.PasswordChar = '\0';
            this.txtFind.PromptText = "Enter Course ID / Name";
            this.txtFind.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFind.SelectedText = "";
            this.txtFind.SelectionLength = 0;
            this.txtFind.SelectionStart = 0;
            this.txtFind.ShortcutsEnabled = true;
            this.txtFind.Size = new System.Drawing.Size(288, 27);
            this.txtFind.TabIndex = 2;
            this.txtFind.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFind.UseSelectable = true;
            this.txtFind.WaterMark = "Enter Course ID / Name";
            this.txtFind.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFind.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtFind.TextChanged += new System.EventHandler(this.txtFind_TextChanged);
            // 
            // tab_Manage
            // 
            this.tab_Manage.BackColor = System.Drawing.Color.White;
            this.tab_Manage.Controls.Add(this.label4);
            this.tab_Manage.Controls.Add(this.btnClose);
            this.tab_Manage.Controls.Add(this.gridLecturer);
            this.tab_Manage.Controls.Add(this.txtFindLecturer);
            this.tab_Manage.Controls.Add(this.gridCourse);
            this.tab_Manage.Controls.Add(this.txtCourseId);
            this.tab_Manage.Controls.Add(this.txtCourseName);
            this.tab_Manage.Controls.Add(this.panel_Buttons);
            this.tab_Manage.Controls.Add(this.txtLecturerId);
            this.tab_Manage.Controls.Add(this.label2);
            this.tab_Manage.Controls.Add(this.txtLecturerName);
            this.tab_Manage.Controls.Add(this.Student);
            this.tab_Manage.HorizontalScrollbarBarColor = true;
            this.tab_Manage.HorizontalScrollbarHighlightOnWheel = false;
            this.tab_Manage.HorizontalScrollbarSize = 3;
            this.tab_Manage.Location = new System.Drawing.Point(4, 38);
            this.tab_Manage.Name = "tab_Manage";
            this.tab_Manage.Size = new System.Drawing.Size(1046, 392);
            this.tab_Manage.TabIndex = 1;
            this.tab_Manage.Text = "Manage";
            this.tab_Manage.VerticalScrollbarBarColor = true;
            this.tab_Manage.VerticalScrollbarHighlightOnWheel = false;
            this.tab_Manage.VerticalScrollbarSize = 3;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.Location = new System.Drawing.Point(1012, -1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(26, 28);
            this.btnClose.TabIndex = 61;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // gridLecturer
            // 
            this.gridLecturer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridLecturer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridLecturer.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridLecturer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gridLecturer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridLecturer.DefaultCellStyle = dataGridViewCellStyle5;
            this.gridLecturer.EnableHeadersVisualStyles = false;
            this.gridLecturer.GridColor = System.Drawing.Color.White;
            this.gridLecturer.Location = new System.Drawing.Point(12, 200);
            this.gridLecturer.Name = "gridLecturer";
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.gridLecturer.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.gridLecturer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridLecturer.Size = new System.Drawing.Size(1026, 176);
            this.gridLecturer.TabIndex = 59;
            this.gridLecturer.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gridLecturer_MouseDoubleClick);
            // 
            // txtFindLecturer
            // 
            // 
            // 
            // 
            this.txtFindLecturer.CustomButton.Image = null;
            this.txtFindLecturer.CustomButton.Location = new System.Drawing.Point(375, 1);
            this.txtFindLecturer.CustomButton.Name = "";
            this.txtFindLecturer.CustomButton.Size = new System.Drawing.Size(21, 22);
            this.txtFindLecturer.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFindLecturer.CustomButton.TabIndex = 1;
            this.txtFindLecturer.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFindLecturer.CustomButton.UseSelectable = true;
            this.txtFindLecturer.CustomButton.Visible = false;
            this.txtFindLecturer.Lines = new string[0];
            this.txtFindLecturer.Location = new System.Drawing.Point(12, 165);
            this.txtFindLecturer.MaxLength = 32767;
            this.txtFindLecturer.Name = "txtFindLecturer";
            this.txtFindLecturer.PasswordChar = '\0';
            this.txtFindLecturer.PromptText = "Enter Lecturer Name / ID";
            this.txtFindLecturer.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFindLecturer.SelectedText = "";
            this.txtFindLecturer.SelectionLength = 0;
            this.txtFindLecturer.SelectionStart = 0;
            this.txtFindLecturer.ShortcutsEnabled = true;
            this.txtFindLecturer.Size = new System.Drawing.Size(463, 27);
            this.txtFindLecturer.TabIndex = 58;
            this.txtFindLecturer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFindLecturer.UseSelectable = true;
            this.txtFindLecturer.WaterMark = "Enter Lecturer Name / ID";
            this.txtFindLecturer.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFindLecturer.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtFindLecturer.TextChanged += new System.EventHandler(this.txtFindLecturer_TextChanged);
            // 
            // gridCourse
            // 
            this.gridCourse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridCourse.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridCourse.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridCourse.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.gridCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridCourse.DefaultCellStyle = dataGridViewCellStyle8;
            this.gridCourse.EnableHeadersVisualStyles = false;
            this.gridCourse.GridColor = System.Drawing.Color.White;
            this.gridCourse.Location = new System.Drawing.Point(575, 27);
            this.gridCourse.Name = "gridCourse";
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            this.gridCourse.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.gridCourse.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridCourse.Size = new System.Drawing.Size(463, 165);
            this.gridCourse.TabIndex = 57;
            this.gridCourse.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gridCourse_MouseDoubleClick);
            // 
            // txtCourseId
            // 
            this.txtCourseId.Location = new System.Drawing.Point(145, 59);
            this.txtCourseId.Name = "txtCourseId";
            this.txtCourseId.Size = new System.Drawing.Size(108, 21);
            this.txtCourseId.TabIndex = 14;
            this.txtCourseId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCourseId_KeyDown);
            // 
            // txtCourseName
            // 
            this.txtCourseName.Location = new System.Drawing.Point(260, 59);
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.ReadOnly = true;
            this.txtCourseName.Size = new System.Drawing.Size(296, 21);
            this.txtCourseName.TabIndex = 13;
            // 
            // panel_Buttons
            // 
            this.panel_Buttons.Controls.Add(this.btnCancel);
            this.panel_Buttons.Controls.Add(this.btnAdd);
            this.panel_Buttons.Controls.Add(this.btnEdit);
            this.panel_Buttons.Controls.Add(this.btnDelete);
            this.panel_Buttons.Location = new System.Drawing.Point(145, 96);
            this.panel_Buttons.Name = "panel_Buttons";
            this.panel_Buttons.Size = new System.Drawing.Size(411, 43);
            this.panel_Buttons.TabIndex = 12;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(304, 8);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(87, 27);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(21, 8);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(87, 27);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(115, 8);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(87, 27);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(210, 8);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(87, 27);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtLecturerId
            // 
            this.txtLecturerId.Location = new System.Drawing.Point(145, 27);
            this.txtLecturerId.Name = "txtLecturerId";
            this.txtLecturerId.Size = new System.Drawing.Size(108, 21);
            this.txtLecturerId.TabIndex = 5;
            this.txtLecturerId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLecturerId_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Course Name";
            // 
            // txtLecturerName
            // 
            this.txtLecturerName.Location = new System.Drawing.Point(260, 27);
            this.txtLecturerName.Name = "txtLecturerName";
            this.txtLecturerName.ReadOnly = true;
            this.txtLecturerName.Size = new System.Drawing.Size(296, 21);
            this.txtLecturerName.TabIndex = 3;
            // 
            // Student
            // 
            this.Student.AutoSize = true;
            this.Student.Location = new System.Drawing.Point(9, 27);
            this.Student.Name = "Student";
            this.Student.Size = new System.Drawing.Size(86, 15);
            this.Student.TabIndex = 2;
            this.Student.Text = "Lecturer Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(9, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 15);
            this.label4.TabIndex = 62;
            this.label4.Text = "Assign Courses ";
            // 
            // frm_assignCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 434);
            this.Controls.Add(this.metroTabControl1);
            this.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_assignCourses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Assign Courses";
            this.Load += new System.EventHandler(this.frm_assignCourses_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.tab_AllRegistrations.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCourseAssignments)).EndInit();
            this.tab_Manage.ResumeLayout(false);
            this.tab_Manage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLecturer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCourse)).EndInit();
            this.panel_Buttons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage tab_AllRegistrations;
        private System.Windows.Forms.DataGridView gridCourseAssignments;
        private MetroFramework.Controls.MetroTextBox txtFind;
        private MetroFramework.Controls.MetroTabPage tab_Manage;
        private System.Windows.Forms.TextBox txtCourseId;
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.Panel panel_Buttons;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtLecturerId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLecturerName;
        private System.Windows.Forms.Label Student;
        private System.Windows.Forms.DataGridView gridCourse;
        private System.Windows.Forms.DataGridView gridLecturer;
        private MetroFramework.Controls.MetroTextBox txtFindLecturer;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label4;
    }
}