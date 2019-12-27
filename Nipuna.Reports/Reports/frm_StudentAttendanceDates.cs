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
    public partial class frm_StudentAttendanceDates : Form
    {
        public frm_StudentAttendanceDates()
        {
            InitializeComponent();
        }

        private void frm_Sample_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'attendanceRecord.Attendances' table. You can move, or remove it, as needed.
            //this.attendancesTableAdapter.Fill(this.attendanceRecord.Attendances);

            this.reportViewer1.RefreshReport();
        }

        private void btn_Generate_Click(object sender, EventArgs e)
        {
            this.attendancesTableAdapter.Fill(this.attendanceRecord.Attendances, date_From.Text, date_To.Text);
            this.reportViewer1.RefreshReport();
        }
    }
}
