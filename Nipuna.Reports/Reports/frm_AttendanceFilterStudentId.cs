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
    public partial class frm_AttendanceFilterStudentId : Form
    {
        public frm_AttendanceFilterStudentId()
        {
            InitializeComponent();
        }

        private void frm_AttendanceFilterStudentId_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void btn_Generate_Click(object sender, EventArgs e)
        {
            this.attendancesTableAdapter.Fill(this.attendanceFilterStudentId.Attendances, txt_RegistrationId.Text);
            this.reportViewer1.RefreshReport();
        }
    }
}
