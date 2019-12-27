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
    public partial class frm_StudentRegistration : Form
    {
        public frm_StudentRegistration()
        {
            InitializeComponent();
        }

        private void frm_StudentRegistration_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentRegistrationsDataSet.CourseEnrollments' table. You can move, or remove it, as needed.
            this.courseEnrollmentsTableAdapter.Fill(this.studentRegistrationsDataSet.CourseEnrollments);

            this.reportViewer1.RefreshReport();
        }
    }
}
