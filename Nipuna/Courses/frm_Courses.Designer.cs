namespace Nipuna.Courses
{
    partial class frm_Courses
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
            this.txtFind = new MetroFramework.Controls.MetroTextBox();
            this.panel_Buttons = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.gridCourses = new System.Windows.Forms.DataGridView();
            this.txtFee = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel_Buttons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCourses)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFind
            // 
            this.txtFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtFind.CustomButton.Image = null;
            this.txtFind.CustomButton.Location = new System.Drawing.Point(230, 1);
            this.txtFind.CustomButton.Name = "";
            this.txtFind.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtFind.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFind.CustomButton.TabIndex = 1;
            this.txtFind.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFind.CustomButton.UseSelectable = true;
            this.txtFind.CustomButton.Visible = false;
            this.txtFind.Lines = new string[0];
            this.txtFind.Location = new System.Drawing.Point(622, 25);
            this.txtFind.MaxLength = 32767;
            this.txtFind.Name = "txtFind";
            this.txtFind.PasswordChar = '\0';
            this.txtFind.PromptText = "Enter Course ID / Name";
            this.txtFind.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFind.SelectedText = "";
            this.txtFind.SelectionLength = 0;
            this.txtFind.SelectionStart = 0;
            this.txtFind.ShortcutsEnabled = true;
            this.txtFind.Size = new System.Drawing.Size(252, 23);
            this.txtFind.TabIndex = 18;
            this.txtFind.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFind.UseSelectable = true;
            this.txtFind.WaterMark = "Enter Course ID / Name";
            this.txtFind.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFind.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtFind.TextChanged += new System.EventHandler(this.txtFind_TextChanged_1);
            // 
            // panel_Buttons
            // 
            this.panel_Buttons.Controls.Add(this.btnCancel);
            this.panel_Buttons.Controls.Add(this.btnAdd);
            this.panel_Buttons.Controls.Add(this.btnEdit);
            this.panel_Buttons.Controls.Add(this.btnDelete);
            this.panel_Buttons.Location = new System.Drawing.Point(121, 97);
            this.panel_Buttons.Name = "panel_Buttons";
            this.panel_Buttons.Size = new System.Drawing.Size(352, 37);
            this.panel_Buttons.TabIndex = 14;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(261, 7);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(18, 7);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(99, 7);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click_1);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(180, 7);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // gridCourses
            // 
            this.gridCourses.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridCourses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridCourses.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridCourses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCourses.EnableHeadersVisualStyles = false;
            this.gridCourses.GridColor = System.Drawing.Color.SteelBlue;
            this.gridCourses.Location = new System.Drawing.Point(7, 139);
            this.gridCourses.Name = "gridCourses";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.gridCourses.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.gridCourses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridCourses.Size = new System.Drawing.Size(867, 357);
            this.gridCourses.TabIndex = 17;
            this.gridCourses.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gridCourses_MouseDoubleClick);
            // 
            // txtFee
            // 
            this.txtFee.Location = new System.Drawing.Point(121, 64);
            this.txtFee.Name = "txtFee";
            this.txtFee.Size = new System.Drawing.Size(145, 21);
            this.txtFee.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "Course Fee (Rs.)";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(121, 37);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(468, 21);
            this.txtTitle.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "Course Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 15);
            this.label4.TabIndex = 19;
            this.label4.Text = "Add Courses";
            // 
            // frm_Courses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 508);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFind);
            this.Controls.Add(this.panel_Buttons);
            this.Controls.Add(this.gridCourses);
            this.Controls.Add(this.txtFee);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Courses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Courses";
            this.Load += new System.EventHandler(this.frm_Courses_Load);
            this.panel_Buttons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCourses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtFind;
        private System.Windows.Forms.Panel panel_Buttons;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView gridCourses;
        private System.Windows.Forms.TextBox txtFee;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;

    }
}