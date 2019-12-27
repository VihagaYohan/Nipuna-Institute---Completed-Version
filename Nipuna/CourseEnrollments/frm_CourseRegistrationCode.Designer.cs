namespace Nipuna.CourseEnrollments
{
    partial class frm_CourseRegistrationCode
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
            this.pic_Barcode = new System.Windows.Forms.PictureBox();
            this.btn_Print = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Barcode)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pic_Barcode
            // 
            this.pic_Barcode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pic_Barcode.Location = new System.Drawing.Point(11, 15);
            this.pic_Barcode.Name = "pic_Barcode";
            this.pic_Barcode.Size = new System.Drawing.Size(230, 98);
            this.pic_Barcode.TabIndex = 0;
            this.pic_Barcode.TabStop = false;
            // 
            // btn_Print
            // 
            this.btn_Print.Location = new System.Drawing.Point(76, 119);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(107, 23);
            this.btn_Print.TabIndex = 1;
            this.btn_Print.Text = "Print Barcode";
            this.btn_Print.UseVisualStyleBackColor = true;
            this.btn_Print.Click += new System.EventHandler(this.btn_Print_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pic_Barcode);
            this.panel1.Controls.Add(this.btn_Print);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(251, 161);
            this.panel1.TabIndex = 2;
            // 
            // frm_CourseRegistrationCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 149);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "frm_CourseRegistrationCode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Course Registration Barcode";
            this.Load += new System.EventHandler(this.frm_CourseRegistrationCode_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Barcode)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_Barcode;
        private System.Windows.Forms.Button btn_Print;
        private System.Windows.Forms.Panel panel1;
    }
}