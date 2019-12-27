using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nipuna.Reports.Reports
{
    public partial class frm_StudentDetailsFilterStudentId : Form
    {
        public frm_StudentDetailsFilterStudentId()
        {
            InitializeComponent();
        }

        private void frm_StudentDetailsFilterStudentId_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void btn_Generate_Click(object sender, EventArgs e)
        {
            this.studentsTableAdapter.Fill(this.studentDetailsFilterStudentId.Students, txt_Registration.Text);
            this.reportViewer1.RefreshReport();
        }
    }
}
