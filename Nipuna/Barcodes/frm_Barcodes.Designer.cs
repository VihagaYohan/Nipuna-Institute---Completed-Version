namespace Nipuna.Barcodes
{
    partial class frm_Barcodes
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
            this.label1 = new System.Windows.Forms.Label();
            this.gridBarcode = new System.Windows.Forms.DataGridView();
            this.txt_StudentId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_RegistrationId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_StudentName = new System.Windows.Forms.TextBox();
            this.txt_Find = new MetroFramework.Controls.MetroTextBox();
            this.btn_Proceed = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridBarcode)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student ID";
            // 
            // gridBarcode
            // 
            this.gridBarcode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridBarcode.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridBarcode.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridBarcode.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridBarcode.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridBarcode.EnableHeadersVisualStyles = false;
            this.gridBarcode.GridColor = System.Drawing.Color.SteelBlue;
            this.gridBarcode.Location = new System.Drawing.Point(12, 148);
            this.gridBarcode.Name = "gridBarcode";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.gridBarcode.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.gridBarcode.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridBarcode.Size = new System.Drawing.Size(832, 240);
            this.gridBarcode.TabIndex = 6;
            this.gridBarcode.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gridBarcode_MouseDoubleClick);
            // 
            // txt_StudentId
            // 
            this.txt_StudentId.Location = new System.Drawing.Point(151, 32);
            this.txt_StudentId.Name = "txt_StudentId";
            this.txt_StudentId.Size = new System.Drawing.Size(182, 21);
            this.txt_StudentId.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Student Name";
            // 
            // txt_RegistrationId
            // 
            this.txt_RegistrationId.Location = new System.Drawing.Point(151, 86);
            this.txt_RegistrationId.Name = "txt_RegistrationId";
            this.txt_RegistrationId.Size = new System.Drawing.Size(182, 21);
            this.txt_RegistrationId.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Course Registration ID";
            // 
            // txt_StudentName
            // 
            this.txt_StudentName.Location = new System.Drawing.Point(151, 59);
            this.txt_StudentName.Name = "txt_StudentName";
            this.txt_StudentName.Size = new System.Drawing.Size(401, 21);
            this.txt_StudentName.TabIndex = 9;
            // 
            // txt_Find
            // 
            this.txt_Find.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txt_Find.CustomButton.Image = null;
            this.txt_Find.CustomButton.Location = new System.Drawing.Point(241, 1);
            this.txt_Find.CustomButton.Name = "";
            this.txt_Find.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_Find.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_Find.CustomButton.TabIndex = 1;
            this.txt_Find.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_Find.CustomButton.UseSelectable = true;
            this.txt_Find.CustomButton.Visible = false;
            this.txt_Find.Lines = new string[0];
            this.txt_Find.Location = new System.Drawing.Point(584, 18);
            this.txt_Find.MaxLength = 32767;
            this.txt_Find.Name = "txt_Find";
            this.txt_Find.PasswordChar = '\0';
            this.txt_Find.PromptText = "Enter Name / Student ID";
            this.txt_Find.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_Find.SelectedText = "";
            this.txt_Find.SelectionLength = 0;
            this.txt_Find.SelectionStart = 0;
            this.txt_Find.ShortcutsEnabled = true;
            this.txt_Find.Size = new System.Drawing.Size(263, 23);
            this.txt_Find.TabIndex = 12;
            this.txt_Find.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Find.UseSelectable = true;
            this.txt_Find.WaterMark = "Enter Name / Student ID";
            this.txt_Find.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_Find.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_Find.TextChanged += new System.EventHandler(this.txt_Find_TextChanged);
            // 
            // btn_Proceed
            // 
            this.btn_Proceed.Location = new System.Drawing.Point(150, 122);
            this.btn_Proceed.Name = "btn_Proceed";
            this.btn_Proceed.Size = new System.Drawing.Size(75, 23);
            this.btn_Proceed.TabIndex = 13;
            this.btn_Proceed.Text = "Proceed";
            this.btn_Proceed.UseVisualStyleBackColor = true;
            this.btn_Proceed.Click += new System.EventHandler(this.btn_Proceed_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(231, 122);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 14;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "Barocde Form";
            // 
            // frm_Barcodes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(859, 400);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Proceed);
            this.Controls.Add(this.txt_Find);
            this.Controls.Add(this.txt_RegistrationId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_StudentName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_StudentId);
            this.Controls.Add(this.gridBarcode);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Barcodes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Print Barcode";
            this.Load += new System.EventHandler(this.frm_Barcordes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridBarcode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridBarcode;
        private System.Windows.Forms.TextBox txt_StudentId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_RegistrationId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_StudentName;
        private MetroFramework.Controls.MetroTextBox txt_Find;
        private System.Windows.Forms.Button btn_Proceed;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Label label4;
    }
}