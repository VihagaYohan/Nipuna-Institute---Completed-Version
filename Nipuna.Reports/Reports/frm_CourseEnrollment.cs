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
    public partial class frm_CourseEnrollment : Form
    {
        public frm_CourseEnrollment()
        {
            InitializeComponent();
        }

        private void frm_CourseEnrollmentByStudentId_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentCourseEnrollmentDataSet.CourseEnrollments' table. You can move, or remove it, as needed.
            this.courseEnrollmentsTableAdapter.Fill(this.studentCourseEnrollmentDataSet.CourseEnrollments);

            this.reportViewer1.RefreshReport();
        }
    }
}
