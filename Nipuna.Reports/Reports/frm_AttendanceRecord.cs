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
    public partial class frm_AttendanceRecord : Form
    {
        public frm_AttendanceRecord()
        {
            InitializeComponent();
        }

        private void frm_AttendanceRecord_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'attendanceRecord.Attendances' table. You can move, or remove it, as needed.
            //this.attendancesTableAdapter.Fill(this.attendanceRecord.Attendances);
            // TODO: This line of code loads data into the 'attendanceRecordDataSet.Attendances' table. You can move, or remove it, as needed.
            //this.attendancesTableAdapter.Fill(this.attendanceRecordDataSet.Attendances,date_From.Text,date_To.Text);

            //this.reportViewer1.RefreshReport();
        }

        private void btn_Generate_Click(object sender, EventArgs e)
        {
            this.attendancesTableAdapter.Fill(this.attendanceRecord.Attendances, date_From.Text, date_To.Text);
            this.reportViewer1.RefreshReport();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void date_To_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void date_From_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
