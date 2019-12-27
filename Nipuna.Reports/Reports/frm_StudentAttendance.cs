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
    public partial class frm_StudentAttendance : Form
    {
        public frm_StudentAttendance()
        {
            InitializeComponent();
        }

        private void frm_StudentAttendance_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentAttendanceDataSet.Attendances' table. You can move, or remove it, as needed.
            this.attendancesTableAdapter.Fill(this.studentAttendanceDataSet.Attendances);

            this.reportViewer1.RefreshReport();
        }
    }
}
